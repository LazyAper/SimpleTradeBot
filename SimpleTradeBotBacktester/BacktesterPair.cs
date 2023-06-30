using Binance.Net.Enums;
using CryptoExchange.Net.CommonObjects;
using Microsoft.VisualBasic.ApplicationServices;
using SimpleTradeBotBacktester.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTec.TA.Library;

namespace SimpleTradeBotBacktester
{
    class BacktesterPair
    {
        public double Capital = 100;
        double Commision = 0.075;
        public Pair pair;
        Backtester backTester;

        string Indicator = "MACD";

        public List<Setting> allSettings { get; set; } = new List<Setting>();

        private List<Kline> weekKlines;
        private List<Kline> dayKlines;


        public BacktesterPair(Backtester bt)
        {
            backTester = bt;
        }
        /// <summary>
        /// моделирует торговлю и считатает прибыль и количество сделок в объект set
        /// period = day или week
        /// </summary>
        private void Backtest(List<Kline> priceHistory, Setting set, String period)
        {
            int winTrades = 0;
            int lossTrades = 0;

            double buyPrice = 0;
            bool openFlag = false;

            double[] rsiSeries = CalcRSI(priceHistory, set.RsiPeriod);
            double[] macdHist = CalculateMACDHist(priceHistory);

            for (int i = 0; i < priceHistory.Count; i++)
            {
                double TpPrice = buyPrice * (set.PercentTakeProfit + 100) / 100; //1.015*buyPrice
                double slPrice = buyPrice * (100 - set.PercentStopLoss) / 100; //0.995*buyPrice

                bool buyCond = false;
                if (Indicator == "RSI")
                {
                    buyCond = (rsiSeries[i] > 0) && (rsiSeries[i] <= set.RsiTreshold);
                    if (set.OnlyOneSell)
                        buyCond = buyCond && (rsiSeries[i - 1] > set.RsiTreshold);
                }
                else if (Indicator == "MACD")
                {
                    buyCond = (i>0) && (macdHist[i - 1] < 0) && (macdHist[i] >= 0);
                }

                bool sellCondSl = (buyPrice != 0) && openFlag & (
                    (double)priceHistory[i].OpenPrice <= slPrice ||
                    (double)priceHistory[i].LowPrice <= slPrice ||
                    (double)priceHistory[i].HighPrice <= slPrice ||
                    (double)priceHistory[i].ClosePrice <= slPrice);

                bool sellCondTp = (buyPrice != 0) && openFlag & (
                     (double)priceHistory[i].OpenPrice >= TpPrice ||
                     (double)priceHistory[i].LowPrice >= TpPrice ||
                     (double)priceHistory[i].HighPrice >= TpPrice ||
                     (double)priceHistory[i].ClosePrice >= TpPrice);

                if (buyCond && !openFlag)
                {
                    buyPrice = (double)priceHistory[i].ClosePrice;
                    openFlag = true;
                }

                if (sellCondSl)
                {
                    lossTrades++;
                    openFlag = false;
                }
                else if (sellCondTp)
                {
                    winTrades++;
                    openFlag = false;
                }

            }

            double profit = (Capital * winTrades * (set.PercentTakeProfit / 100.0)) -
                    (Capital * lossTrades * (set.PercentStopLoss / 100.0)) -
                    (2 * Commision / 100 * Capital * (winTrades + lossTrades));

            if (period == "day")
            {
                set.DayTrades = (winTrades + lossTrades);
                set.DayProfit = profit;
            }
            else if (period == "week")
            {
                set.WeekTrades = (winTrades + lossTrades);
                set.WeekProfit = profit;
            }
        }

        /// <summary>
        /// перебор настроек и вызов для них метода Backtest
        /// </summary>
        public void BacktestSettingsFind()
        {
            allSettings.Clear();
            weekKlines = new List<Kline>();
            dayKlines = new List<Kline>();
            BinanceExchange.DownloadKlines(pair.Symbol, out weekKlines, out dayKlines);

            if (Indicator == "RSI")
            {

                for (int oos = 0; oos <= 1; oos++)
                    for (double psl = 0.5; psl <= 2.0; psl += 0.25)
                        for (double ptp = 0.5; ptp <= 2.0; ptp += 0.25)
                            for (int rsip = 3; rsip <= 19; rsip += 2)
                                for (int rsit = 10; rsit <= 50; rsit += 5)
                                {
                                    Setting setting = new Setting();
                                    setting.PairCurrent = pair;

                                    if (oos == 0)
                                        setting.OnlyOneSell = false;
                                    else if (oos == 1)
                                        setting.OnlyOneSell = true;

                                    setting.PercentStopLoss = psl;
                                    setting.PercentTakeProfit = ptp;
                                    setting.RsiPeriod = rsip;
                                    setting.RsiTreshold = rsit;

                                    allSettings.Add(setting);
                                    //моделирование дня и недели
                                    Backtest(dayKlines, setting, "day");
                                    Backtest(weekKlines, setting, "week");
                                }
            }
            else if (Indicator == "MACD")
            {

                for (double psl = 0.5; psl <= 2.0; psl += 0.25)
                    for (double ptp = 0.5; ptp <= 2.0; ptp += 0.25)
                    {
                        Setting setting = new Setting();
                        setting.PairCurrent = pair;
                        setting.OnlyOneSell = false;
                      
                        setting.PercentStopLoss = psl;
                        setting.PercentTakeProfit = ptp;

                        allSettings.Add(setting);
                        //моделирование дня и недели
                        Backtest(dayKlines, setting, "day");
                        Backtest(weekKlines, setting, "week");
                    }
            }

            FindBestProfits();
        }

        /// <summary>
        /// с помощью сортировки ищет BestWeekProfit и BestWeekProfit для текущей пары
        /// и сохраняет их в базу данных
        /// </summary>
        private void FindBestProfits()
        {

            //удаляем все прошлые настройки пары из бд

            var settingsToDelete = backTester.dbContext.Settings.Where(x => x.PairCurrent == pair).ToList();


            foreach (Setting setting in settingsToDelete)
                backTester.dbContext.Settings.Remove(setting);

            backTester.dbContext.SaveChanges();

            //получаем только прибыльные настройки, отсортированные по прибыли за день
            var bestSettings = allSettings.Where((x) => x.WeekProfit > 0 && x.DayProfit > 0).
                OrderByDescending((x) => (x.WeekProfit / 7 + x.DayProfit) / 2).Take(100).ToList();

            //очищаем из памяти настройки для экономии ram
            allSettings.Clear();

            foreach (Setting setting in bestSettings)
                backTester.dbContext.Settings.Add(setting);
            backTester.dbContext.SaveChanges();

            if (bestSettings.Count > 0)
            {
                pair.BestWeekProfit = bestSettings[0].WeekProfit;
                pair.BestDayProfit = bestSettings[0].DayProfit;
            }
            else
            {
                pair.BestWeekProfit = 0;
                pair.BestDayProfit = 0;
            }

            pair.LastTestTime = DateTime.Now;
            backTester.dbContext.Update(pair);
            backTester.dbContext.SaveChanges();
        }


        /// <summary>
        /// вычсиление rsi для PriceHistory
        /// </summary>
        /// <returns>массив значений rsi для каждой точки</returns>
        public static double[] CalcRSI(List<Kline> klines, int period)
        {
            int dataSize = klines.Count;
            float[] data = new float[dataSize];
            for (int i = 0; i < dataSize; i++)
                data[i] = (float)klines[i].ClosePrice;


            int outBegIdx = 0;
            int outNBElement = 0;
            double[] output = new double[dataSize];
            Core.RetCode ret;
            ret = Core.Rsi(0, dataSize - 1, data, period, out outBegIdx, out outNBElement, output);

            //делаем нули в начале, а не в конце
            double[] outputFixed = new double[dataSize];
            for (int i = 0; i < dataSize - period; i++)
                outputFixed[i + period] = output[i];

            if (ret == Core.RetCode.Success)
                return outputFixed;
            else
                return null;
        }

        public double[] CalculateMACDHist(List<Kline> klines)
        {
            int dataSize = klines.Count;
            double[] data = new double[dataSize];
            for (int i = 0; i < dataSize; i++)
                data[i] = (double)klines[i].ClosePrice;

            int outBegIdx = 0;
            int outNBElement = 0;
            double[] outMACD = new double[dataSize];
            double[] outMACDSignal = new double[dataSize];
            double[] outMACDHist = new double[dataSize];
            Core.RetCode ret;
            ret = Core.Macd(0, dataSize - 1, data, 12, 26, 9,
                out outBegIdx, out outNBElement, outMACD, outMACDSignal, outMACDHist);

            //делаем нули в начале, а не в конце
            double[] outputFixed = new double[dataSize];
            for (int i = 0; i < outNBElement; i++)
                outputFixed[i + (dataSize - outNBElement)] = outMACDHist[i];

            if (ret == Core.RetCode.Success)
                return outputFixed;
            else
                return null;
        }
    }
}
