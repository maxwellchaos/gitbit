namespace vk_bot
{
    partial class prigl
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.ORG = new System.Windows.Forms.Label();
            this.WindowHalfBorder = new System.Windows.Forms.PictureBox();
            this.FADER = new System.Windows.Forms.Timer(this.components);
            this.FADERMINI = new System.Windows.Forms.Timer(this.components);
            this.FADERSTART = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(-1, 143);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(602, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите id ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-1, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(602, 73);
            this.button1.TabIndex = 16;
            this.button1.Text = "Начать удалять приглашения!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(568, 329);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 18;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-14, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 73);
            this.label2.TabIndex = 19;
            this.label2.Text = "Количество";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(106, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(-6, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(-3, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "вашего сообщества";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(-3, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "ошибок:";
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
            this.Button_Exit.Location = new System.Drawing.Point(556, -4);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(44, 45);
            this.Button_Exit.TabIndex = 26;
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
            this.Minimize_Button.Location = new System.Drawing.Point(515, -4);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(41, 45);
            this.Minimize_Button.TabIndex = 27;
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
            this.ORG.Location = new System.Drawing.Point(-3, 1);
            this.ORG.Name = "ORG";
            this.ORG.Size = new System.Drawing.Size(408, 40);
            this.ORG.TabIndex = 24;
            this.ORG.Text = "УДАЛИТЬ ПРИГЛАШЕНИЯ";
            this.ORG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.ORG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.ORG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // WindowHalfBorder
            // 
            this.WindowHalfBorder.BackColor = System.Drawing.Color.SteelBlue;
            this.WindowHalfBorder.Location = new System.Drawing.Point(-189, -3);
            this.WindowHalfBorder.Name = "WindowHalfBorder";
            this.WindowHalfBorder.Size = new System.Drawing.Size(790, 44);
            this.WindowHalfBorder.TabIndex = 25;
            this.WindowHalfBorder.TabStop = false;
            this.WindowHalfBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.WindowHalfBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.WindowHalfBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // FADER
            // 
            this.FADER.Interval = 1;
            this.FADER.Tick += new System.EventHandler(this.FADER_Tick);
            // 
            // FADERMINI
            // 
            this.FADERMINI.Interval = 1;
            this.FADERMINI.Tick += new System.EventHandler(this.FADERMINI_Tick);
            // 
            // FADERSTART
            // 
            this.FADERSTART.Interval = 1;
            this.FADERSTART.Tick += new System.EventHandler(this.FADERSTART_Tick);
            // 
            // prigl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.ORG);
            this.Controls.Add(this.WindowHalfBorder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "prigl";
            this.Text = "prigl";
            this.Load += new System.EventHandler(this.prigl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Label ORG;
        private System.Windows.Forms.PictureBox WindowHalfBorder;
        private System.Windows.Forms.Timer FADER;
        private System.Windows.Forms.Timer FADERMINI;
        private System.Windows.Forms.Timer FADERSTART;
    }
}