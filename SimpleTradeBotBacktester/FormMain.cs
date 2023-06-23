using Binance.Net.Objects.Models.Spot;
using CryptoExchange.Net.CommonObjects;
using Microsoft.EntityFrameworkCore;
using SimpleTradeBotBacktester.Data;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace SimpleTradeBotBacktester
{
    public partial class FormMain : Form
    {
        private Backtester bt;
        private Backtester btFavourite;
        private bool favouriteOpen = false;

        public FormMain()
        {
            InitializeComponent();
            bt = new Backtester();
            btFavourite = new Backtester();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
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
            MessageBox.Show("Расчет пары закончен.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonShowSettings_Click_1(object sender, EventArgs e)
        {
            FormSettings fs = new FormSettings();

            fs.CurrentSettings = bt.dbContext.Settings.Where(
                (x) => x.PairCurrent == (Pair)pairBindingSource.Current).ToList();

            fs.ShowDialog();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            pairBindingSource.DataSource = bt.dbContext.Pairs.OrderByDescending(x => (x.BestDayProfit + x.BestWeekProfit / 7) / 2).ToList();
        }

        private void buttonCalcAll_Click(object sender, EventArgs e)
        {
            buttonCalcPair.Enabled = false;
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                buttonCalcAll.Text = "Остановить расчет";
            }
            else
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int percentFinished = 0;

            if (!favouriteOpen)
            {
                for (int i = 0; i < bt.Backtesters.Count; i++)
                {
                    if (!checkBoxTodayNotCalc.Checked || checkBoxTodayNotCalc.Checked &&
                        bt.Backtesters[i].pair.LastTestTime <= DateTime.Now.AddHours(-1 * (double)numericUpDownHours.Value))
                    {
                        toolStripStatusLabel1.Text = "Расчет пары " + bt.Backtesters[i].pair.Symbol;

                        bt.Backtesters[i].BacktestSettingsFind();

                        percentFinished = (int)((double)(i + 1) / bt.Backtesters.Count * 100);
                        backgroundWorker1.ReportProgress(percentFinished);
                    }
                }
            }
            else if (favouriteOpen)
            {
                for (int i = 0; i < btFavourite.Backtesters.Count; i++)
                {
                    if (!checkBoxTodayNotCalc.Checked || checkBoxTodayNotCalc.Checked &&
                        btFavourite.Backtesters[i].pair.LastTestTime <= DateTime.Now.AddHours(-1 * (double)numericUpDownHours.Value))
                    {
                        toolStripStatusLabel1.Text = "Расчет пары " + btFavourite.Backtesters[i].pair.Symbol;
                        btFavourite.Backtesters[i].BacktestSettingsFind();
                    }

                    percentFinished = (int)((double)(i + 1) / btFavourite.Backtesters.Count * 100);
                    backgroundWorker1.ReportProgress(percentFinished);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Расчет всех пар закончен.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonCalcAll.Text = "Рассчитать все";
            toolStripStatusLabel1.Text = "Расчет пар окончен";
            buttonCalcPair.Enabled = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            pairBindingSource.DataSource = bt.dbContext.Pairs.Where((x) => x.Symbol.Contains(textBoxSearch.Text.ToUpper())).ToList();
        }

        private void buttonAddFavourites_Click(object sender, EventArgs e)
        {
            ((Pair)pairBindingSource.Current).IsFavourite = !((Pair)pairBindingSource.Current).IsFavourite;
            bt.dbContext.SaveChanges();
            pairBindingSource.ResetBindings(false);
        }

        private void buttonFavourites_Click(object sender, EventArgs e)
        {
            favouriteOpen = !favouriteOpen;

            if (favouriteOpen)
            {
                btFavourite = new Backtester();
                foreach (BacktesterPair bp in bt.Backtesters)
                    if (bp.pair.IsFavourite)
                        btFavourite.Backtesters.Add(bp);

                pairBindingSource.DataSource = bt.dbContext.Pairs.Where((x) => x.IsFavourite).ToList();
                pairBindingSource.ResetBindings(false);
            }
            else
            {
                BindPairs();
            }
        }
    }
}