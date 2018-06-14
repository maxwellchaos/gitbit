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
            this.deletefriends = new System.Windows.Forms.Button();
            this.DeleteComments = new System.Windows.Forms.Button();
            this.ya = new System.Windows.Forms.Button();
            this.labelFriendsDelete = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCensure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(581, 42);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(35, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "label1";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(622, 42);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(35, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "label2";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(551, 67);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(157, 169);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 2;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(520, 577);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // deletefriends
            // 
            this.deletefriends.Location = new System.Drawing.Point(730, 28);
            this.deletefriends.Name = "deletefriends";
            this.deletefriends.Size = new System.Drawing.Size(159, 41);
            this.deletefriends.TabIndex = 4;
            this.deletefriends.Text = "Удалить Друга";
            this.deletefriends.UseVisualStyleBackColor = true;
            this.deletefriends.Click += new System.EventHandler(this.deletefriends_Click);
            // 
            // DeleteComments
            // 
            this.DeleteComments.Location = new System.Drawing.Point(730, 105);
            this.DeleteComments.Name = "DeleteComments";
            this.DeleteComments.Size = new System.Drawing.Size(159, 41);
            this.DeleteComments.TabIndex = 5;
            this.DeleteComments.Text = "Удалаять комментарии с нецензурной бранью";
            this.DeleteComments.UseVisualStyleBackColor = true;
            this.DeleteComments.Click += new System.EventHandler(this.DeleteComments_Click);
            // 
            // ya
            // 
            this.ya.Location = new System.Drawing.Point(730, 183);
            this.ya.Name = "ya";
            this.ya.Size = new System.Drawing.Size(159, 36);
            this.ya.TabIndex = 6;
            this.ya.Text = "я";
            this.ya.UseVisualStyleBackColor = true;
            this.ya.Click += new System.EventHandler(this.ya_Click);
            // 
            // labelFriendsDelete
            // 
            this.labelFriendsDelete.AutoSize = true;
            this.labelFriendsDelete.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsDelete.Location = new System.Drawing.Point(739, 72);
            this.labelFriendsDelete.Name = "labelFriendsDelete";
            this.labelFriendsDelete.Size = new System.Drawing.Size(53, 18);
            this.labelFriendsDelete.TabIndex = 7;
            this.labelFriendsDelete.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(584, 272);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 235);
            this.textBox1.TabIndex = 8;
            // 
            // labelCensure
            // 
            this.labelCensure.AutoSize = true;
            this.labelCensure.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCensure.Location = new System.Drawing.Point(742, 153);
            this.labelCensure.Name = "labelCensure";
            this.labelCensure.Size = new System.Drawing.Size(53, 18);
            this.labelCensure.TabIndex = 9;
            this.labelCensure.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 601);
            this.Controls.Add(this.labelCensure);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFriendsDelete);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ya);
            this.Controls.Add(this.DeleteComments);
            this.Controls.Add(this.deletefriends);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
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
        private System.Windows.Forms.Button deletefriends;
        private System.Windows.Forms.Button DeleteComments;
        private System.Windows.Forms.Button ya;
        private System.Windows.Forms.Label labelFriendsDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCensure;
    }
}

