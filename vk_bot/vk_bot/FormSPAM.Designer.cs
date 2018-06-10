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
            this.components = new System.ComponentModel.Container();
            this.webBrowserNTV = new System.Windows.Forms.WebBrowser();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.checkBoxу = new System.Windows.Forms.CheckBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.ORG = new System.Windows.Forms.Label();
            this.WindowHalfBorder = new System.Windows.Forms.PictureBox();
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.button6 = new System.Windows.Forms.Button();
            this.FADERSTART = new System.Windows.Forms.Timer(this.components);
            this.FADERMINI = new System.Windows.Forms.Timer(this.components);
            this.FADER = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowserNTV
            // 

            this.webBrowserNTV.Location = new System.Drawing.Point(49, 20);
            this.webBrowserNTV.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNTV.Name = "webBrowserNTV";
            this.webBrowserNTV.Size = new System.Drawing.Size(20, 20);
            this.webBrowserNTV.TabIndex = 0;
            this.webBrowserNTV.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserNTV_DocumentCompleted);
            // 
            // textBoxT
            // 

            this.textBoxT.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxT.Location = new System.Drawing.Point(-1, 50);
            this.textBoxT.Multiline = true;
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(534, 270);

            this.textBoxT.TabIndex = 1;
            // 
            // checkBoxу
            // 
            this.checkBoxу.AutoSize = true;

            this.checkBoxу.Location = new System.Drawing.Point(198, 326);

            this.checkBoxу.Name = "checkBoxу";
            this.checkBoxу.Size = new System.Drawing.Size(102, 17);
            this.checkBoxу.TabIndex = 2;
            this.checkBoxу.Text = "Поздравляшки";
            this.checkBoxу.UseVisualStyleBackColor = true;
            this.checkBoxу.CheckedChanged += new System.EventHandler(this.checkBoxу_CheckedChanged);
            // 

            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.Button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.Button_Exit.FlatAppearance.BorderSize = 0;
            this.Button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Exit.Location = new System.Drawing.Point(487, -1);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(44, 45);
            this.Button_Exit.TabIndex = 43;
            this.Button_Exit.Text = "x";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.Minimize_Button.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.Minimize_Button.FlatAppearance.BorderSize = 0;
            this.Minimize_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.Minimize_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Minimize_Button.Location = new System.Drawing.Point(446, -1);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(41, 45);
            this.Minimize_Button.TabIndex = 44;
            this.Minimize_Button.Text = "_";
            this.Minimize_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize_Button.UseVisualStyleBackColor = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // ORG
            // 
            this.ORG.AutoSize = true;
            this.ORG.BackColor = System.Drawing.Color.SteelBlue;
            this.ORG.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ORG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ORG.Location = new System.Drawing.Point(2, 0);
            this.ORG.Name = "ORG";
            this.ORG.Size = new System.Drawing.Size(344, 40);
            this.ORG.TabIndex = 41;
            this.ORG.Text = "ПОЗДРАВЛЕНИЕ С ДР";
            this.ORG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.ORG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.ORG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // WindowHalfBorder
            // 
            this.WindowHalfBorder.BackColor = System.Drawing.Color.SteelBlue;
            this.WindowHalfBorder.Location = new System.Drawing.Point(-252, 0);
            this.WindowHalfBorder.Name = "WindowHalfBorder";
            this.WindowHalfBorder.Size = new System.Drawing.Size(783, 44);
            this.WindowHalfBorder.TabIndex = 42;
            this.WindowHalfBorder.TabStop = false;
            this.WindowHalfBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.WindowHalfBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.WindowHalfBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // webBrowser5
            // 
            this.webBrowser5.Location = new System.Drawing.Point(23, 7);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.Size = new System.Drawing.Size(20, 28);
            this.webBrowser5.TabIndex = 40;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SteelBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(0, 326);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(531, 49);
            this.button6.TabIndex = 45;
            this.button6.Text = "Поздравить друзей";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.checkBoxу_CheckedChanged);
            // 
            // FADERSTART
            // 
            this.FADERSTART.Interval = 1;
            this.FADERSTART.Tick += new System.EventHandler(this.FADERSTART_Tick);
            // 
            // FADERMINI
            // 
            this.FADERMINI.Interval = 1;
            this.FADERMINI.Tick += new System.EventHandler(this.FADERMINI_Tick);
            // 
            // FADER
            // 
            this.FADER.Interval = 1;
            this.FADER.Tick += new System.EventHandler(this.FADER_Tick);
            // 

            // FormSPAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(532, 373);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.ORG);
            this.Controls.Add(this.WindowHalfBorder);
            this.Controls.Add(this.webBrowser5);
            this.Controls.Add(this.checkBoxу);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.webBrowserNTV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSPAM";
            this.Text = "FormSPAM";
            this.Load += new System.EventHandler(this.FormSPAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserNTV;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.CheckBox checkBoxу;

        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Label ORG;
        private System.Windows.Forms.PictureBox WindowHalfBorder;
        private System.Windows.Forms.WebBrowser webBrowser5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer FADERSTART;
        private System.Windows.Forms.Timer FADERMINI;
        private System.Windows.Forms.Timer FADER;

    }
}