using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace SimpleTradeBot
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

            string key = ini.GetValue("key", "api");
            string secret = ini.GetValue("secret", "api");

            foreach (string sec in sections)
            {
                if (sec == "api")
                    continue;

                TradeBot tb = new TradeBot();
                tb.SetApi(key, secret);
                tb.TradePairBase=ini.GetValue("TradePairBase", sec);
                tb.TradePairQuote = ini.GetValue("TradePairQuote", sec);
                tb.TradePairSymbol = ini.GetValue("TradePairSymbol", sec);
                tb.Parametr1 = int.Parse(ini.GetValue("Parametr1", sec));
                tb.Parametr2 = int.Parse(ini.GetValue("Parametr2", sec));
                tb.Parametr3 = int.Parse(ini.GetValue("Parametr3", sec));
                tb.OrderSizeQuote = decimal.Parse(ini.GetValue("OrderSizeQuote", sec));
                tb.PercentTakeProfit = double.Parse(ini.GetValue("PercentTakeProfit", sec), CultureInfo.InvariantCulture);
                tb.PercentStopLoss = double.Parse(ini.GetValue("PercentStopLoss", sec), CultureInfo.InvariantCulture);
                tb.PricePrecision = int.Parse(ini.GetValue("PricePrecision", sec));
                tb.BasePrecision = int.Parse(ini.GetValue("BasePrecision", sec));
                tb.QuotePrecision = int.Parse(ini.GetValue("QuotePrecision", sec));
                tb.OnlyOneSell = bool.Parse(ini.GetValue("OnlyOneSell", sec));
                tb.Direction = ini.GetValue("Direction", sec);
                tb.Indicator = ini.GetValue("Indicator", sec);

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
