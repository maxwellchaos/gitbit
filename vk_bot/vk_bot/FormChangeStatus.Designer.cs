namespace vk_bot
{
    partial class FormChangeStatus
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangeStatusOK = new System.Windows.Forms.Button();
            this.webBrowserCST = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2018, 4, 5, 0, 0, 0, 0);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFirstName.Location = new System.Drawing.Point(12, 14);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(64, 23);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Статус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время";
            // 
            // buttonChangeStatusOK
            // 
            this.buttonChangeStatusOK.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonChangeStatusOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeStatusOK.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeStatusOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeStatusOK.Location = new System.Drawing.Point(16, 115);
            this.buttonChangeStatusOK.Name = "buttonChangeStatusOK";
            this.buttonChangeStatusOK.Size = new System.Drawing.Size(317, 36);
            this.buttonChangeStatusOK.TabIndex = 7;
            this.buttonChangeStatusOK.Text = "ОК";
            this.buttonChangeStatusOK.UseVisualStyleBackColor = false;
            this.buttonChangeStatusOK.Click += new System.EventHandler(this.buttonChangeStatusOK_Click);
            // 
            // webBrowserCST
            // 
            this.webBrowserCST.Location = new System.Drawing.Point(339, 14);
            this.webBrowserCST.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserCST.Name = "webBrowserCST";
            this.webBrowserCST.Size = new System.Drawing.Size(259, 137);
            this.webBrowserCST.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(621, 157);
            this.Controls.Add(this.webBrowserCST);
            this.Controls.Add(this.buttonChangeStatusOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormChangeStatus";
            this.Text = "FormChangeStatus";
            this.Load += new System.EventHandler(this.FormChangeStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangeStatusOK;
        private System.Windows.Forms.WebBrowser webBrowserCST;
        private System.Windows.Forms.Timer timer1;
    }
}