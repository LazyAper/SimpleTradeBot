namespace SimpleTradeBotBacktester
{
    partial class FormIni
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
            textBoxIni = new TextBox();
            buttonCopy = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // textBoxIni
            // 
            textBoxIni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIni.Location = new Point(12, 12);
            textBoxIni.Multiline = true;
            textBoxIni.Name = "textBoxIni";
            textBoxIni.Size = new Size(766, 384);
            textBoxIni.TabIndex = 0;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(648, 410);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(130, 29);
            buttonCopy.TabIndex = 1;
            buttonCopy.Text = "Скопировать";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClose.Location = new Point(12, 410);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormIni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 451);
            Controls.Add(buttonClose);
            Controls.Add(buttonCopy);
            Controls.Add(textBoxIni);
            Name = "FormIni";
            Text = "Генерация ini";
            Load += FormIni_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIni;
        private Button buttonCopy;
        private Button buttonClose;
    }
}