using Binance.Net.Clients;
using Binance.Net.Enums;
using CryptoExchange.Net.CommonObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using TicTacTec.TA.Library;

namespace SimpleTradeBot
{
    class TradeBot {
        public string TradePairBase = "AST";
        public string TradePairQuote = "USDT";
        public string TradePairSymbol = "ASTUSDT";
        public int RsiPeriod = 7;
        public decimal OrderSizeQuote = 11;
        public int RsiTreshold = 30;
        public double PercentTakeProfit = 1.5;
        public double PercentStopLoss = 0.5;
        public BinanceClient Client;
        public int PricePrecision = 4;
        public int quotePrecision = 0;

        public TradeBot()
        {
            Client = new BinanceClient();
            Client.SetApiCredentials(new Binance.Net.Objects.BinanceApiCredentials(
                "p39EYe4QxRZS2dXgSL73xCspn88TCQNLQd93ZUKE7rkCuyd2jADi1AD4KntKApv3",
                "tudhsqIz826OAOuaD1dx0ER1cGnrDNzPeKq2pQYIIlVirbbLPipcHrLeZolhTmpN"));
        }

        private void WriteToLog(string text)
        {
            Console.WriteLine(text);
            File.AppendAllText("SimpleTradeBot.txt", text + Environment.NewLine);
        }

        //шаг торговли, покупает если надо и оставляет ордер на продажу
        public void TradeStep()
        {
            bool sos = GetSellOrderStatus();
            double cRsi = GetCurrentRSIValue();
            decimal quoteBlance = GetBalance(TradePairQuote);
            DateTime dt = DateTime.Now;

            //если нет ордера на продажу и rsi меньше порога и есть доллары на покупку, то покупаем и продаем
            if (sos == false && cRsi <= RsiTreshold && quoteBlance > OrderSizeQuote) {
                PlaceBuyOrder();
                PlaceSellOrder();

                WriteToLog(dt.ToString() +
                    (" Купили и разместили новый ордер. ") + "RSI =" + cRsi + ". Баланс=" + quoteBlance);
            }
            else
            {
                WriteToLog(dt.ToString()+
                    (sos ? " Ордер на продажу уже выставлен. " : " Ордер на продажу не выставлен. ") + "RSI ="+cRsi+". Баланс="+quoteBlance);
            }

        }

        //возвращает true если ордер на продажу всё еще размещен и не выполнен и не отменен
        public bool GetSellOrderStatus()
        {
            var sellOrder = Client.SpotApi.Trading.GetOcoOrderAsync(null, TradePairSymbol + "_oco_sell", null);
            sellOrder.Wait();

            if (sellOrder.Result.Data != null)
                return (sellOrder.Result.Data.ListOrderStatus == ListOrderStatus.Executing);
            else
                return false;
        }

        //размещает oco ордер на продажу
        public void PlaceSellOrder()
        {
            double tpCoef = (100 + PercentTakeProfit) / 100;
            double slCoef = (100 - PercentStopLoss) / 100;

            List<Kline> priceList = GetLastKLines(1);
            decimal price = (decimal)priceList[0].ClosePrice;
            decimal tpPrice = (decimal)Math.Round((double)price * tpCoef, PricePrecision);
            decimal slPrice = (decimal)Math.Round((double)price * slCoef, PricePrecision);
            decimal amount = GetBalance(TradePairBase);


            var sellOrder = Client.SpotApi.Trading.PlaceOcoOrderAsync(TradePairSymbol, OrderSide.Sell, amount,
                tpPrice, slPrice, slPrice,
                TradePairSymbol+"_oco_sell", null,null, null,
                null, TimeInForce.GoodTillCanceled, null, null, null, null, null, null, null);
            sellOrder.Wait();
        }

        //получает баланс заданной валюты
        public decimal GetBalance(string currency)
        {
            var balances = Client.SpotApi.CommonSpotClient.GetBalancesAsync(null);
            balances.Wait();

            return (decimal)balances.Result.Data.First(x => x.Asset == currency).Total;
        }

        //покупает TradePairSymbol на OrderSizeUsdt долларов
        public void PlaceBuyOrder()
        {
            var buyOrder = Client.SpotApi.Trading.PlaceOrderAsync(TradePairSymbol,
                OrderSide.Buy, SpotOrderType.Market,
                null, OrderSizeQuote, TradePairSymbol+"_buy_market", null, null, null, null, null, null, null, null, null, null);
            buyOrder.Wait();
        }

        //возвращает текущее значение rsi
        public double GetCurrentRSIValue()
        {
            var klines = GetLastKLines(RsiPeriod * 6);
            double[] rsi = CalculateRSISeries(klines);

            return rsi[rsi.Length-1];
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
