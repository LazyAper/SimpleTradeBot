namespace SimpleTradeBotBacktester
{
    partial class FormTrace
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
            dataGridView1 = new DataGridView();
            tradeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rSIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            traceTradeBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDownRSIPeriod = new NumericUpDown();
            numericUpDownRSITreshold = new NumericUpDown();
            numericUpDownPercentTP = new NumericUpDown();
            numericUpDownPercentSL = new NumericUpDown();
            checkBoxOnlyOneSell = new CheckBox();
            buttonSetSettings = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)traceTradeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRSIPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRSITreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPercentTP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPercentSL).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tradeIdDataGridViewTextBoxColumn, timeDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, directionDataGridViewTextBoxColumn, profitDataGridViewTextBoxColumn, rSIDataGridViewTextBoxColumn });
            dataGridView1.DataSource = traceTradeBindingSource;
            dataGridView1.Location = new Point(11, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(906, 412);
            dataGridView1.TabIndex = 0;
            // 
            // tradeIdDataGridViewTextBoxColumn
            // 
            tradeIdDataGridViewTextBoxColumn.DataPropertyName = "TradeId";
            tradeIdDataGridViewTextBoxColumn.HeaderText = "TradeId";
            tradeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            tradeIdDataGridViewTextBoxColumn.Name = "tradeIdDataGridViewTextBoxColumn";
            tradeIdDataGridViewTextBoxColumn.ReadOnly = true;
            tradeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.ReadOnly = true;
            timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // directionDataGridViewTextBoxColumn
            // 
            directionDataGridViewTextBoxColumn.DataPropertyName = "Direction";
            directionDataGridViewTextBoxColumn.HeaderText = "Direction";
            directionDataGridViewTextBoxColumn.MinimumWidth = 6;
            directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            directionDataGridViewTextBoxColumn.ReadOnly = true;
            directionDataGridViewTextBoxColumn.Width = 125;
            // 
            // profitDataGridViewTextBoxColumn
            // 
            profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            profitDataGridViewTextBoxColumn.MinimumWidth = 6;
            profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            profitDataGridViewTextBoxColumn.ReadOnly = true;
            profitDataGridViewTextBoxColumn.Width = 125;
            // 
            // rSIDataGridViewTextBoxColumn
            // 
            rSIDataGridViewTextBoxColumn.DataPropertyName = "RSI";
            rSIDataGridViewTextBoxColumn.HeaderText = "RSI";
            rSIDataGridViewTextBoxColumn.MinimumWidth = 6;
            rSIDataGridViewTextBoxColumn.Name = "rSIDataGridViewTextBoxColumn";
            rSIDataGridViewTextBoxColumn.ReadOnly = true;
            rSIDataGridViewTextBoxColumn.Width = 125;
            // 
            // traceTradeBindingSource
            // 
            traceTradeBindingSource.DataSource = typeof(Data.TraceTrade);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "RSI период";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 46);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "RSI порог";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 14);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 3;
            label3.Text = "Процент take profit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 51);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 4;
            label4.Text = "Процент stop loss";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(540, 35);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 5;
            // 
            // numericUpDownRSIPeriod
            // 
            numericUpDownRSIPeriod.Location = new Point(104, 12);
            numericUpDownRSIPeriod.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDownRSIPeriod.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownRSIPeriod.Name = "numericUpDownRSIPeriod";
            numericUpDownRSIPeriod.Size = new Size(132, 27);
            numericUpDownRSIPeriod.TabIndex = 6;
            numericUpDownRSIPeriod.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // numericUpDownRSITreshold
            // 
            numericUpDownRSITreshold.Location = new Point(104, 49);
            numericUpDownRSITreshold.Name = "numericUpDownRSITreshold";
            numericUpDownRSITreshold.Size = new Size(132, 27);
            numericUpDownRSITreshold.TabIndex = 7;
            numericUpDownRSITreshold.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // numericUpDownPercentTP
            // 
            numericUpDownPercentTP.DecimalPlaces = 2;
            numericUpDownPercentTP.Location = new Point(392, 15);
            numericUpDownPercentTP.Name = "numericUpDownPercentTP";
            numericUpDownPercentTP.Size = new Size(109, 27);
            numericUpDownPercentTP.TabIndex = 8;
            numericUpDownPercentTP.Value = new decimal(new int[] { 15, 0, 0, 65536 });
            // 
            // numericUpDownPercentSL
            // 
            numericUpDownPercentSL.DecimalPlaces = 2;
            numericUpDownPercentSL.Location = new Point(392, 49);
            numericUpDownPercentSL.Name = "numericUpDownPercentSL";
            numericUpDownPercentSL.Size = new Size(107, 27);
            numericUpDownPercentSL.TabIndex = 9;
            numericUpDownPercentSL.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // checkBoxOnlyOneSell
            // 
            checkBoxOnlyOneSell.AutoSize = true;
            checkBoxOnlyOneSell.Location = new Point(516, 33);
            checkBoxOnlyOneSell.Name = "checkBoxOnlyOneSell";
            checkBoxOnlyOneSell.Size = new Size(252, 24);
            checkBoxOnlyOneSell.TabIndex = 10;
            checkBoxOnlyOneSell.Text = "Не более одной покупки к ряду";
            checkBoxOnlyOneSell.UseVisualStyleBackColor = true;
            // 
            // buttonSetSettings
            // 
            buttonSetSettings.Location = new Point(787, 23);
            buttonSetSettings.Name = "buttonSetSettings";
            buttonSetSettings.Size = new Size(130, 48);
            buttonSetSettings.TabIndex = 11;
            buttonSetSettings.Text = "Задать настройки";
            buttonSetSettings.UseVisualStyleBackColor = true;
            buttonSetSettings.Click += buttonSetSettings_Click;
            // 
            // FormTrace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 513);
            Controls.Add(buttonSetSettings);
            Controls.Add(checkBoxOnlyOneSell);
            Controls.Add(numericUpDownPercentSL);
            Controls.Add(numericUpDownPercentTP);
            Controls.Add(numericUpDownRSITreshold);
            Controls.Add(numericUpDownRSIPeriod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormTrace";
            Text = "Трассировка настройки";
            Load += FormTrace_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)traceTradeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRSIPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRSITreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPercentTP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPercentSL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tradeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rSIDataGridViewTextBoxColumn;
        private BindingSource traceTradeBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownRSIPeriod;
        private NumericUpDown numericUpDownRSITreshold;
        private NumericUpDown numericUpDownPercentTP;
        private NumericUpDown numericUpDownPercentSL;
        private CheckBox checkBoxOnlyOneSell;
        private Button buttonSetSettings;
    }
}