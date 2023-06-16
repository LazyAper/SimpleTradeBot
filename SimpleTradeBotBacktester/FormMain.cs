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
        Backtester bt;

        public FormMain()
        {
            InitializeComponent();
            bt = new Backtester();
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
            for (int i = 0; i < bt.Backtesters.Count; i++)
            {
                if (checkBoxTodayNotCalc.Checked &&
                    bt.Backtesters[i].pair.LastTestTime <= DateTime.Now.AddHours(-1*(double)numericUpDownHours.Value))
                {
                    toolStripStatusLabel1.Text = "Расчет пары " + bt.Backtesters[i].pair.Symbol;
                    bt.Backtesters[i].BacktestSettingsFind();
                }
                else if (!checkBoxTodayNotCalc.Checked)
                {
                    toolStripStatusLabel1.Text = "Расчет пары " + bt.Backtesters[i].pair.Symbol;
                    bt.Backtesters[i].BacktestSettingsFind();
                }

                percentFinished = (int)((double)(i + 1) / bt.Backtesters.Count * 100);
                backgroundWorker1.ReportProgress(percentFinished);
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
    }
}