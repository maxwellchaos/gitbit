﻿namespace vk_bot
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

            this.buttonПОЗДР = new System.Windows.Forms.Button();
            this.ORG = new System.Windows.Forms.Label();
            this.spam = new System.Windows.Forms.Button();
            this.delete_wall_post = new System.Windows.Forms.Button();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.but_exitgroups = new System.Windows.Forms.Button();
            this.but_delprigla = new System.Windows.Forms.Button();
            this.but_laik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonПОЗДР
            // 
            this.buttonПОЗДР.Location = new System.Drawing.Point(306, 229);
            this.buttonПОЗДР.Name = "buttonПОЗДР";
            this.buttonПОЗДР.Size = new System.Drawing.Size(159, 45);
            this.buttonПОЗДР.TabIndex = 12;
            this.buttonПОЗДР.Text = "Поздравление с ДР";
            this.buttonПОЗДР.UseVisualStyleBackColor = true;
            this.buttonПОЗДР.Click += new System.EventHandler(this.buttonПОЗДР_Click);
            // 
            // ORG
            // 
            this.ORG.AutoSize = true;
            this.ORG.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ORG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ORG.Location = new System.Drawing.Point(12, 9);
            this.ORG.Name = "ORG";
            this.ORG.Size = new System.Drawing.Size(266, 40);
            this.ORG.TabIndex = 7;
            this.ORG.Text = "VK_TUMBOCHKA";
            // 
            // spam
            // 
            this.spam.BackColor = System.Drawing.Color.SteelBlue;
            this.spam.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.spam.FlatAppearance.BorderSize = 0;
            this.spam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.spam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.spam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spam.Image = global::vk_bot.Properties.Resources._14;
            this.spam.Location = new System.Drawing.Point(462, 54);
            this.spam.Name = "spam";
            this.spam.Size = new System.Drawing.Size(150, 150);
            this.spam.TabIndex = 4;
            this.spam.Text = "Спам";
            this.spam.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.spam.UseVisualStyleBackColor = false;
            this.spam.Click += new System.EventHandler(this.spam_Click);
            this.spam.MouseEnter += new System.EventHandler(this.spam_MouseEnter);
            this.spam.MouseLeave += new System.EventHandler(this.spam_MouseLeave);
            // 
            // delete_wall_post
            // 
            this.delete_wall_post.BackColor = System.Drawing.Color.SteelBlue;
            this.delete_wall_post.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.delete_wall_post.FlatAppearance.BorderSize = 0;
            this.delete_wall_post.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.delete_wall_post.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.delete_wall_post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_wall_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_wall_post.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_wall_post.Image = global::vk_bot.Properties.Resources._11;
            this.delete_wall_post.Location = new System.Drawing.Point(308, 54);
            this.delete_wall_post.Name = "delete_wall_post";
            this.delete_wall_post.Size = new System.Drawing.Size(150, 150);
            this.delete_wall_post.TabIndex = 5;
            this.delete_wall_post.Text = "Удаление записей со стены";
            this.delete_wall_post.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.delete_wall_post.UseVisualStyleBackColor = false;
            this.delete_wall_post.MouseEnter += new System.EventHandler(this.delete_wall_post_MouseEnter);
            this.delete_wall_post.MouseLeave += new System.EventHandler(this.delete_wall_post_MouseLeave);
            // 

            // buttonChangeStatus
            //
            this.buttonChangeStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonChangeStatus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonChangeStatus.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.buttonChangeStatus.FlatAppearance.BorderSize = 0;
            this.buttonChangeStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonChangeStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.buttonChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeStatus.Image = global::vk_bot.Properties.Resources._10;

            this.buttonChangeStatus.Location = new System.Drawing.Point(616, 54);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(150, 150);
            this.buttonChangeStatus.TabIndex = 6;
            this.buttonChangeStatus.Text = "Авто-смена статуса";
            this.buttonChangeStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonChangeStatus.UseVisualStyleBackColor = false;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            this.buttonChangeStatus.MouseEnter += new System.EventHandler(this.buttonChangeStatus_MouseEnter);
            this.buttonChangeStatus.MouseLeave += new System.EventHandler(this.buttonChangeStatus_MouseLeave);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(284, 62);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 142);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLastName.Location = new System.Drawing.Point(-3, 357);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(165, 37);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "фамилия";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFirstName.Location = new System.Drawing.Point(0, 394);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(47, 24);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "имя";
            // 

            // pictureBoxAvatar
            //
            this.pictureBoxAvatar.Location = new System.Drawing.Point(4, 54);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 2;
            this.pictureBoxAvatar.TabStop = false;
            this.pictureBoxAvatar.Click += new System.EventHandler(this.pictureBoxAvatar_Click);

            // 
            // but_exitgroups
            // 
            this.but_exitgroups.BackColor = System.Drawing.Color.SteelBlue;
            this.but_exitgroups.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.but_exitgroups.FlatAppearance.BorderSize = 0;
            this.but_exitgroups.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.but_exitgroups.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.but_exitgroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_exitgroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_exitgroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_exitgroups.Location = new System.Drawing.Point(304, 298);
            this.but_exitgroups.Name = "but_exitgroups";
            this.but_exitgroups.Size = new System.Drawing.Size(150, 150);
            this.but_exitgroups.TabIndex = 18;
            this.but_exitgroups.Text = "Выход из всех групп";
            this.but_exitgroups.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.but_exitgroups.UseVisualStyleBackColor = false;
            this.but_exitgroups.Click += new System.EventHandler(this.egroup_Click);
            // 
            // but_delprigla
            // 
            this.but_delprigla.BackColor = System.Drawing.Color.SteelBlue;
            this.but_delprigla.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.but_delprigla.FlatAppearance.BorderSize = 0;
            this.but_delprigla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.but_delprigla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.but_delprigla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_delprigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_delprigla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_delprigla.Location = new System.Drawing.Point(616, 298);
            this.but_delprigla.Name = "but_delprigla";
            this.but_delprigla.Size = new System.Drawing.Size(150, 150);
            this.but_delprigla.TabIndex = 17;
            this.but_delprigla.Text = "Удаление приглашений";
            this.but_delprigla.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.but_delprigla.UseVisualStyleBackColor = false;
            this.but_delprigla.Click += new System.EventHandler(this.delprigl_Click);
            // 
            // but_laik
            // 
            this.but_laik.BackColor = System.Drawing.Color.SteelBlue;
            this.but_laik.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_laik.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.but_laik.FlatAppearance.BorderSize = 0;
            this.but_laik.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.but_laik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.but_laik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_laik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_laik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_laik.Location = new System.Drawing.Point(460, 298);
            this.but_laik.Name = "but_laik";
            this.but_laik.Size = new System.Drawing.Size(150, 150);
            this.but_laik.TabIndex = 16;
            this.but_laik.Text = "Массовый лайкинг";
            this.but_laik.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.but_laik.UseVisualStyleBackColor = false;
            this.but_laik.Click += new System.EventHandler(this.mass_laik_Click);
            // 

            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(771, 502);
            this.Controls.Add(this.but_exitgroups);
            this.Controls.Add(this.but_delprigla);
            this.Controls.Add(this.but_laik);
            this.Controls.Add(this.buttonПОЗДР);
            this.Controls.Add(this.ORG);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.buttonChangeStatus);

            this.ClientSize = new System.Drawing.Size(610, 502);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ya);

            this.Controls.Add(this.delete_wall_post);
            this.Controls.Add(this.spam);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.WebBrowser webBrowser1;

        private System.Windows.Forms.Button buttonПОЗДР;
        private System.Windows.Forms.Label ORG;
        private System.Windows.Forms.Button spam;
        private System.Windows.Forms.Button delete_wall_post;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Button but_exitgroups;
        private System.Windows.Forms.Button but_delprigla;
        private System.Windows.Forms.Button but_laik;

    }
}
