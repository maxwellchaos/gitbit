namespace vk_bot
{
    partial class FormSpam_DR
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
            this.components = new System.ComponentModel.Container();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxMess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowserWWW = new System.Windows.Forms.WebBrowser();
            this.timerQwerty = new System.Windows.Forms.Timer(this.components);
            this.buttonSPAM = new System.Windows.Forms.Button();
            this.labelbree = new System.Windows.Forms.Label();
            this.labelENT = new System.Windows.Forms.Label();
            this.labelrrr = new System.Windows.Forms.Label();
            this.numericUpDownqwe = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownrr = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownqwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownrr)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(0, 0);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(109, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxMess
            // 
            this.textBoxMess.Location = new System.Drawing.Point(0, 26);
            this.textBoxMess.Name = "textBoxMess";
            this.textBoxMess.Size = new System.Drawing.Size(193, 20);
            this.textBoxMess.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Для ссылка на личную страницу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Для сообщения";
            // 
            // webBrowserWWW
            // 
            this.webBrowserWWW.Location = new System.Drawing.Point(0, 184);
            this.webBrowserWWW.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWWW.Name = "webBrowserWWW";
            this.webBrowserWWW.Size = new System.Drawing.Size(69, 84);
            this.webBrowserWWW.TabIndex = 5;
            // 
            // timerQwerty
            // 
            this.timerQwerty.Interval = 2000;
            this.timerQwerty.Tick += new System.EventHandler(this.timerQwerty_Tick);
            // 
            // buttonSPAM
            // 
            this.buttonSPAM.Location = new System.Drawing.Point(-6, 52);
            this.buttonSPAM.Name = "buttonSPAM";
            this.buttonSPAM.Size = new System.Drawing.Size(75, 56);
            this.buttonSPAM.TabIndex = 6;
            this.buttonSPAM.Text = "СПАМ";
            this.buttonSPAM.UseVisualStyleBackColor = true;
            this.buttonSPAM.Click += new System.EventHandler(this.buttonSPAM_Click);
            // 
            // labelbree
            // 
            this.labelbree.AutoSize = true;
            this.labelbree.Location = new System.Drawing.Point(199, 106);
            this.labelbree.Name = "labelbree";
            this.labelbree.Size = new System.Drawing.Size(35, 13);
            this.labelbree.TabIndex = 7;
            this.labelbree.Text = "label3";
            // 
            // labelENT
            // 
            this.labelENT.AutoSize = true;
            this.labelENT.Location = new System.Drawing.Point(199, 81);
            this.labelENT.Name = "labelENT";
            this.labelENT.Size = new System.Drawing.Size(89, 13);
            this.labelENT.TabIndex = 8;
            this.labelENT.Text = "Для количества";
            // 
            // labelrrr
            // 
            this.labelrrr.AutoSize = true;
            this.labelrrr.Location = new System.Drawing.Point(199, 55);
            this.labelrrr.Name = "labelrrr";
            this.labelrrr.Size = new System.Drawing.Size(84, 13);
            this.labelrrr.TabIndex = 9;
            this.labelrrr.Text = "Для интервала";
            // 
            // numericUpDownqwe
            // 
            this.numericUpDownqwe.Location = new System.Drawing.Point(75, 52);
            this.numericUpDownqwe.Name = "numericUpDownqwe";
            this.numericUpDownqwe.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownqwe.TabIndex = 12;
            // 
            // numericUpDownrr
            // 
            this.numericUpDownrr.Location = new System.Drawing.Point(73, 78);
            this.numericUpDownrr.Name = "numericUpDownrr";
            this.numericUpDownrr.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownrr.TabIndex = 13;
            // 
            // FormSpam_DR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.numericUpDownrr);
            this.Controls.Add(this.numericUpDownqwe);
            this.Controls.Add(this.labelrrr);
            this.Controls.Add(this.labelENT);
            this.Controls.Add(this.labelbree);
            this.Controls.Add(this.buttonSPAM);
            this.Controls.Add(this.webBrowserWWW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMess);
            this.Controls.Add(this.textBoxID);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormSpam_DR";
            this.Text = "FormSPAM";
            this.Load += new System.EventHandler(this.FormDR_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownqwe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownrr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxMess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowserWWW;
        private System.Windows.Forms.Timer timerQwerty;
        private System.Windows.Forms.Button buttonSPAM;
        private System.Windows.Forms.Label labelbree;
        private System.Windows.Forms.Label labelENT;
        private System.Windows.Forms.Label labelrrr;
        private System.Windows.Forms.NumericUpDown numericUpDownqwe;
        private System.Windows.Forms.NumericUpDown numericUpDownrr;
    }
}