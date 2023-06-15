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
        public int RsiPeriod { get; set; }
        public int RsiTreshold { get; set; }
        public double PercentTakeProfit { get; set; }
        public double PercentStopLoss { get; set; }
        public bool OnlyOneSell { get; set; }
        public DateTime Time { get; set; }
        public double WeekProfit { get; set; }
        public double DayProfit { get; set; }
        public Pair PairCurrent { get; set; }


    }
}
