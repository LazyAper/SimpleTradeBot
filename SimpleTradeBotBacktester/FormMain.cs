using Binance.Net.Objects.Models.Spot;
using CryptoExchange.Net.CommonObjects;
using Microsoft.EntityFrameworkCore;
using SimpleTradeBotBacktester.Data;
using System.Linq;

namespace SimpleTradeBotBacktester
{
    public partial class FormMain : Form
    {
        Backtester bt;

        public FormMain()
        {
            InitializeComponent();
            bt = new Backtester();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<BinanceSymbol> s = BinanceExchange.DownloadSpotPairs("USDT");

            bt.DownloadPairs();
            BindPairs();
        }


        private void BindPairs()
        {
            pairBindingSource.DataSource = bt.dbContext.Pairs.ToList();
            pairBindingSource.ResetBindings(false);
        }


        private void buttonCalcPair_Click_1(object sender, EventArgs e)
        {
            BacktesterPair bp = bt.Backtesters.First((x => ((Pair)pairBindingSource.Current).Symbol == x.pair.Symbol));
            bp.BacktestSettingsFind();
            BindPairs();
        }

        private void buttonShowSettings_Click_1(object sender, EventArgs e)
        {
            FormSettings fs = new FormSettings();
            
            fs.CurrentSettings = bt.dbContext.Settings.Where(
                (x) => x.PairCurrent == (Pair)pairBindingSource.Current).ToList();

            fs.ShowDialog();
        }
    }
}