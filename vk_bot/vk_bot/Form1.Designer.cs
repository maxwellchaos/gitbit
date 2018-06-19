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

            this.components = new System.ComponentModel.Container();
            this.buttonПОЗДР = new System.Windows.Forms.Button();
            this.ORG = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.but_delprigla = new System.Windows.Forms.Button();
            this.but_laik = new System.Windows.Forms.Button();
            this.but_exitgroups = new System.Windows.Forms.Button();
            this.RepFromGroupBTN = new System.Windows.Forms.Button();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.delete_wall_post = new System.Windows.Forms.Button();
            this.spam = new System.Windows.Forms.Button();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.WindowHalfBorder = new System.Windows.Forms.PictureBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.FADER = new System.Windows.Forms.Timer(this.components);
            this.FADERMINI = new System.Windows.Forms.Timer(this.components);
            this.FADERSTART = new System.Windows.Forms.Timer(this.components);
            this.buttonWelkom = new System.Windows.Forms.Button();
            this.delcom = new System.Windows.Forms.Button();
            this.SlovaIstini = new System.Windows.Forms.Button();
            this.deletefriends = new System.Windows.Forms.Button();
            this.DeleteComments = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).BeginInit();

            this.SuspendLayout();
            // 
            // buttonПОЗДР
            // 

            this.buttonПОЗДР.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonПОЗДР.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.buttonПОЗДР.FlatAppearance.BorderSize = 0;
            this.buttonПОЗДР.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonПОЗДР.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.buttonПОЗДР.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonПОЗДР.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonПОЗДР.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonПОЗДР.Location = new System.Drawing.Point(615, 353);
            this.buttonПОЗДР.Name = "buttonПОЗДР";
            this.buttonПОЗДР.Size = new System.Drawing.Size(150, 150);
            this.buttonПОЗДР.TabIndex = 12;
            this.buttonПОЗДР.Text = "Поздравление с ДР";
            this.buttonПОЗДР.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonПОЗДР.UseVisualStyleBackColor = false;
            this.buttonПОЗДР.Click += new System.EventHandler(this.buttonПОЗДР_Click);
            this.buttonПОЗДР.MouseEnter += new System.EventHandler(this.buttonПОЗДР_MouseEnter);
            this.buttonПОЗДР.MouseLeave += new System.EventHandler(this.buttonПОЗДР_MouseLeave);
            // 
            // ORG
            // 
            this.ORG.AutoSize = true;
            this.ORG.BackColor = System.Drawing.Color.SteelBlue;
            this.ORG.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ORG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ORG.Location = new System.Drawing.Point(-3, 1);
            this.ORG.Name = "ORG";
            this.ORG.Size = new System.Drawing.Size(266, 40);
            this.ORG.TabIndex = 7;
            this.ORG.Text = "VK_TUMBOCHKA";
            this.ORG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.ORG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.ORG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 538);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 25);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLastName.Location = new System.Drawing.Point(17, 405);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(98, 22);

            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "фамилия";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFirstName.Location = new System.Drawing.Point(12, 352);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(47, 24);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "имя";
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
            this.but_delprigla.Image = global::vk_bot.Properties.Resources._20;
            this.but_delprigla.Location = new System.Drawing.Point(307, 353);
            this.but_delprigla.Name = "but_delprigla";
            this.but_delprigla.Size = new System.Drawing.Size(150, 150);
            this.but_delprigla.TabIndex = 17;
            this.but_delprigla.Text = "Удаление приглашений";
            this.but_delprigla.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.but_delprigla.UseVisualStyleBackColor = false;
            this.but_delprigla.Click += new System.EventHandler(this.delprigl_Click);
            this.but_delprigla.MouseEnter += new System.EventHandler(this.but_delprigla_MouseEnter);
            this.but_delprigla.MouseLeave += new System.EventHandler(this.but_delprigla_MouseLeave);
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
            this.but_laik.Image = global::vk_bot.Properties.Resources._12;
            this.but_laik.Location = new System.Drawing.Point(616, 199);
            this.but_laik.Name = "but_laik";
            this.but_laik.Size = new System.Drawing.Size(150, 150);
            this.but_laik.TabIndex = 16;
            this.but_laik.Text = "Массовый лайкинг";
            this.but_laik.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.but_laik.UseVisualStyleBackColor = false;
            this.but_laik.Click += new System.EventHandler(this.mass_laik_Click);
            this.but_laik.MouseEnter += new System.EventHandler(this.but_laik_MouseEnter);
            this.but_laik.MouseLeave += new System.EventHandler(this.but_laik_MouseLeave);
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
            this.but_exitgroups.Image = global::vk_bot.Properties.Resources._30;
            this.but_exitgroups.Location = new System.Drawing.Point(462, 199);
            this.but_exitgroups.Name = "but_exitgroups";
            this.but_exitgroups.Size = new System.Drawing.Size(150, 150);
            this.but_exitgroups.TabIndex = 18;
            this.but_exitgroups.Text = "Выход из всех групп";
            this.but_exitgroups.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.but_exitgroups.UseVisualStyleBackColor = false;
            this.but_exitgroups.Click += new System.EventHandler(this.egroup_Click);
            this.but_exitgroups.MouseEnter += new System.EventHandler(this.but_exitgroups_MouseEnter_1);
            this.but_exitgroups.MouseLeave += new System.EventHandler(this.but_exitgroups_MouseLeave_1);
            // 
            // RepFromGroupBTN
            // 
            this.RepFromGroupBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.RepFromGroupBTN.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.RepFromGroupBTN.FlatAppearance.BorderSize = 0;
            this.RepFromGroupBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.RepFromGroupBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.RepFromGroupBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepFromGroupBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepFromGroupBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RepFromGroupBTN.Image = global::vk_bot.Properties.Resources._2222;
            this.RepFromGroupBTN.Location = new System.Drawing.Point(308, 199);
            this.RepFromGroupBTN.Name = "RepFromGroupBTN";
            this.RepFromGroupBTN.Size = new System.Drawing.Size(150, 150);
            this.RepFromGroupBTN.TabIndex = 8;
            this.RepFromGroupBTN.Text = "Репост записи из группы";
            this.RepFromGroupBTN.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RepFromGroupBTN.UseVisualStyleBackColor = false;
            this.RepFromGroupBTN.Click += new System.EventHandler(this.RepFromGroupBTN_Click);
            this.RepFromGroupBTN.MouseEnter += new System.EventHandler(this.RepFromGroupBTN_MouseEnter);
            this.RepFromGroupBTN.MouseLeave += new System.EventHandler(this.RepFromGroupBTN_MouseLeave);
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
            this.buttonChangeStatus.Location = new System.Drawing.Point(616, 45);
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
            this.delete_wall_post.Location = new System.Drawing.Point(308, 45);
            this.delete_wall_post.Name = "delete_wall_post";
            this.delete_wall_post.Size = new System.Drawing.Size(148, 150);
            this.delete_wall_post.TabIndex = 5;
            this.delete_wall_post.Text = "Удаление записей со стены";
            this.delete_wall_post.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.delete_wall_post.UseVisualStyleBackColor = false;
            this.delete_wall_post.Click += new System.EventHandler(this.delete_wall_post_Click);
            this.delete_wall_post.MouseEnter += new System.EventHandler(this.delete_wall_post_MouseEnter);
            this.delete_wall_post.MouseLeave += new System.EventHandler(this.delete_wall_post_MouseLeave);
            // 
            // delcom
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
            this.spam.Location = new System.Drawing.Point(462, 45);
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
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(12, 45);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(292, 304);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 2;
            this.pictureBoxAvatar.TabStop = false;
            this.pictureBoxAvatar.Click += new System.EventHandler(this.pictureBoxAvatar_Click);
            // 
            // WindowHalfBorder
            // 
            this.WindowHalfBorder.BackColor = System.Drawing.Color.SteelBlue;
            this.WindowHalfBorder.Location = new System.Drawing.Point(-6, -1);
            this.WindowHalfBorder.Name = "WindowHalfBorder";
            this.WindowHalfBorder.Size = new System.Drawing.Size(954, 44);
            this.WindowHalfBorder.TabIndex = 11;
            this.WindowHalfBorder.TabStop = false;
            this.WindowHalfBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.WindowHalfBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.WindowHalfBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
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
            this.Button_Exit.Location = new System.Drawing.Point(877, -4);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(44, 45);
            this.Button_Exit.TabIndex = 14;
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
            this.Minimize_Button.Location = new System.Drawing.Point(833, -4);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(41, 45);
            this.Minimize_Button.TabIndex = 15;
            this.Minimize_Button.Text = "_";
            this.Minimize_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize_Button.UseVisualStyleBackColor = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // FADER
            // 
            this.FADER.Interval = 1;
            this.FADER.Tick += new System.EventHandler(this.FADER_Tick);
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
            // buttonWelkom
            // 
            this.buttonWelkom.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonWelkom.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.buttonWelkom.FlatAppearance.BorderSize = 0;
            this.buttonWelkom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonWelkom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.buttonWelkom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWelkom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWelkom.ForeColor = System.Drawing.Color.White;
            this.buttonWelkom.Location = new System.Drawing.Point(461, 353);
            this.buttonWelkom.Name = "buttonWelkom";
            this.buttonWelkom.Size = new System.Drawing.Size(150, 150);
            this.buttonWelkom.TabIndex = 19;
            this.buttonWelkom.Text = "Приглашения в группу";
            this.buttonWelkom.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonWelkom.UseVisualStyleBackColor = false;
            this.buttonWelkom.Click += new System.EventHandler(this.buttonWelkom_Click);
            this.buttonWelkom.MouseEnter += new System.EventHandler(this.buttonWelkom_MouseEnter);
            this.buttonWelkom.MouseLeave += new System.EventHandler(this.buttonWelkom_MouseLeave);
            // 
            // delcom
            // 
            this.delcom.BackColor = System.Drawing.Color.SteelBlue;
            this.delcom.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.delcom.FlatAppearance.BorderSize = 0;
            this.delcom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.delcom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.delcom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delcom.ForeColor = System.Drawing.Color.White;
            this.delcom.Location = new System.Drawing.Point(771, 199);
            this.delcom.Name = "delcom";
            this.delcom.Size = new System.Drawing.Size(150, 150);
            this.delcom.TabIndex = 23;
            this.delcom.Text = "Удалять комментарии со ссылкой";
            this.delcom.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.delcom.UseVisualStyleBackColor = false;
            this.delcom.Click += new System.EventHandler(this.delcom_Click);
            // 
            // SlovaIstini
            // 
            this.SlovaIstini.BackColor = System.Drawing.Color.SteelBlue;
            this.SlovaIstini.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.SlovaIstini.FlatAppearance.BorderSize = 0;
            this.SlovaIstini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.SlovaIstini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.SlovaIstini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlovaIstini.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlovaIstini.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SlovaIstini.Location = new System.Drawing.Point(771, 45);
            this.SlovaIstini.Name = "SlovaIstini";
            this.SlovaIstini.Size = new System.Drawing.Size(150, 150);
            this.SlovaIstini.TabIndex = 22;
            this.SlovaIstini.Text = "Слова";
            this.SlovaIstini.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SlovaIstini.UseVisualStyleBackColor = false;
            this.SlovaIstini.Click += new System.EventHandler(this.SlovaIstini_Click);
            // 
            // deletefriends
            // 
            this.deletefriends.Location = new System.Drawing.Point(771, 414);
            this.deletefriends.Name = "deletefriends";
            this.deletefriends.Size = new System.Drawing.Size(159, 41);
            this.deletefriends.TabIndex = 4;
            this.deletefriends.Text = "Удалить Друга";
            this.deletefriends.UseVisualStyleBackColor = true;
            this.deletefriends.Click += new System.EventHandler(this.deletefriends_Click);
            // 
            // DeleteComments
            // 
            this.DeleteComments.Location = new System.Drawing.Point(771, 367);
            this.DeleteComments.Name = "DeleteComments";
            this.DeleteComments.Size = new System.Drawing.Size(159, 41);
            this.DeleteComments.TabIndex = 5;
            this.DeleteComments.Text = "Удалаять комментарии с нецензурной бранью";
            this.DeleteComments.UseVisualStyleBackColor = true;
            this.DeleteComments.Click += new System.EventHandler(this.DeleteComments_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(928, 522);
            this.Controls.Add(this.delcom);
            this.Controls.Add(this.SlovaIstini);
            this.Controls.Add(this.buttonWelkom);
            this.Controls.Add(this.but_exitgroups);
            this.Controls.Add(this.but_delprigla);
            this.Controls.Add(this.but_laik);
            this.Controls.Add(this.buttonПОЗДР);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.ORG);
            this.Controls.Add(this.WindowHalfBorder);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.RepFromGroupBTN);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.delete_wall_post);
            this.Controls.Add(this.spam);
            this.Controls.Add(this.DeleteComments);
            this.Controls.Add(this.deletefriends);
            this.Controls.Add(this.pictureBoxAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Name = "Form1";
            this.Text = "VK_TUMBOCHKA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowHalfBorder)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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


        private System.Windows.Forms.Button RepFromGroupBTN;
        private System.Windows.Forms.PictureBox WindowHalfBorder;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Timer FADER;
        private System.Windows.Forms.Timer FADERMINI;
        private System.Windows.Forms.Timer FADERSTART;
        private System.Windows.Forms.Button buttonWelkom;
        private System.Windows.Forms.Button delcom;
        private System.Windows.Forms.Button SlovaIstini;


        private System.Windows.Forms.Button deletefriends;
        private System.Windows.Forms.Button DeleteComments;

    }
}

