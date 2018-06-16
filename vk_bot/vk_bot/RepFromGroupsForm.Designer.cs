namespace vk_bot
{
    partial class RepFromGroupsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepFromGroupsForm));
            this.ButtonRep = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxShName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxREP2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.WindowHalfBorder = new System.Windows.Forms.PictureBox();
            this.ORG = new System.Windows.Forms.Label();
            this.FADER = new System.Windows.Forms.Timer(this.components);
            this.FADERSTART = new System.Windows.Forms.Timer(this.components);
            this.FADERMINI = new System.Windows.Forms.Timer(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRep
            // 
            this.ButtonRep.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonRep.FlatAppearance.BorderSize = 0;
            this.ButtonRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.ButtonRep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonRep.Location = new System.Drawing.Point(-30, 594);
            this.ButtonRep.Name = "ButtonRep";
            this.ButtonRep.Size = new System.Drawing.Size(731, 105);
            this.ButtonRep.TabIndex = 7;
            this.ButtonRep.Text = "Репост";
            this.ButtonRep.UseVisualStyleBackColor = false;
            this.ButtonRep.Click += new System.EventHandler(this.buttonRep_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(617, 633);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 8;
            // 
            // textBoxShName
            // 
            this.textBoxShName.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxShName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxShName.Location = new System.Drawing.Point(0, 135);
            this.textBoxShName.Name = "textBoxShName";
            this.textBoxShName.Size = new System.Drawing.Size(701, 24);
            this.textBoxShName.TabIndex = 9;
            this.textBoxShName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ссылка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-5, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "на НЕ вашу группу, из которой будет взят пост";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-10, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 55);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(-5, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "вашей группы , на которой будет пост";
            // 
            // textBoxREP2
            // 
            this.textBoxREP2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxREP2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxREP2.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxREP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxREP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxREP2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxREP2.Location = new System.Drawing.Point(0, 384);
            this.textBoxREP2.Name = "textBoxREP2";
            this.textBoxREP2.Size = new System.Drawing.Size(701, 24);
            this.textBoxREP2.TabIndex = 14;
            this.textBoxREP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 432);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(701, 156);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.Minimize_Button.Location = new System.Drawing.Point(616, -6);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(41, 49);
            this.Minimize_Button.TabIndex = 20;
            this.Minimize_Button.Text = "_";
            this.Minimize_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize_Button.UseVisualStyleBackColor = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
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
            this.Button_Exit.Location = new System.Drawing.Point(657, -1);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(44, 44);
            this.Button_Exit.TabIndex = 19;
            this.Button_Exit.Text = "x";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // WindowHalfBorder
            // 
            this.WindowHalfBorder.BackColor = System.Drawing.Color.SteelBlue;
            this.WindowHalfBorder.Location = new System.Drawing.Point(-6, -1);
            this.WindowHalfBorder.Name = "WindowHalfBorder";
            this.WindowHalfBorder.Size = new System.Drawing.Size(802, 44);
            this.WindowHalfBorder.TabIndex = 18;
            this.WindowHalfBorder.TabStop = false;
            this.WindowHalfBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowHalfBorder_MouseDown);
            this.WindowHalfBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowHalfBorder_MouseMove);
            this.WindowHalfBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowHalfBorder_MouseUp);
            // 
            // ORG
            // 
            this.ORG.AutoSize = true;
            this.ORG.BackColor = System.Drawing.Color.SteelBlue;
            this.ORG.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ORG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ORG.Location = new System.Drawing.Point(-3, 1);
            this.ORG.Name = "ORG";
            this.ORG.Size = new System.Drawing.Size(325, 40);
            this.ORG.TabIndex = 21;
            this.ORG.Text = "РЕПОСТ ИЗ ГРУППЫ";
            this.ORG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowHalfBorder_MouseDown);
            this.ORG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowHalfBorder_MouseMove);
            this.ORG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowHalfBorder_MouseUp);
            // 
            // FADER
            // 
            this.FADER.Interval = 1;
            this.FADER.Tick += new System.EventHandler(this.FADER_Tick);
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
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 182);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(701, 78);
            this.listBox2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(701, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "получить список постов";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RepFromGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ORG);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.WindowHalfBorder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxREP2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxShName);
            this.Controls.Add(this.ButtonRep);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "RepFromGroupsForm";
            this.Opacity = 0D;
            this.Text = "RepFromGroupsForm";
            this.Load += new System.EventHandler(this.RepFromGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRep;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBoxShName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxREP2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.PictureBox WindowHalfBorder;
        private System.Windows.Forms.Label ORG;
        private System.Windows.Forms.Timer FADER;
        private System.Windows.Forms.Timer FADERSTART;
        private System.Windows.Forms.Timer FADERMINI;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
    }
}