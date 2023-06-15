using Binance.Net.Clients;
using Binance.Net.Enums;
using CryptoExchange.Net.CommonObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TicTacTec.TA.Library;

namespace SimpleTradeBotAsp
{
    class TradeBot
    {
        private BinanceClient Client;


        //настройки бота
        public string TradePairBase = "AMB";
        public string TradePairQuote = "USDT";
        public string TradePairSymbol = "AMBUSDT";
        public int RsiPeriod = 7;
        public decimal OrderSizeQuote = 11;
        public int RsiTreshold = 50;
        public double PercentTakeProfit = 1.5;
        public double PercentStopLoss = 0.5;
        public int PricePrecision = 5;
        public int basePrecision = 0;
        public int quotePrecision = 0;
        public string LogFile = "SimpleTradeBot.txt";
        public bool OnlyOneSell = false; // не более одной покупки подряд
        public string direction = "short";

        //текущие значения работы бота
        private decimal BaseBalance = 0;
        private decimal QuoteBalance = 0;
        private decimal CurrentPrice = 0;
        private double CurrentRsi = 0;
        private decimal TpPrice = 0;
        private decimal SlPrice = 0;

        public TradeBot()
        {
            Client = new BinanceClient();
            Client.SetApiCredentials(new Binance.Net.Objects.BinanceApiCredentials(
                "p39EYe4QxRZS2dXgSL73xCspn88TCQNLQd93ZUKE7rkCuyd2jADi1AD4KntKApv3",
                "tudhsqIz826OAOuaD1dx0ER1cGnrDNzPeKq2pQYIIlVirbbLPipcHrLeZolhTmpN"));
        }

        private void WriteToLog(string msg)
        {
            string text = DateTime.Now.ToString() + " " + TradePairSymbol + " "
                + direction + ". "
                + msg +
                ". Текущая цена: " + Math.Round(CurrentPrice, PricePrecision) +
                ". RSI: " + Math.Round(CurrentRsi, 1) +
                ". Баланс: " + Math.Round(BaseBalance, 2) + " "+TradePairBase + ", " +
                Math.Round(QuoteBalance, 2) + " "+TradePairQuote;

            Console.WriteLine(text);
            File.AppendAllText(LogFile, text + Environment.NewLine);
        }

        //шаг торговли шорт или лонг
        public void TradeStep()
        {
            if (direction == "short")
                TradeStepShort();
            else if (direction == "long")
                TradeStepLong();
        }

        //шаг шорт торговли, продает, если надо и оставляет ордер на покупку
        public void TradeStepShort()
        {
            bool bos = GetShortBuyOrderStatus();

            //получаем историю цен
            List<Kline> klines = null;
            while (klines == null)
                klines = GetLastKLines(RsiPeriod * 6);

            CurrentPrice = (decimal)klines[klines.Count - 1].ClosePrice;

            //вычисляем массив rsi
            double[] rsi = CalculateRSISeries(klines);
            //предыдущее значение rsi
            double prevRsi = rsi[rsi.Length - 2];
            //текущее значение rsi
            CurrentRsi = rsi[rsi.Length - 1];

            QuoteBalance = GetBalanceMargin(TradePairQuote);
            BaseBalance = GetBalanceMarginBorrowed(TradePairBase);

            //если нет ордера на покупку и rsi больше порога и есть доллары на покупку, то продаем и покупаем
            if (bos == false && CurrentRsi >= RsiTreshold)
            {
                //размещаем ордер на покупку только если предыдущее значение было ниже порога
                if (OnlyOneSell && prevRsi < RsiTreshold && QuoteBalance >= OrderSizeQuote)
                    PlaceShortSellOrder();
                else if (!OnlyOneSell)
                    PlaceShortSellOrder();
                else
                {
                    WriteToLog("Ордер на продажу не размещен (защита от сделок подряд)");

                    return;
                }

                BaseBalance = GetBalanceMarginBorrowed(TradePairBase);
                PlaceShortBuyOrder();

                WriteToLog("Продали и разместили новый ордер на покупку. Цена takeProfit: "+TpPrice+". Цена stopLoss: "+ SlPrice);
            }
            else
            {
                WriteToLog(
                    (bos ? "Ордер на покупку уже выставлен" : "Ордер на покупку не выставлен"));
            }

        }


        //возвращает true если ордер на продажу всё еще размещен и не выполнен и не отменен
        public bool GetShortBuyOrderStatus()
        {
            var buyOrder = Client.SpotApi.Trading.GetMarginOcoOrderAsync(null, false, null, TradePairSymbol + "_oco_buy");
            buyOrder.Wait();

            if (buyOrder.Result.Data != null)
                return (buyOrder.Result.Data.ListOrderStatus == ListOrderStatus.Executing);
            else
                return false;
        }

        //размещает oco ордер на маржинальную покупку
        public void PlaceShortBuyOrder()
        {
            double tpCoef = (100 - PercentTakeProfit) / 100;
            double slCoef = (100 + PercentStopLoss) / 100;

            TpPrice = (decimal)Math.Round((double)CurrentPrice * tpCoef, PricePrecision);
            SlPrice = (decimal)Math.Round((double)CurrentPrice * slCoef, PricePrecision);

            var buyOrder = Client.SpotApi.Trading.PlaceMarginOCOOrderAsync(
                TradePairSymbol, OrderSide.Buy, TpPrice, SlPrice, BaseBalance, SlPrice, TimeInForce.GoodTillCanceled, null, null, SideEffectType.AutoRepay, null, TradePairSymbol+"_oco_buy");
                
            buyOrder.Wait();

            if (buyOrder.Result.Success == false)
            {
                WriteToLog("Ошибка. " + buyOrder.Result.Error.Message);
            }
        }

        //продает TradePairSymbol на OrderSizeQuote долларов. возвращает количество проданных монет
        public void PlaceShortSellOrder()
        {
            decimal amount = (decimal)Math.Round((double)OrderSizeQuote / (double)CurrentPrice, basePrecision);

            var sellOrder = Client.SpotApi.Trading.PlaceMarginOrderAsync(TradePairSymbol, OrderSide.Sell,
                SpotOrderType.Market, amount, null, TradePairSymbol + "_sell_market", null, null, null, null, SideEffectType.MarginBuy);

            sellOrder.Wait();

            if (sellOrder.Result.Success == false)
            {
                WriteToLog("Ошибка. " + sellOrder.Result.Error.Message);
            }
        }

        //получает маржинальный доуступный баланс заданной валюты
        public decimal GetBalanceMargin(string currency)
        {
            decimal result = 0;
            try {
                var balances = Client.SpotApi.Account.GetMarginAccountInfoAsync();
                balances.Wait();
                result = (decimal)balances.Result.Data.Balances.First(x => x.Asset == currency).Available;
            }
            catch(System.NullReferenceException)
            {
                result = 0;
            }

            return result;
        }

        //получает маржинальный займный баланс
        public decimal GetBalanceMarginBorrowed(string currency)
        {
            var balances = Client.SpotApi.Account.GetMarginAccountInfoAsync();
            balances.Wait();

            if (balances.Result.Success == false)
            {
                WriteToLog("Ошибка. " + balances.Result.Error.Message);
                return 0;
            }
            else
                return Math.Round((decimal)balances.Result.Data.Balances.First(x => x.Asset == currency).Borrowed, basePrecision);
        }

        //шаг лонг торговли, покупает если надо и оставляет ордер на продажу
        public void TradeStepLong()
        {
            bool sos = GetLongSellOrderStatus();

            //получаем историю цен
            List<Kline> klines = null;
            while (klines == null)
                klines = GetLastKLines(RsiPeriod * 6);

            CurrentPrice = (decimal) klines[klines.Count-1].ClosePrice;

            //вычисляем массив rsi
            double[] rsi = CalculateRSISeries(klines);
            //предыдущее значение rsi
            double prevRsi = rsi[rsi.Length - 2];
            //текущее значение rsi
            CurrentRsi = rsi[rsi.Length - 1];

            QuoteBalance = GetBalanceSpot(TradePairQuote);
            BaseBalance = GetBalanceSpot(TradePairBase);

            //если нет ордера на продажу и rsi меньше порога и есть доллары на покупку, то покупаем и продаем
            if (sos == false && CurrentRsi <= RsiTreshold && QuoteBalance > OrderSizeQuote)
            {

                //размещаем ордер на продажу только если предыдущее значение было выше порога
                if (OnlyOneSell && prevRsi > RsiTreshold)
                    PlaceLongBuyOrder();
                else if (!OnlyOneSell)
                    PlaceLongBuyOrder();
                else
                {
                    WriteToLog("Ордер не размещен (защита от нескольких сделок подряд)");
                    return;
                }

                BaseBalance = GetBalanceSpot(TradePairBase);
                PlaceLongSellOrder();

                WriteToLog("Купили и разместили новый ордер. Цена takeProfit: "+TpPrice+".Цена stopLoss: "+ SlPrice);
            }
            else
            {
                WriteToLog((sos ? "Ордер на продажу уже выставлен" : "Ордер на продажу не выставлен"));
            }

        }

        //возвращает true если ордер на продажу всё еще размещен и не выполнен и не отменен
        public bool GetLongSellOrderStatus()
        {
            var sellOrder = Client.SpotApi.Trading.GetOcoOrderAsync(null, TradePairSymbol + "_oco_sell", null);
            sellOrder.Wait();

            if (sellOrder.Result.Data != null) {

                return (sellOrder.Result.Data.ListOrderStatus == ListOrderStatus.Executing);
            }
            else
                return false;
        }

        //размещает oco ордер на продажу
        public void PlaceLongSellOrder()
        {
            double tpCoef = (100 + PercentTakeProfit) / 100;
            double slCoef = (100 - PercentStopLoss) / 100;

            decimal price = CurrentPrice;
            TpPrice = (decimal)Math.Round((double)price * tpCoef, PricePrecision);
            SlPrice = (decimal)Math.Round((double)price * slCoef, PricePrecision);
            decimal amount = Math.Round(BaseBalance, basePrecision);


            var sellOrder = Client.SpotApi.Trading.PlaceOcoOrderAsync(TradePairSymbol, OrderSide.Sell, amount,
                TpPrice, SlPrice, SlPrice,
                TradePairSymbol + "_oco_sell", null, null, null,
                null, TimeInForce.GoodTillCanceled, null, null, null, null, null, null, null);
            sellOrder.Wait();

            if(sellOrder.Result.Success == false)
            {
                WriteToLog("Ошибка. " + sellOrder.Result.Error.Message);
            }
        }

        //получает баланс заданной валюты
        public decimal GetBalanceSpot(string currency)
        {
            var balances = Client.SpotApi.CommonSpotClient.GetBalancesAsync(null);
            balances.Wait();

            if (balances.Result.Success == false)
            {
                WriteToLog("Ошибка. " + balances.Result.Error.Message);
                return 0;
            }
            else
                return (decimal)balances.Result.Data.First(x => x.Asset == currency).Total;
        }

        //покупает TradePairSymbol на OrderSizeUsdt долларов
        public void PlaceLongBuyOrder()
        {
            decimal amount = (decimal)Math.Round((double)OrderSizeQuote / (double)CurrentPrice, basePrecision);

            var buyOrder = Client.SpotApi.Trading.PlaceOrderAsync(TradePairSymbol,
                OrderSide.Buy, SpotOrderType.Market,
                amount, null, TradePairSymbol + "_buy_market", null, null, null, null, null, null, null, null, null, null);
            
            buyOrder.Wait();

            if (buyOrder.Result.Success == false)
            {
                WriteToLog("Ошибка. " + buyOrder.Result.Error.Message);
            }
        }

        //возвращает последние amount свечей цен
        public List<Kline> GetLastKLines(int amount)
        {
            List<Kline> klines = new List<Kline>();

            TimeSpan klInterval = new TimeSpan(0, 1, 0);

            var task = Client.SpotApi.CommonSpotClient
                .GetKlinesAsync(TradePairSymbol, klInterval, null, null, amount);

            task.Wait();

            if (task.Result.Success)
                klines = task.Result.Data.ToList();
            else
                klines = null;

            return klines;
        }

        //вычисляет rsi для массива цен. возвращает массив значений rsi
        //для правльного вычисления rsi нужно RsiPeriod * 6 точек в klines
        //текущее значение rsi = последний элемент
        public double[] CalculateRSISeries(List<Kline> klines)
        {
            int dataSize = klines.Count;
            float[] data = new float[dataSize];
            for (int i = 0; i < dataSize; i++)
                data[i] = (float)klines[i].ClosePrice;


            int outBegIdx = 0;
            int outNBElement = 0;
            double[] output = new double[dataSize];
            Core.RetCode ret;
            ret = Core.Rsi(0, dataSize - 1, data, RsiPeriod, out outBegIdx, out outNBElement, output);

            //делаем нули в начале, а не в конце
            double[] outputFixed = new double[dataSize];
            for (int i = 0; i < dataSize - RsiPeriod; i++)
                outputFixed[i + RsiPeriod] = output[i];

            if (ret == Core.RetCode.Success)
                return outputFixed;
            else
                return null;
        }


    }
}
