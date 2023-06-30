using Binance.Net.Objects.Models.Spot;
using SimpleTradeBotBacktester.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTradeBotBacktester
{
    public partial class FormIni : Form
    {

        public Setting set;

        public FormIni()
        {
            InitializeComponent();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxIni.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormIni_Load(object sender, EventArgs e)
        {
            BinanceSymbol bs = BinanceExchange.DownloadPairInfo(set.PairCurrent.Symbol);


            string iniContent = "["+
                "]\r\nTradePairBase="+bs.BaseAsset+
                "\r\nTradePairQuote="+bs.QuoteAsset+
                "\r\nTradePairSymbol=" +
                set.PairCurrent.Symbol+
                "\r\nParametr1="+set.Parametr1+
                "\r\nParametr2=" + set.Parametr2+
                "\r\nParametr3=9"+
                "\r\nOrderSizeQuote=11"+
                "\r\nPercentTakeProfit=" + set.PercentTakeProfit.ToString().Replace(',', '.')+
                "\r\nPercentStopLoss=" + set.PercentStopLoss.ToString().Replace(',', '.') +
                "\r\nPricePrecision=\r\nBasePrecision=\r\nQuotePrecision=\r\n" +
                "OnlyOneSell="+set.OnlyOneSell+ "\r\nDirection=long\r\nIndicator=MACD";

            textBoxIni.Text = iniContent;
        }
    }
}
