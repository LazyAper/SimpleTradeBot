using CryptoExchange.Net.CommonObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTradeBot
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            TradeBot tb = new TradeBot();
            List<Kline> klines = tb.GetLastKLines(100);
            double[] macd = tb.CalculateMACDHist(klines);

            for (int i = 0; i < macd.Length; i++)
                chart1.Series[0].Points.AddXY(klines[i].OpenTime.Hour*100+klines[i].OpenTime.Minute, (double)macd[i]);
        }
    }
}
