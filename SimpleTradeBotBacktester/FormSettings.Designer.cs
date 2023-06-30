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
            buttonTrace = new Button();
            buttonIniGenerate = new Button();
            settingBindingSource = new BindingSource(components);
            settingIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parametr1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parametr2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parametr3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percentTakeProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percentStopLossDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            onlyOneSellDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            weekProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayTradesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weekTradesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pairCurrentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            dataGridViewSettings.Columns.AddRange(new DataGridViewColumn[] { settingIdDataGridViewTextBoxColumn, parametr1DataGridViewTextBoxColumn, parametr2DataGridViewTextBoxColumn, parametr3DataGridViewTextBoxColumn, percentTakeProfitDataGridViewTextBoxColumn, percentStopLossDataGridViewTextBoxColumn, onlyOneSellDataGridViewCheckBoxColumn, weekProfitDataGridViewTextBoxColumn, dayProfitDataGridViewTextBoxColumn, dayTradesDataGridViewTextBoxColumn, weekTradesDataGridViewTextBoxColumn, pairCurrentDataGridViewTextBoxColumn });
            dataGridViewSettings.DataSource = settingBindingSource;
            dataGridViewSettings.Location = new Point(12, 12);
            dataGridViewSettings.Name = "dataGridViewSettings";
            dataGridViewSettings.ReadOnly = true;
            dataGridViewSettings.RowHeadersWidth = 51;
            dataGridViewSettings.RowTemplate.Height = 29;
            dataGridViewSettings.Size = new Size(1365, 472);
            dataGridViewSettings.TabIndex = 0;
            // 
            // buttonTrace
            // 
            buttonTrace.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonTrace.Location = new Point(1222, 490);
            buttonTrace.Name = "buttonTrace";
            buttonTrace.Size = new Size(155, 29);
            buttonTrace.TabIndex = 1;
            buttonTrace.Text = "Трассировка";
            buttonTrace.UseVisualStyleBackColor = true;
            buttonTrace.Click += buttonTrace_Click;
            // 
            // buttonIniGenerate
            // 
            buttonIniGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonIniGenerate.Location = new Point(1030, 490);
            buttonIniGenerate.Name = "buttonIniGenerate";
            buttonIniGenerate.Size = new Size(176, 29);
            buttonIniGenerate.TabIndex = 2;
            buttonIniGenerate.Text = "Генерация ini";
            buttonIniGenerate.UseVisualStyleBackColor = true;
            buttonIniGenerate.Click += buttonIniGenerate_Click;
            // 
            // settingBindingSource
            // 
            settingBindingSource.DataSource = typeof(Data.Setting);
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
            // parametr1DataGridViewTextBoxColumn
            // 
            parametr1DataGridViewTextBoxColumn.DataPropertyName = "Parametr1";
            parametr1DataGridViewTextBoxColumn.HeaderText = "Parametr1";
            parametr1DataGridViewTextBoxColumn.MinimumWidth = 6;
            parametr1DataGridViewTextBoxColumn.Name = "parametr1DataGridViewTextBoxColumn";
            parametr1DataGridViewTextBoxColumn.ReadOnly = true;
            parametr1DataGridViewTextBoxColumn.Width = 125;
            // 
            // parametr2DataGridViewTextBoxColumn
            // 
            parametr2DataGridViewTextBoxColumn.DataPropertyName = "Parametr2";
            parametr2DataGridViewTextBoxColumn.HeaderText = "Parametr2";
            parametr2DataGridViewTextBoxColumn.MinimumWidth = 6;
            parametr2DataGridViewTextBoxColumn.Name = "parametr2DataGridViewTextBoxColumn";
            parametr2DataGridViewTextBoxColumn.ReadOnly = true;
            parametr2DataGridViewTextBoxColumn.Width = 125;
            // 
            // parametr3DataGridViewTextBoxColumn
            // 
            parametr3DataGridViewTextBoxColumn.DataPropertyName = "Parametr3";
            parametr3DataGridViewTextBoxColumn.HeaderText = "Parametr3";
            parametr3DataGridViewTextBoxColumn.MinimumWidth = 6;
            parametr3DataGridViewTextBoxColumn.Name = "parametr3DataGridViewTextBoxColumn";
            parametr3DataGridViewTextBoxColumn.ReadOnly = true;
            parametr3DataGridViewTextBoxColumn.Width = 125;
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
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 525);
            Controls.Add(buttonIniGenerate);
            Controls.Add(buttonTrace);
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
        private DataGridViewTextBoxColumn rsiPeriodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rsiTresholdDataGridViewTextBoxColumn;
        private Button buttonTrace;
        private Button buttonIniGenerate;
        private DataGridViewTextBoxColumn settingIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parametr1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parametr2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parametr3DataGridViewTextBoxColumn;
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