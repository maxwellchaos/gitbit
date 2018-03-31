namespace vk_bot
{
    partial class SLOVA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CITY = new System.Windows.Forms.RadioButton();
            this.NAMEEEEEEE = new System.Windows.Forms.RadioButton();
            this.START = new System.Windows.Forms.Button();
            this.IGRULKI = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NAMEEEEEEE);
            this.panel1.Controls.Add(this.CITY);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 79);
            this.panel1.TabIndex = 0;
            // 
            // CITY
            // 
            this.CITY.Checked = true;
            this.CITY.Location = new System.Drawing.Point(12, 25);
            this.CITY.Name = "CITY";
            this.CITY.Size = new System.Drawing.Size(104, 24);
            this.CITY.TabIndex = 0;
            this.CITY.TabStop = true;
            this.CITY.Text = "Города";
            this.CITY.UseVisualStyleBackColor = true;
            // 
            // NAMEEEEEEE
            // 
            this.NAMEEEEEEE.Dock = System.Windows.Forms.DockStyle.Right;
            this.NAMEEEEEEE.Location = new System.Drawing.Point(451, 0);
            this.NAMEEEEEEE.Name = "NAMEEEEEEE";
            this.NAMEEEEEEE.Size = new System.Drawing.Size(85, 79);
            this.NAMEEEEEEE.TabIndex = 1;
            this.NAMEEEEEEE.Text = "Имена";
            this.NAMEEEEEEE.UseVisualStyleBackColor = true;
            this.NAMEEEEEEE.CheckedChanged += new System.EventHandler(this.NAMEEEEEEE_CheckedChanged);
            // 
            // START
            // 
            this.START.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.START.Location = new System.Drawing.Point(0, 262);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(536, 23);
            this.START.TabIndex = 1;
            this.START.Text = "Старт";
            this.START.UseVisualStyleBackColor = true;
            // 
            // IGRULKI
            // 
            this.IGRULKI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IGRULKI.Location = new System.Drawing.Point(0, 79);
            this.IGRULKI.Multiline = true;
            this.IGRULKI.Name = "IGRULKI";
            this.IGRULKI.Size = new System.Drawing.Size(536, 183);
            this.IGRULKI.TabIndex = 2;
            // 
            // SLOVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 285);
            this.Controls.Add(this.IGRULKI);
            this.Controls.Add(this.START);
            this.Controls.Add(this.panel1);
            this.Name = "SLOVA";
            this.Text = "SLOVA";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton NAMEEEEEEE;
        private System.Windows.Forms.RadioButton CITY;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.TextBox IGRULKI;
    }
}