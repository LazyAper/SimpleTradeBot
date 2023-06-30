using CryptoExchange.Net.CommonObjects;
using SimpleTradeBotBacktester.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTradeBotBacktester
{
    public class Trace
    {
        public Pair pair;
        public Setting set;
        public List<TraceTrade> Trades = new List<TraceTrade>();
        private double Capital = 100;
        private double Commision = 0.075;

        public Trace() { 
        }

        public void CalcTrades()
        {
            Trades.Clear();

            int winTrades = 0;
            int lossTrades = 0;

            double buyPrice = 0;
            bool openFlag = false;


            var weekKlines = new List<Kline>();
            var priceHistory = new List<Kline>();
            BinanceExchange.DownloadKlines(pair.Symbol, out weekKlines, out priceHistory);

            double[] rsiSeries = BacktesterPair.CalcRSI(priceHistory, set.Parametr1);


            for (int i = 0; i < priceHistory.Count; i++)
            {
                double TpPrice = buyPrice * (set.PercentTakeProfit + 100) / 100; //1.015*buyPrice
                double slPrice = buyPrice * (100 - set.PercentStopLoss) / 100; //0.995*buyPrice


                bool buyCond = (rsiSeries[i] > 0) && (rsiSeries[i] <= set.Parametr2);
                if (set.OnlyOneSell)
                    buyCond = buyCond && (rsiSeries[i - 1] > set.Parametr2);

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

                TraceTrade trade = new TraceTrade();

                if (buyCond && !openFlag)
                {
                    buyPrice = (double)priceHistory[i].ClosePrice;
                    openFlag = true;

                    trade.Time = priceHistory[i].OpenTime;
                    trade.Price = buyPrice;
                    trade.Direction = "buy";
                    trade.Profit = -1;
                    trade.RSI = rsiSeries[i];


                    Trades.Add(trade);
                }

                List<double> prices = new List<double>();
                prices.Add((double)priceHistory[i].OpenPrice);
                prices.Add((double)priceHistory[i].LowPrice);
                prices.Add((double)priceHistory[i].HighPrice);
                prices.Add((double)priceHistory[i].ClosePrice);
                prices.Sort();

                trade.Time = priceHistory[i].OpenTime;
                trade.RSI = rsiSeries[i];

                if (sellCondSl)
                {
                    lossTrades++;
                    openFlag = false;


                    trade.Price = prices[0];
                    trade.Direction = "sell stop loss";
                    trade.Profit = (Capital * winTrades * (set.PercentTakeProfit / 100.0)) -
                    (Capital * lossTrades * (set.PercentStopLoss / 100.0)) -
                    (2 * Commision / 100 * Capital * (winTrades + lossTrades));
                   Trades.Add(trade);

                }
                else if (sellCondTp)
                {
                    winTrades++;
                    openFlag = false;

                    trade.Price = prices[3];
                    trade.Direction = "sell take profit";
                    trade.Profit = (Capital * winTrades * (set.PercentTakeProfit / 100.0)) -
                        (Capital * lossTrades * (set.PercentStopLoss / 100.0)) -
                        (2 * Commision / 100 * Capital * (winTrades + lossTrades));
                    Trades.Add(trade);
                }

            }
        }
    }
}
