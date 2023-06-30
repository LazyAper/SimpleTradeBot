using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTradeBotBacktester.Data
{
    public class Setting
    {
        public int SettingId { get; set; }
        public int Parametr1 { get; set; }
        public int Parametr2 { get; set; }
        public int Parametr3 { get; set; }
        public double PercentTakeProfit { get; set; }
        public double PercentStopLoss { get; set; }
        public bool OnlyOneSell { get; set; }
        public double WeekProfit { get; set; }
        public double DayProfit { get; set; }
        public double DayTrades { get; set; }
        public double WeekTrades { get; set; }
        public Pair PairCurrent { get; set; }


    }
}
