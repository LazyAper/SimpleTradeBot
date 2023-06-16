namespace SimpleTradeBotBacktester
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewPairs = new DataGridView();
            pairIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            symbolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bestWeekProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bestDayProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastTestTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pairBindingSource = new BindingSource(components);
            buttonCalcPair = new Button();
            buttonSort = new Button();
            buttonShowSettings = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonCalcAll = new Button();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            checkBoxTodayNotCalc = new CheckBox();
            numericUpDownHours = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPairs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pairBindingSource).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPairs
            // 
            dataGridViewPairs.AllowUserToAddRows = false;
            dataGridViewPairs.AllowUserToDeleteRows = false;
            dataGridViewPairs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPairs.AutoGenerateColumns = false;
            dataGridViewPairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPairs.Columns.AddRange(new DataGridViewColumn[] { pairIdDataGridViewTextBoxColumn, symbolDataGridViewTextBoxColumn, bestWeekProfitDataGridViewTextBoxColumn, bestDayProfitDataGridViewTextBoxColumn, lastTestTimeDataGridViewTextBoxColumn });
            dataGridViewPairs.DataSource = pairBindingSource;
            dataGridViewPairs.Location = new Point(12, 12);
            dataGridViewPairs.Name = "dataGridViewPairs";
            dataGridViewPairs.ReadOnly = true;
            dataGridViewPairs.RowHeadersWidth = 51;
            dataGridViewPairs.RowTemplate.Height = 29;
            dataGridViewPairs.Size = new Size(1010, 414);
            dataGridViewPairs.TabIndex = 0;
            // 
            // pairIdDataGridViewTextBoxColumn
            // 
            pairIdDataGridViewTextBoxColumn.DataPropertyName = "PairId";
            pairIdDataGridViewTextBoxColumn.HeaderText = "PairId";
            pairIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            pairIdDataGridViewTextBoxColumn.Name = "pairIdDataGridViewTextBoxColumn";
            pairIdDataGridViewTextBoxColumn.ReadOnly = true;
            pairIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            symbolDataGridViewTextBoxColumn.MinimumWidth = 6;
            symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            symbolDataGridViewTextBoxColumn.ReadOnly = true;
            symbolDataGridViewTextBoxColumn.Width = 125;
            // 
            // bestWeekProfitDataGridViewTextBoxColumn
            // 
            bestWeekProfitDataGridViewTextBoxColumn.DataPropertyName = "BestWeekProfit";
            bestWeekProfitDataGridViewTextBoxColumn.HeaderText = "BestWeekProfit";
            bestWeekProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            bestWeekProfitDataGridViewTextBoxColumn.Name = "bestWeekProfitDataGridViewTextBoxColumn";
            bestWeekProfitDataGridViewTextBoxColumn.ReadOnly = true;
            bestWeekProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // bestDayProfitDataGridViewTextBoxColumn
            // 
            bestDayProfitDataGridViewTextBoxColumn.DataPropertyName = "BestDayProfit";
            bestDayProfitDataGridViewTextBoxColumn.HeaderText = "BestDayProfit";
            bestDayProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            bestDayProfitDataGridViewTextBoxColumn.Name = "bestDayProfitDataGridViewTextBoxColumn";
            bestDayProfitDataGridViewTextBoxColumn.ReadOnly = true;
            bestDayProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastTestTimeDataGridViewTextBoxColumn
            // 
            lastTestTimeDataGridViewTextBoxColumn.DataPropertyName = "LastTestTime";
            lastTestTimeDataGridViewTextBoxColumn.HeaderText = "LastTestTime";
            lastTestTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastTestTimeDataGridViewTextBoxColumn.Name = "lastTestTimeDataGridViewTextBoxColumn";
            lastTestTimeDataGridViewTextBoxColumn.ReadOnly = true;
            lastTestTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // pairBindingSource
            // 
            pairBindingSource.DataSource = typeof(Data.Pair);
            // 
            // buttonCalcPair
            // 
            buttonCalcPair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCalcPair.Location = new Point(12, 444);
            buttonCalcPair.Name = "buttonCalcPair";
            buttonCalcPair.Size = new Size(202, 29);
            buttonCalcPair.TabIndex = 1;
            buttonCalcPair.Text = "Расссчитать пару";
            buttonCalcPair.UseVisualStyleBackColor = true;
            buttonCalcPair.Click += buttonCalcPair_Click_1;
            // 
            // buttonSort
            // 
            buttonSort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSort.Location = new Point(12, 479);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(202, 29);
            buttonSort.TabIndex = 2;
            buttonSort.Text = "Отсортировать таблицу";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonShowSettings
            // 
            buttonShowSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonShowSettings.Location = new Point(825, 479);
            buttonShowSettings.Name = "buttonShowSettings";
            buttonShowSettings.Size = new Size(165, 29);
            buttonShowSettings.TabIndex = 3;
            buttonShowSettings.Text = "Показать настройки";
            buttonShowSettings.UseVisualStyleBackColor = true;
            buttonShowSettings.Click += buttonShowSettings_Click_1;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // buttonCalcAll
            // 
            buttonCalcAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCalcAll.Location = new Point(232, 479);
            buttonCalcAll.Name = "buttonCalcAll";
            buttonCalcAll.Size = new Size(193, 29);
            buttonCalcAll.TabIndex = 4;
            buttonCalcAll.Text = "Рассчитать все";
            buttonCalcAll.UseVisualStyleBackColor = true;
            buttonCalcAll.Click += buttonCalcAll_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 511);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1034, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 18);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(200, 20);
            toolStripStatusLabel1.Text = "Расчет пар не выполняется";
            // 
            // checkBoxTodayNotCalc
            // 
            checkBoxTodayNotCalc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxTodayNotCalc.AutoSize = true;
            checkBoxTodayNotCalc.Checked = true;
            checkBoxTodayNotCalc.CheckState = CheckState.Checked;
            checkBoxTodayNotCalc.Location = new Point(232, 447);
            checkBoxTodayNotCalc.Name = "checkBoxTodayNotCalc";
            checkBoxTodayNotCalc.Size = new Size(383, 24);
            checkBoxTodayNotCalc.TabIndex = 6;
            checkBoxTodayNotCalc.Text = "Не пересчитывать записи давностью менее часов";
            checkBoxTodayNotCalc.UseVisualStyleBackColor = true;
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Location = new Point(621, 446);
            numericUpDownHours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(106, 27);
            numericUpDownHours.TabIndex = 7;
            numericUpDownHours.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 537);
            Controls.Add(numericUpDownHours);
            Controls.Add(checkBoxTodayNotCalc);
            Controls.Add(statusStrip1);
            Controls.Add(buttonCalcAll);
            Controls.Add(buttonShowSettings);
            Controls.Add(buttonSort);
            Controls.Add(buttonCalcPair);
            Controls.Add(dataGridViewPairs);
            Name = "FormMain";
            Text = "SimpleTradeBot Backtester";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPairs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pairBindingSource).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn idPairDataGridViewTextBoxColumn;
        private DataGridView dataGridViewPairs;
        private BindingSource pairBindingSource;
        private Button buttonCalcPair;
        private Button buttonSort;
        private Button buttonShowSettings;
        private DataGridViewTextBoxColumn pairIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bestWeekProfitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bestDayProfitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastTestTimeDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonCalcAll;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private CheckBox checkBoxTodayNotCalc;
        private NumericUpDown numericUpDownHours;
    }
}