using CryptoExchange.Net.CommonObjects;
using SimpleTradeBotBacktester.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTradeBotBacktester
{
    class BacktesterPair
    {
        public decimal OrderSizeQuote = 100;
        public List<Kline> PriceHistory; 

        public Pair pair;

        public List<Setting> allSettings { get; set; } = new List<Setting>();

        /// <summary>
        /// Вычисление DayProfit и WeekProfit для заданных настроек
        /// </summary>
        public void Backtest(Setting set) {

        }

        /// <summary>
        /// перебор настроек и вызов для них метода Backtest
        /// </summary>
        public void BacktestSettingsFind()
        {

        }

        /// <summary>
        /// с помощью сортировки ищет BestWeekProfit и BestWeekProfit для текущей пары
        /// и сохраняет их в базу данных
        /// </summary>
        public void FindBestProfits()
        {

        }


        /// <summary>
        /// загрузка истории цен в PriceHistory с биржи для заданной пары за последние 7 дней
        /// </summary>
        public void DownloadKlines()
        {

        }

        /// <summary>
        /// вычсиление rsi для PriceHistory
        /// </summary>
        /// <returns>массив значений rsi для каждой точки</returns>
        public double[] CalcRSI()
        {
            return new double[1];
        }
    }
}
