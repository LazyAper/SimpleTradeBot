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
            string iniContent = "["+
                "]\r\nTradePairBase=\r\nTradePairQuote=\r\nTradePairSymbol="+
                set.PairCurrent.Symbol+ "\r\nRsiPeriod="+set.RsiPeriod+"\r\n"+
                "OrderSizeQuote=11\r\nRsiTreshold="+set.RsiTreshold+
                "\r\nPercentTakeProfit="+set.PercentTakeProfit+
                "\r\nPercentStopLoss=" + set.PercentStopLoss +
                "\r\nPricePrecision=\r\nBasePrecision=\r\nQuotePrecision=\r\n" +
                "OnlyOneSell="+set.OnlyOneSell+ "\r\nDirection=long";

            textBoxIni.Text = iniContent;
        }
    }
}
