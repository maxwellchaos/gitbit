namespace vk_bot
{
    partial class Form1
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.mass_laik = new System.Windows.Forms.Button();
            this.egroup = new System.Windows.Forms.Button();
            this.delprigl = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(58, 123);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "label1";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(58, 143);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(57, 20);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "label2";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(25, 14);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(135, 106);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAvatar.TabIndex = 2;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-7, 487);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // mass_laik
            // 
            this.mass_laik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mass_laik.Location = new System.Drawing.Point(208, 14);
            this.mass_laik.Name = "mass_laik";
            this.mass_laik.Size = new System.Drawing.Size(285, 41);
            this.mass_laik.TabIndex = 6;
            this.mass_laik.Text = "Массовый лайкинг";
            this.mass_laik.UseVisualStyleBackColor = true;
            this.mass_laik.Click += new System.EventHandler(this.mass_laik_Click);
            // 
            // egroup
            // 
            this.egroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egroup.Location = new System.Drawing.Point(208, 79);
            this.egroup.Name = "egroup";
            this.egroup.Size = new System.Drawing.Size(285, 41);
            this.egroup.TabIndex = 7;
            this.egroup.Text = "Выход из групп";
            this.egroup.UseVisualStyleBackColor = true;
            this.egroup.Click += new System.EventHandler(this.egroup_Click);
            // 
            // delprigl
            // 
            this.delprigl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delprigl.Location = new System.Drawing.Point(208, 142);
            this.delprigl.Name = "delprigl";
            this.delprigl.Size = new System.Drawing.Size(285, 41);
            this.delprigl.TabIndex = 8;
            this.delprigl.Text = " Удаление всех приглашений";
            this.delprigl.UseVisualStyleBackColor = true;
            this.delprigl.Click += new System.EventHandler(this.delprigl_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(25, 200);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(672, 117);
            this.webBrowser2.TabIndex = 9;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 202);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.delprigl);
            this.Controls.Add(this.egroup);
            this.Controls.Add(this.mass_laik);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.MaximumSize = new System.Drawing.Size(528, 241);
            this.MinimumSize = new System.Drawing.Size(528, 241);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button mass_laik;
        private System.Windows.Forms.Button egroup;
        private System.Windows.Forms.Button delprigl;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}

