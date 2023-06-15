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
            button2 = new Button();
            buttonShowSettings = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPairs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pairBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPairs
            // 
            dataGridViewPairs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPairs.AutoGenerateColumns = false;
            dataGridViewPairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPairs.Columns.AddRange(new DataGridViewColumn[] { pairIdDataGridViewTextBoxColumn, symbolDataGridViewTextBoxColumn, bestWeekProfitDataGridViewTextBoxColumn, bestDayProfitDataGridViewTextBoxColumn, lastTestTimeDataGridViewTextBoxColumn });
            dataGridViewPairs.DataSource = pairBindingSource;
            dataGridViewPairs.Location = new Point(12, 12);
            dataGridViewPairs.Name = "dataGridViewPairs";
            dataGridViewPairs.RowHeadersWidth = 51;
            dataGridViewPairs.RowTemplate.Height = 29;
            dataGridViewPairs.Size = new Size(958, 477);
            dataGridViewPairs.TabIndex = 0;
            // 
            // pairIdDataGridViewTextBoxColumn
            // 
            pairIdDataGridViewTextBoxColumn.DataPropertyName = "PairId";
            pairIdDataGridViewTextBoxColumn.HeaderText = "PairId";
            pairIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            pairIdDataGridViewTextBoxColumn.Name = "pairIdDataGridViewTextBoxColumn";
            pairIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            symbolDataGridViewTextBoxColumn.MinimumWidth = 6;
            symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            symbolDataGridViewTextBoxColumn.Width = 125;
            // 
            // bestWeekProfitDataGridViewTextBoxColumn
            // 
            bestWeekProfitDataGridViewTextBoxColumn.DataPropertyName = "BestWeekProfit";
            bestWeekProfitDataGridViewTextBoxColumn.HeaderText = "BestWeekProfit";
            bestWeekProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            bestWeekProfitDataGridViewTextBoxColumn.Name = "bestWeekProfitDataGridViewTextBoxColumn";
            bestWeekProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // bestDayProfitDataGridViewTextBoxColumn
            // 
            bestDayProfitDataGridViewTextBoxColumn.DataPropertyName = "BestDayProfit";
            bestDayProfitDataGridViewTextBoxColumn.HeaderText = "BestDayProfit";
            bestDayProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            bestDayProfitDataGridViewTextBoxColumn.Name = "bestDayProfitDataGridViewTextBoxColumn";
            bestDayProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastTestTimeDataGridViewTextBoxColumn
            // 
            lastTestTimeDataGridViewTextBoxColumn.DataPropertyName = "LastTestTime";
            lastTestTimeDataGridViewTextBoxColumn.HeaderText = "LastTestTime";
            lastTestTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastTestTimeDataGridViewTextBoxColumn.Name = "lastTestTimeDataGridViewTextBoxColumn";
            lastTestTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // pairBindingSource
            // 
            pairBindingSource.DataSource = typeof(Data.Pair);
            // 
            // buttonCalcPair
            // 
            buttonCalcPair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCalcPair.Location = new Point(30, 515);
            buttonCalcPair.Name = "buttonCalcPair";
            buttonCalcPair.Size = new Size(169, 29);
            buttonCalcPair.TabIndex = 1;
            buttonCalcPair.Text = "Расссчитать пару";
            buttonCalcPair.UseVisualStyleBackColor = true;
            buttonCalcPair.Click += buttonCalcPair_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(225, 515);
            button2.Name = "button2";
            button2.Size = new Size(202, 29);
            button2.TabIndex = 2;
            button2.Text = "Отсортировать таблицу";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonShowSettings
            // 
            buttonShowSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonShowSettings.Location = new Point(805, 515);
            buttonShowSettings.Name = "buttonShowSettings";
            buttonShowSettings.Size = new Size(165, 29);
            buttonShowSettings.TabIndex = 3;
            buttonShowSettings.Text = "Показать настройки";
            buttonShowSettings.UseVisualStyleBackColor = true;
            buttonShowSettings.Click += buttonShowSettings_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 565);
            Controls.Add(buttonShowSettings);
            Controls.Add(button2);
            Controls.Add(buttonCalcPair);
            Controls.Add(dataGridViewPairs);
            Name = "FormMain";
            Text = "SimpleTradeBot Backtester";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPairs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pairBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn idPairDataGridViewTextBoxColumn;
        private DataGridView dataGridViewPairs;
        private DataGridViewTextBoxColumn pairIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bestWeekProfitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bestDayProfitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastTestTimeDataGridViewTextBoxColumn;
        private BindingSource pairBindingSource;
        private Button buttonCalcPair;
        private Button button2;
        private Button buttonShowSettings;
    }
}