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
            settingBindingSource = new BindingSource(components);
            idSettingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rsiPeriodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rsiTresholdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percentTakeProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percentStopLossDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            onlyOneSellDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weekProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSettings
            // 
            dataGridViewSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSettings.AutoGenerateColumns = false;
            dataGridViewSettings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSettings.Columns.AddRange(new DataGridViewColumn[] { idSettingDataGridViewTextBoxColumn, rsiPeriodDataGridViewTextBoxColumn, rsiTresholdDataGridViewTextBoxColumn, percentTakeProfitDataGridViewTextBoxColumn, percentStopLossDataGridViewTextBoxColumn, onlyOneSellDataGridViewCheckBoxColumn, timeDataGridViewTextBoxColumn, weekProfitDataGridViewTextBoxColumn, dayProfitDataGridViewTextBoxColumn });
            dataGridViewSettings.DataSource = settingBindingSource;
            dataGridViewSettings.Location = new Point(12, 12);
            dataGridViewSettings.Name = "dataGridViewSettings";
            dataGridViewSettings.RowHeadersWidth = 51;
            dataGridViewSettings.RowTemplate.Height = 29;
            dataGridViewSettings.Size = new Size(1186, 489);
            dataGridViewSettings.TabIndex = 0;
            // 
            // settingBindingSource
            // 
            settingBindingSource.DataSource = typeof(Data.Setting);
            // 
            // idSettingDataGridViewTextBoxColumn
            // 
            idSettingDataGridViewTextBoxColumn.DataPropertyName = "IdSetting";
            idSettingDataGridViewTextBoxColumn.HeaderText = "IdSetting";
            idSettingDataGridViewTextBoxColumn.MinimumWidth = 6;
            idSettingDataGridViewTextBoxColumn.Name = "idSettingDataGridViewTextBoxColumn";
            idSettingDataGridViewTextBoxColumn.Width = 125;
            // 
            // rsiPeriodDataGridViewTextBoxColumn
            // 
            rsiPeriodDataGridViewTextBoxColumn.DataPropertyName = "RsiPeriod";
            rsiPeriodDataGridViewTextBoxColumn.HeaderText = "RsiPeriod";
            rsiPeriodDataGridViewTextBoxColumn.MinimumWidth = 6;
            rsiPeriodDataGridViewTextBoxColumn.Name = "rsiPeriodDataGridViewTextBoxColumn";
            rsiPeriodDataGridViewTextBoxColumn.Width = 125;
            // 
            // rsiTresholdDataGridViewTextBoxColumn
            // 
            rsiTresholdDataGridViewTextBoxColumn.DataPropertyName = "RsiTreshold";
            rsiTresholdDataGridViewTextBoxColumn.HeaderText = "RsiTreshold";
            rsiTresholdDataGridViewTextBoxColumn.MinimumWidth = 6;
            rsiTresholdDataGridViewTextBoxColumn.Name = "rsiTresholdDataGridViewTextBoxColumn";
            rsiTresholdDataGridViewTextBoxColumn.Width = 125;
            // 
            // percentTakeProfitDataGridViewTextBoxColumn
            // 
            percentTakeProfitDataGridViewTextBoxColumn.DataPropertyName = "PercentTakeProfit";
            percentTakeProfitDataGridViewTextBoxColumn.HeaderText = "PercentTakeProfit";
            percentTakeProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            percentTakeProfitDataGridViewTextBoxColumn.Name = "percentTakeProfitDataGridViewTextBoxColumn";
            percentTakeProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // percentStopLossDataGridViewTextBoxColumn
            // 
            percentStopLossDataGridViewTextBoxColumn.DataPropertyName = "PercentStopLoss";
            percentStopLossDataGridViewTextBoxColumn.HeaderText = "PercentStopLoss";
            percentStopLossDataGridViewTextBoxColumn.MinimumWidth = 6;
            percentStopLossDataGridViewTextBoxColumn.Name = "percentStopLossDataGridViewTextBoxColumn";
            percentStopLossDataGridViewTextBoxColumn.Width = 125;
            // 
            // onlyOneSellDataGridViewCheckBoxColumn
            // 
            onlyOneSellDataGridViewCheckBoxColumn.DataPropertyName = "OnlyOneSell";
            onlyOneSellDataGridViewCheckBoxColumn.HeaderText = "OnlyOneSell";
            onlyOneSellDataGridViewCheckBoxColumn.MinimumWidth = 6;
            onlyOneSellDataGridViewCheckBoxColumn.Name = "onlyOneSellDataGridViewCheckBoxColumn";
            onlyOneSellDataGridViewCheckBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // weekProfitDataGridViewTextBoxColumn
            // 
            weekProfitDataGridViewTextBoxColumn.DataPropertyName = "WeekProfit";
            weekProfitDataGridViewTextBoxColumn.HeaderText = "WeekProfit";
            weekProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            weekProfitDataGridViewTextBoxColumn.Name = "weekProfitDataGridViewTextBoxColumn";
            weekProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // dayProfitDataGridViewTextBoxColumn
            // 
            dayProfitDataGridViewTextBoxColumn.DataPropertyName = "DayProfit";
            dayProfitDataGridViewTextBoxColumn.HeaderText = "DayProfit";
            dayProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            dayProfitDataGridViewTextBoxColumn.Name = "dayProfitDataGridViewTextBoxColumn";
            dayProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 513);
            Controls.Add(dataGridViewSettings);
            Name = "FormSettings";
            Text = "Настройки пары";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSettings;
        private DataGridViewTextBoxColumn idSettingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rsiPeriodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rsiTresholdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percentTakeProfitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percentStopLossDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn onlyOneSellDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weekProfitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayProfitDataGridViewTextBoxColumn;
        private BindingSource settingBindingSource;
    }
}