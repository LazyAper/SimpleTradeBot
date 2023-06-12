using SimpleTradeBotAsp.Jobs;
using static System.Collections.Specialized.BitVector32;

namespace SimpleTradeBotAsp
{
    class TradeBots
    {
        private string iniFile = "SimpleTradeBot.ini";
        List<TradeBot> tbs = new List<TradeBot>();

        public TradeBots()
        {
            ReadTradeBotsFromIni();
        }

        //читает всех ботов из ини файла в коллекцию tbs
        private void ReadTradeBotsFromIni()
        {
            Ini ini = new Ini(iniFile);

            string[] sections = ini.GetSections();

            foreach (var sec in sections)
            {
                TradeBot tb = new TradeBot();
                tb.TradePairBase=ini.GetValue("TradePairBase", sec);
                tb.TradePairQuote = ini.GetValue("TradePairQuote", sec);
                tb.TradePairSymbol = ini.GetValue("TradePairSymbol", sec);
                tb.RsiPeriod = int.Parse(ini.GetValue("RsiPeriod", sec));
                tb.OrderSizeQuote = decimal.Parse(ini.GetValue("OrderSizeQuote", sec));
                tb.RsiTreshold = int.Parse(ini.GetValue("RsiTreshold", sec));
                tb.PercentTakeProfit = double.Parse(ini.GetValue("PercentTakeProfit", sec));
                tb.PercentStopLoss = double.Parse(ini.GetValue("PercentStopLoss", sec));
                tb.PricePrecision = int.Parse(ini.GetValue("PricePrecision", sec));
                tb.basePrecision = int.Parse(ini.GetValue("basePrecision", sec));
                tb.quotePrecision = int.Parse(ini.GetValue("quotePrecision", sec));
                tb.OnlyOneSell = bool.Parse(ini.GetValue("OnlyOneSell", sec));
                tb.direction = ini.GetValue("direction", sec);

                tbs.Add(tb);
            }
        }

        public void RunAllBotsStep()
        {
            foreach(TradeBot tb in tbs)
            {
                tb.TradeStep();
            }
        }

    }
}
