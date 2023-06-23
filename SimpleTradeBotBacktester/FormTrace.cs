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
    public partial class FormTrace : Form
    {

        public Trace trace = new Trace();


        public FormTrace()
        {
            InitializeComponent();
        }

        private void FormTrace_Load(object sender, EventArgs e)
        {
            trace.CalcTrades();

            traceTradeBindingSource.DataSource = trace.Trades;

            numericUpDownRSIPeriod.Value = trace.set.RsiPeriod;
            numericUpDownRSITreshold.Value = trace.set.RsiTreshold;
            numericUpDownPercentTP.Value = (decimal)trace.set.PercentTakeProfit;
            numericUpDownPercentSL.Value = (decimal)trace.set.PercentStopLoss;
            checkBoxOnlyOneSell.Checked = trace.set.OnlyOneSell;

        }

        private void buttonSetSettings_Click(object sender, EventArgs e)
        {
            trace.set.RsiPeriod = (int)numericUpDownRSIPeriod.Value;
            trace.set.RsiTreshold = (int)numericUpDownRSITreshold.Value;
            trace.set.PercentTakeProfit = (double)numericUpDownPercentTP.Value;
            trace.set.PercentStopLoss=(double)numericUpDownPercentSL.Value;
            trace.set.OnlyOneSell = checkBoxOnlyOneSell.Checked;

            trace.CalcTrades();

            traceTradeBindingSource.DataSource = trace.Trades;
        }
    }
}
