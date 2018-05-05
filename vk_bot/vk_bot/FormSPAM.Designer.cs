namespace vk_bot
{
    partial class FormSPAM
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowserNTV = new System.Windows.Forms.WebBrowser();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.checkBoxу = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // webBrowserNTV
            // 
            this.webBrowserNTV.Location = new System.Drawing.Point(0, 250);
            this.webBrowserNTV.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNTV.Name = "webBrowserNTV";
            this.webBrowserNTV.Size = new System.Drawing.Size(20, 20);
            this.webBrowserNTV.TabIndex = 0;
            this.webBrowserNTV.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserNTV_DocumentCompleted);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(0, 0);
            this.textBoxT.Multiline = true;
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(293, 270);
            this.textBoxT.TabIndex = 1;
            // 
            // checkBoxу
            // 
            this.checkBoxу.AutoSize = true;
            this.checkBoxу.Location = new System.Drawing.Point(191, 250);
            this.checkBoxу.Name = "checkBoxу";
            this.checkBoxу.Size = new System.Drawing.Size(102, 17);
            this.checkBoxу.TabIndex = 2;
            this.checkBoxу.Text = "Поздравляшки";
            this.checkBoxу.UseVisualStyleBackColor = true;
            this.checkBoxу.CheckedChanged += new System.EventHandler(this.checkBoxу_CheckedChanged);
            // 
            // FormSPAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.checkBoxу);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.webBrowserNTV);
            this.Name = "FormSPAM";
            this.Text = "FormSPAM";
            this.Load += new System.EventHandler(this.FormSPAM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserNTV;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.CheckBox checkBoxу;
    }
}