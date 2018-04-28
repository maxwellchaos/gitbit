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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.delete_wall_post = new System.Windows.Forms.Button();
            this.spam = new System.Windows.Forms.Button();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFirstName.Location = new System.Drawing.Point(12, 303);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(41, 23);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "имя";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLastName.Location = new System.Drawing.Point(12, 326);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(165, 37);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "фамилия";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonChangeStatus.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonChangeStatus.FlatAppearance.BorderSize = 0;
            this.buttonChangeStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonChangeStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeStatus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeStatus.Image = global::vk_bot.Properties.Resources._10;
            this.buttonChangeStatus.Location = new System.Drawing.Point(600, 0);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(150, 150);
            this.buttonChangeStatus.TabIndex = 6;
            this.buttonChangeStatus.Text = "Авто-смена статуса";
            this.buttonChangeStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonChangeStatus.UseVisualStyleBackColor = false;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            // 
            // delete_wall_post
            // 
            this.delete_wall_post.BackColor = System.Drawing.Color.SteelBlue;
            this.delete_wall_post.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.delete_wall_post.FlatAppearance.BorderSize = 0;
            this.delete_wall_post.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.delete_wall_post.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.delete_wall_post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_wall_post.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_wall_post.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_wall_post.Image = global::vk_bot.Properties.Resources._11;
            this.delete_wall_post.Location = new System.Drawing.Point(300, 0);
            this.delete_wall_post.Name = "delete_wall_post";
            this.delete_wall_post.Size = new System.Drawing.Size(150, 150);
            this.delete_wall_post.TabIndex = 5;
            this.delete_wall_post.Text = "Удаление записей со стены";
            this.delete_wall_post.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.delete_wall_post.UseVisualStyleBackColor = false;
            // 
            // spam
            // 
            this.spam.BackColor = System.Drawing.Color.SteelBlue;
            this.spam.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.spam.FlatAppearance.BorderSize = 0;
            this.spam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.spam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.spam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spam.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spam.Image = global::vk_bot.Properties.Resources._14;
            this.spam.Location = new System.Drawing.Point(450, 0);
            this.spam.Name = "spam";
            this.spam.Size = new System.Drawing.Size(150, 150);
            this.spam.TabIndex = 4;
            this.spam.Text = "Спам";
            this.spam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.spam.UseVisualStyleBackColor = false;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 2;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(752, 502);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.delete_wall_post);
            this.Controls.Add(this.spam);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.webBrowser1);
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
        private System.Windows.Forms.Button spam;
        private System.Windows.Forms.Button delete_wall_post;
        private System.Windows.Forms.Button buttonChangeStatus;
    }
}

