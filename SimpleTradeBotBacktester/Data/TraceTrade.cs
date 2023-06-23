using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTradeBotBacktester.Data
{
    public class TraceTrade
    {
        public int TradeId {get; set;}
        public DateTime Time { get; set;}
        public double Price { get; set;}
        
        //buy, sell take profit, sell stop loss
        public string Direction { get; set;}
        public double Profit { get; set;}

        public double RSI { get; set;}


    }
}
