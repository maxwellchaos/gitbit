namespace vk_bot
{
    partial class _123
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
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
            this.textBox1.Location = new System.Drawing.Point(-2, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 177);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Location = new System.Drawing.Point(-2, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(608, 28);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Введите id группы в которую надо приглашать";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-2, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(608, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "начать приглашать друзей";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 

            this.webBrowser1.Location = new System.Drawing.Point(12, 292);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(420, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 98);
            this.label1.TabIndex = 8;
            this.label1.Text = "Не во все группы, сообщества и паблики можно приглашать друзей! Когда копируешь i" +
                "d, проверь можно ли в это сообщество приглашать друзей или нет.";
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
            this.Button_Exit.Location = new System.Drawing.Point(557, -1);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(44, 45);
            this.Button_Exit.TabIndex = 31;
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
            this.Minimize_Button.Location = new System.Drawing.Point(517, -1);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(41, 45);
            this.Minimize_Button.TabIndex = 32;
            this.Minimize_Button.Text = "_";
            this.Minimize_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize_Button.UseVisualStyleBackColor = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // ORG
            // 
            this.ORG.AutoSize = true;
            this.ORG.BackColor = System.Drawing.Color.SteelBlue;
            this.ORG.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ORG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ORG.Location = new System.Drawing.Point(-2, 4);
            this.ORG.Name = "ORG";
            this.ORG.Size = new System.Drawing.Size(489, 37);
            this.ORG.TabIndex = 29;
            this.ORG.Text = "ПРИГЛАШЕНИЕ ДРУЗЕЙ В ГРУППУ";
            this.ORG.Click += new System.EventHandler(this.ORG_Click);
            this.ORG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.ORG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.ORG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // WindowHalfBorder
            // 
            this.WindowHalfBorder.BackColor = System.Drawing.Color.SteelBlue;
            this.WindowHalfBorder.Location = new System.Drawing.Point(-188, 0);
            this.WindowHalfBorder.Name = "WindowHalfBorder";
            this.WindowHalfBorder.Size = new System.Drawing.Size(790, 44);
            this.WindowHalfBorder.TabIndex = 30;
            this.WindowHalfBorder.TabStop = false;
            this.WindowHalfBorder.Click += new System.EventHandler(this.WindowHalfBorder_Click);
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
            // _123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.Controls.Add(this.label1);


            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(601, 365);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.ORG);
            this.Controls.Add(this.WindowHalfBorder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_123";
            this.Text = "_123";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this._123_Load);
            this.Click += new System.EventHandler(this._123_Click);
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Label ORG;
        private System.Windows.Forms.PictureBox WindowHalfBorder;
        private System.Windows.Forms.Timer FADER;
        private System.Windows.Forms.Timer FADERMINI;
        private System.Windows.Forms.Timer FADERSTART;

    }
}