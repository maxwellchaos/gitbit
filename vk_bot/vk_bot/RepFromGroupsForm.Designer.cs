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
            this.ButtonRep = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxShName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxREP2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonRep
            // 
            this.ButtonRep.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonRep.FlatAppearance.BorderSize = 0;
            this.ButtonRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRep.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.ButtonRep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonRep.Location = new System.Drawing.Point(-17, 411);
            this.ButtonRep.Name = "ButtonRep";
            this.ButtonRep.Size = new System.Drawing.Size(722, 105);
            this.ButtonRep.TabIndex = 7;
            this.ButtonRep.Text = "Репост";
            this.ButtonRep.UseVisualStyleBackColor = false;
            this.ButtonRep.Click += new System.EventHandler(this.buttonRep_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(543, 149);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(94, 68);
            this.webBrowser1.TabIndex = 8;
            // 
            // textBoxShName
            // 
            this.textBoxShName.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShName.Location = new System.Drawing.Point(12, 110);
            this.textBoxShName.Name = "textBoxShName";
            this.textBoxShName.Size = new System.Drawing.Size(625, 33);
            this.textBoxShName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 57);
            this.label1.TabIndex = 10;
            this.label1.Text = "Short name\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "НЕ вашей группы, из которой будет взят пост";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 57);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "вашей группы , на которой будет пост";
            // 
            // textBoxREP2
            // 
            this.textBoxREP2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxREP2.Location = new System.Drawing.Point(12, 223);
            this.textBoxREP2.Name = "textBoxREP2";
            this.textBoxREP2.Size = new System.Drawing.Size(625, 33);
            this.textBoxREP2.TabIndex = 14;
            // 
            // RepFromGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(649, 510);
            this.Controls.Add(this.textBoxREP2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxShName);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ButtonRep);
            this.Name = "RepFromGroupsForm";
            this.Text = "RepFromGroupsForm";
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
    }
}