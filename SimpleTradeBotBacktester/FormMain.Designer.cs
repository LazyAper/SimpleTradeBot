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
            pairBindingSource = new BindingSource(components);
            settingsBindingSource = new BindingSource(components);
            idPairDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            symbolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bestWeekProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bestDayProfitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pairBindingSource1 = new BindingSource(components);
            buttonDownload = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPairs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pairBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pairBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPairs
            // 
            dataGridViewPairs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPairs.AutoGenerateColumns = false;
            dataGridViewPairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPairs.Columns.AddRange(new DataGridViewColumn[] { idPairDataGridViewTextBoxColumn, symbolDataGridViewTextBoxColumn, bestWeekProfitDataGridViewTextBoxColumn, bestDayProfitDataGridViewTextBoxColumn });
            dataGridViewPairs.DataSource = pairBindingSource1;
            dataGridViewPairs.Location = new Point(12, 12);
            dataGridViewPairs.Name = "dataGridViewPairs";
            dataGridViewPairs.RowHeadersWidth = 51;
            dataGridViewPairs.RowTemplate.Height = 29;
            dataGridViewPairs.Size = new Size(947, 487);
            dataGridViewPairs.TabIndex = 0;
            // 
            // pairBindingSource
            // 
            pairBindingSource.DataSource = typeof(Data.Pair);
            // 
            // settingsBindingSource
            // 
            settingsBindingSource.DataMember = "Settings";
            settingsBindingSource.DataSource = pairBindingSource;
            // 
            // idPairDataGridViewTextBoxColumn
            // 
            idPairDataGridViewTextBoxColumn.DataPropertyName = "IdPair";
            idPairDataGridViewTextBoxColumn.HeaderText = "IdPair";
            idPairDataGridViewTextBoxColumn.MinimumWidth = 6;
            idPairDataGridViewTextBoxColumn.Name = "idPairDataGridViewTextBoxColumn";
            idPairDataGridViewTextBoxColumn.Width = 125;
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
            // pairBindingSource1
            // 
            pairBindingSource1.DataSource = typeof(Data.Pair);
            // 
            // buttonDownload
            // 
            buttonDownload.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDownload.Location = new Point(16, 516);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(161, 29);
            buttonDownload.TabIndex = 1;
            buttonDownload.Text = "Загрузить";
            buttonDownload.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(192, 514);
            button1.Name = "button1";
            button1.Size = new Size(168, 29);
            button1.TabIndex = 2;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 541);
            Controls.Add(button1);
            Controls.Add(buttonDownload);
            Controls.Add(dataGridViewPairs);
            Name = "FormMain";
            Text = "SimpleTradeBot Backtester";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPairs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pairBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pairBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPairs;
        private BindingSource pairBindingSource;
        private DataGridViewTextBoxColumn idPairDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bestWeekProfitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bestDayProfitDataGridViewTextBoxColumn;
        private BindingSource pairBindingSource1;
        private BindingSource settingsBindingSource;
        private Button buttonDownload;
        private Button button1;
    }
}