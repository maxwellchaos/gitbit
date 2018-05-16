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
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownqwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownrr)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxID.Location = new System.Drawing.Point(1, 88);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(760, 24);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMess
            // 
            this.textBoxMess.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxMess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxMess.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxMess.Location = new System.Drawing.Point(1, 183);
            this.textBoxMess.Name = "textBoxMess";
            this.textBoxMess.Size = new System.Drawing.Size(760, 24);
            this.textBoxMess.TabIndex = 1;
            this.textBoxMess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cсылка ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-4, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Для сообщения";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // webBrowserWWW
            // 
            this.webBrowserWWW.Location = new System.Drawing.Point(331, 383);
            this.webBrowserWWW.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWWW.Name = "webBrowserWWW";
            this.webBrowserWWW.Size = new System.Drawing.Size(20, 20);
            this.webBrowserWWW.TabIndex = 5;
            // 
            // timerQwerty
            // 
            this.timerQwerty.Interval = 2000;
            this.timerQwerty.Tick += new System.EventHandler(this.timerQwerty_Tick);
            // 
            // buttonSPAM
            // 
            this.buttonSPAM.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSPAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSPAM.FlatAppearance.BorderSize = 0;
            this.buttonSPAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSPAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSPAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSPAM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSPAM.Location = new System.Drawing.Point(1, 369);
            this.buttonSPAM.Name = "buttonSPAM";
            this.buttonSPAM.Size = new System.Drawing.Size(788, 92);
            this.buttonSPAM.TabIndex = 6;
            this.buttonSPAM.Text = "СПАМ";
            this.buttonSPAM.UseVisualStyleBackColor = false;
            this.buttonSPAM.Click += new System.EventHandler(this.buttonSPAM_Click);
            // 
            // labelbree
            // 
            this.labelbree.AutoSize = true;
            this.labelbree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelbree.Location = new System.Drawing.Point(687, 315);
            this.labelbree.Name = "labelbree";
            this.labelbree.Size = new System.Drawing.Size(0, 25);
            this.labelbree.TabIndex = 7;
            // 
            // labelENT
            // 
            this.labelENT.AutoSize = true;
            this.labelENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelENT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelENT.Location = new System.Drawing.Point(-4, 217);
            this.labelENT.Name = "labelENT";
            this.labelENT.Size = new System.Drawing.Size(212, 29);
            this.labelENT.TabIndex = 8;
            this.labelENT.Text = "Для количества";
            // 
            // labelrrr
            // 
            this.labelrrr.AutoSize = true;
            this.labelrrr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelrrr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelrrr.Location = new System.Drawing.Point(-4, 286);
            this.labelrrr.Name = "labelrrr";
            this.labelrrr.Size = new System.Drawing.Size(201, 29);
            this.labelrrr.TabIndex = 9;
            this.labelrrr.Text = "Для интервала";
            // 
            // numericUpDownqwe
            // 
            this.numericUpDownqwe.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDownqwe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownqwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDownqwe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDownqwe.Location = new System.Drawing.Point(1, 249);
            this.numericUpDownqwe.Name = "numericUpDownqwe";
            this.numericUpDownqwe.Size = new System.Drawing.Size(771, 27);
            this.numericUpDownqwe.TabIndex = 12;
            this.numericUpDownqwe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownrr
            // 
            this.numericUpDownrr.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDownrr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownrr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownrr.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDownrr.Location = new System.Drawing.Point(-3, 318);
            this.numericUpDownrr.Name = "numericUpDownrr";
            this.numericUpDownrr.Size = new System.Drawing.Size(775, 27);
            this.numericUpDownrr.TabIndex = 13;
            this.numericUpDownrr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "на личную страницу";
            // 
            // FormSpam_DR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownrr);
            this.Controls.Add(this.numericUpDownqwe);
            this.Controls.Add(this.labelrrr);
            this.Controls.Add(this.labelbree);
            this.Controls.Add(this.buttonSPAM);
            this.Controls.Add(this.webBrowserWWW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMess);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelENT);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
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
        private System.Windows.Forms.Label label3;
    }
}