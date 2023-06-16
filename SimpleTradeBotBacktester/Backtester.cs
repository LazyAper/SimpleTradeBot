using Binance.Net.Objects.Models.Spot;
using Microsoft.EntityFrameworkCore;
using SimpleTradeBotBacktester.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTradeBotBacktester
{
    class Backtester
    {
        public DataBaseContext dbContext = new DataBaseContext();
        public List<BacktesterPair> Backtesters = new List<BacktesterPair>();

        public Backtester()
        {

        }

        /// <summary>
        /// загружает с базы данных все пары и создает для них объекты BacktesterPair
        /// и добавляет в Backtesters и в базу данных. Возвращает количество новых пар
        /// </summary>
        public int DownloadPairs()
        {
            List<string> quotes = new List<string>();
            quotes.Add("USDT");
            quotes.Add("BUSD");
            quotes.Add("TUSD");

            List<BinanceSymbol> lbs = BinanceExchange.DownloadSpotPairs(quotes);
            int newPairsCount = 0;

            foreach(BinanceSymbol bs in lbs)
            {
                Pair p = dbContext.Pairs.FirstOrDefault((x) => x.Symbol == bs.Name);
                if(p == null)
                {
                    p = new Pair();
                    p.Symbol = bs.Name;
                    dbContext.Add(p);
                    dbContext.SaveChanges();
                    newPairsCount++;
                }


                var btp = new BacktesterPair(this);
                btp.pair = p;

                Backtesters.Add(btp);
            }

            return newPairsCount;
        }
    }
}
