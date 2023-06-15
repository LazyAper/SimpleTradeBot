using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTradeBotBacktester.Data
{
    public class Pair
    {
        public int PairId { get; set; }
        public string Symbol { get; set; }

        public List<Setting> Settings { get; set; } = new List<Setting>();

        public double BestWeekProfit { get; set; }
        public double BestDayProfit { get; set; }
    }
}
