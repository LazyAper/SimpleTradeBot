namespace SimpleTradeBotBacktester
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewSettings = new DataGridView();
            settingIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rsiPeriodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rsiTresholdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percentTakeProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percentStopLossDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            onlyOneSellDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            weekProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayTradesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weekTradesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pairCurrentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            settingBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSettings
            // 
            dataGridViewSettings.AllowUserToAddRows = false;
            dataGridViewSettings.AllowUserToDeleteRows = false;
            dataGridViewSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSettings.AutoGenerateColumns = false;
            dataGridViewSettings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSettings.Columns.AddRange(new DataGridViewColumn[] { settingIdDataGridViewTextBoxColumn, rsiPeriodDataGridViewTextBoxColumn, rsiTresholdDataGridViewTextBoxColumn, percentTakeProfitDataGridViewTextBoxColumn, percentStopLossDataGridViewTextBoxColumn, onlyOneSellDataGridViewCheckBoxColumn, weekProfitDataGridViewTextBoxColumn, dayProfitDataGridViewTextBoxColumn, dayTradesDataGridViewTextBoxColumn, weekTradesDataGridViewTextBoxColumn, pairCurrentDataGridViewTextBoxColumn });
            dataGridViewSettings.DataSource = settingBindingSource;
            dataGridViewSettings.Location = new Point(12, 12);
            dataGridViewSettings.Name = "dataGridViewSettings";
            dataGridViewSettings.ReadOnly = true;
            dataGridViewSettings.RowHeadersWidth = 51;
            dataGridViewSettings.RowTemplate.Height = 29;
            dataGridViewSettings.Size = new Size(1314, 503);
            dataGridViewSettings.TabIndex = 0;
            // 
            // settingIdDataGridViewTextBoxColumn
            // 
            settingIdDataGridViewTextBoxColumn.DataPropertyName = "SettingId";
            settingIdDataGridViewTextBoxColumn.HeaderText = "SettingId";
            settingIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            settingIdDataGridViewTextBoxColumn.Name = "settingIdDataGridViewTextBoxColumn";
            settingIdDataGridViewTextBoxColumn.ReadOnly = true;
            settingIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // rsiPeriodDataGridViewTextBoxColumn
            // 
            rsiPeriodDataGridViewTextBoxColumn.DataPropertyName = "RsiPeriod";
            rsiPeriodDataGridViewTextBoxColumn.HeaderText = "RsiPeriod";
            rsiPeriodDataGridViewTextBoxColumn.MinimumWidth = 6;
            rsiPeriodDataGridViewTextBoxColumn.Name = "rsiPeriodDataGridViewTextBoxColumn";
            rsiPeriodDataGridViewTextBoxColumn.ReadOnly = true;
            rsiPeriodDataGridViewTextBoxColumn.Width = 125;
            // 
            // rsiTresholdDataGridViewTextBoxColumn
            // 
            rsiTresholdDataGridViewTextBoxColumn.DataPropertyName = "RsiTreshold";
            rsiTresholdDataGridViewTextBoxColumn.HeaderText = "RsiTreshold";
            rsiTresholdDataGridViewTextBoxColumn.MinimumWidth = 6;
            rsiTresholdDataGridViewTextBoxColumn.Name = "rsiTresholdDataGridViewTextBoxColumn";
            rsiTresholdDataGridViewTextBoxColumn.ReadOnly = true;
            rsiTresholdDataGridViewTextBoxColumn.Width = 125;
            // 
            // percentTakeProfitDataGridViewTextBoxColumn
            // 
            percentTakeProfitDataGridViewTextBoxColumn.DataPropertyName = "PercentTakeProfit";
            percentTakeProfitDataGridViewTextBoxColumn.HeaderText = "PercentTakeProfit";
            percentTakeProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            percentTakeProfitDataGridViewTextBoxColumn.Name = "percentTakeProfitDataGridViewTextBoxColumn";
            percentTakeProfitDataGridViewTextBoxColumn.ReadOnly = true;
            percentTakeProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // percentStopLossDataGridViewTextBoxColumn
            // 
            percentStopLossDataGridViewTextBoxColumn.DataPropertyName = "PercentStopLoss";
            percentStopLossDataGridViewTextBoxColumn.HeaderText = "PercentStopLoss";
            percentStopLossDataGridViewTextBoxColumn.MinimumWidth = 6;
            percentStopLossDataGridViewTextBoxColumn.Name = "percentStopLossDataGridViewTextBoxColumn";
            percentStopLossDataGridViewTextBoxColumn.ReadOnly = true;
            percentStopLossDataGridViewTextBoxColumn.Width = 125;
            // 
            // onlyOneSellDataGridViewCheckBoxColumn
            // 
            onlyOneSellDataGridViewCheckBoxColumn.DataPropertyName = "OnlyOneSell";
            onlyOneSellDataGridViewCheckBoxColumn.HeaderText = "OnlyOneSell";
            onlyOneSellDataGridViewCheckBoxColumn.MinimumWidth = 6;
            onlyOneSellDataGridViewCheckBoxColumn.Name = "onlyOneSellDataGridViewCheckBoxColumn";
            onlyOneSellDataGridViewCheckBoxColumn.ReadOnly = true;
            onlyOneSellDataGridViewCheckBoxColumn.Width = 125;
            // 
            // weekProfitDataGridViewTextBoxColumn
            // 
            weekProfitDataGridViewTextBoxColumn.DataPropertyName = "WeekProfit";
            weekProfitDataGridViewTextBoxColumn.HeaderText = "WeekProfit";
            weekProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            weekProfitDataGridViewTextBoxColumn.Name = "weekProfitDataGridViewTextBoxColumn";
            weekProfitDataGridViewTextBoxColumn.ReadOnly = true;
            weekProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // dayProfitDataGridViewTextBoxColumn
            // 
            dayProfitDataGridViewTextBoxColumn.DataPropertyName = "DayProfit";
            dayProfitDataGridViewTextBoxColumn.HeaderText = "DayProfit";
            dayProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            dayProfitDataGridViewTextBoxColumn.Name = "dayProfitDataGridViewTextBoxColumn";
            dayProfitDataGridViewTextBoxColumn.ReadOnly = true;
            dayProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // dayTradesDataGridViewTextBoxColumn
            // 
            dayTradesDataGridViewTextBoxColumn.DataPropertyName = "DayTrades";
            dayTradesDataGridViewTextBoxColumn.HeaderText = "DayTrades";
            dayTradesDataGridViewTextBoxColumn.MinimumWidth = 6;
            dayTradesDataGridViewTextBoxColumn.Name = "dayTradesDataGridViewTextBoxColumn";
            dayTradesDataGridViewTextBoxColumn.ReadOnly = true;
            dayTradesDataGridViewTextBoxColumn.Width = 125;
            // 
            // weekTradesDataGridViewTextBoxColumn
            // 
            weekTradesDataGridViewTextBoxColumn.DataPropertyName = "WeekTrades";
            weekTradesDataGridViewTextBoxColumn.HeaderText = "WeekTrades";
            weekTradesDataGridViewTextBoxColumn.MinimumWidth = 6;
            weekTradesDataGridViewTextBoxColumn.Name = "weekTradesDataGridViewTextBoxColumn";
            weekTradesDataGridViewTextBoxColumn.ReadOnly = true;
            weekTradesDataGridViewTextBoxColumn.Width = 125;
            // 
            // pairCurrentDataGridViewTextBoxColumn
            // 
            pairCurrentDataGridViewTextBoxColumn.DataPropertyName = "PairCurrent";
            pairCurrentDataGridViewTextBoxColumn.HeaderText = "PairCurrent";
            pairCurrentDataGridViewTextBoxColumn.MinimumWidth = 6;
            pairCurrentDataGridViewTextBoxColumn.Name = "pairCurrentDataGridViewTextBoxColumn";
            pairCurrentDataGridViewTextBoxColumn.ReadOnly = true;
            pairCurrentDataGridViewTextBoxColumn.Width = 125;
            // 
            // settingBindingSource
            // 
            settingBindingSource.DataSource = typeof(Data.Setting);
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 527);
            Controls.Add(dataGridViewSettings);
            Name = "FormSettings";
            Text = "Настройки пары";
            Load += FormSettings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSettings;
        private DataGridViewTextBoxColumn idSettingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn settingIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rsiPeriodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rsiTresholdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percentTakeProfitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percentStopLossDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn onlyOneSellDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn weekProfitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayProfitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayTradesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weekTradesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pairCurrentDataGridViewTextBoxColumn;
        private BindingSource settingBindingSource;
    }
}