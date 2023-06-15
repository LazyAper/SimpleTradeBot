using Binance.Net.Objects.Models.Spot;
using CryptoExchange.Net.CommonObjects;
using Microsoft.EntityFrameworkCore;

namespace SimpleTradeBotBacktester
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // List<BinanceSymbol> s = BinanceExchange.DownloadSpotPairs("USDT");
            /*
            List<Kline> weeklines = new List<Kline>();
            List<Kline> daylines = new List<Kline>();

            BinanceExchange.DownloadKlines("AMBUSDT", out weeklines, out daylines);
            */
            Backtester bt = new Backtester();
            bt.DownloadPairs();

            //dataGridViewPairs. bt.dbContext.Pairs;
        }
    }
}