namespace vk_bot
{
    partial class DebugOK
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
            this.ButtonDebOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.WindowHalfBorder = new System.Windows.Forms.PictureBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.FADERMINI = new System.Windows.Forms.Timer(this.components);
            this.FADERSTART = new System.Windows.Forms.Timer(this.components);
            this.FADER = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonDebOK
            // 
            this.ButtonDebOK.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonDebOK.FlatAppearance.BorderSize = 0;
            this.ButtonDebOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDebOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.ButtonDebOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonDebOK.Location = new System.Drawing.Point(-2, 157);
            this.ButtonDebOK.Name = "ButtonDebOK";
            this.ButtonDebOK.Size = new System.Drawing.Size(425, 84);
            this.ButtonDebOK.TabIndex = 8;
            this.ButtonDebOK.Text = "OK";
            this.ButtonDebOK.UseVisualStyleBackColor = false;
            this.ButtonDebOK.Click += new System.EventHandler(this.ButtonDebOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(158, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Готово!";
            // 
            // WindowHalfBorder
            // 
            this.WindowHalfBorder.BackColor = System.Drawing.Color.SteelBlue;
            this.WindowHalfBorder.Location = new System.Drawing.Point(-2, -1);
            this.WindowHalfBorder.Name = "WindowHalfBorder";
            this.WindowHalfBorder.Size = new System.Drawing.Size(425, 44);
            this.WindowHalfBorder.TabIndex = 15;
            this.WindowHalfBorder.TabStop = false;
            this.WindowHalfBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowHalfBorder_MouseDown);
            this.WindowHalfBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowHalfBorder_MouseMove);
            this.WindowHalfBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowHalfBorder_MouseUp);
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
            this.Button_Exit.Location = new System.Drawing.Point(379, -1);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(44, 40);
            this.Button_Exit.TabIndex = 16;
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
            this.Minimize_Button.Location = new System.Drawing.Point(336, -6);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(41, 45);
            this.Minimize_Button.TabIndex = 17;
            this.Minimize_Button.Text = "_";
            this.Minimize_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize_Button.UseVisualStyleBackColor = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
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
            // FADER
            // 
            this.FADER.Interval = 1;
            this.FADER.Tick += new System.EventHandler(this.FADER_Tick);
            // 
            // DebugOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(422, 240);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.WindowHalfBorder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonDebOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DebugOK";
            this.Text = "DebugOK";
            this.Load += new System.EventHandler(this.DebugOK_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DebugOK_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDebOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox WindowHalfBorder;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Timer FADERMINI;
        private System.Windows.Forms.Timer FADERSTART;
        private System.Windows.Forms.Timer FADER;
    }
}