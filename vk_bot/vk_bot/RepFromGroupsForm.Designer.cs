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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepFromGroupsForm));
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
            this.ButtonRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
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
            this.webBrowser1.Location = new System.Drawing.Point(633, 411);
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
            this.textBoxShName.Location = new System.Drawing.Point(0, 110);
            this.textBoxShName.Name = "textBoxShName";
            this.textBoxShName.Size = new System.Drawing.Size(653, 24);
            this.textBoxShName.TabIndex = 9;
            this.textBoxShName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Short name\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-5, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(588, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "НЕ вашей группы, из которой будет взят пост";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-10, 180);
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
            this.label4.Location = new System.Drawing.Point(-5, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "вашей группы , на которой будет пост";
            // 
            // textBoxREP2
            // 
            this.textBoxREP2.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxREP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxREP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxREP2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxREP2.Location = new System.Drawing.Point(0, 267);
            this.textBoxREP2.Name = "textBoxREP2";
            this.textBoxREP2.Size = new System.Drawing.Size(653, 24);
            this.textBoxREP2.TabIndex = 14;
            this.textBoxREP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Controls.Add(this.ButtonRep);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(665, 549);
            this.MinimumSize = new System.Drawing.Size(665, 549);
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