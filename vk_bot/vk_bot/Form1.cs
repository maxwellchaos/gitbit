using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Text;

namespace vk_bot
{
    public partial class Form1 : Form
    {
        public string access_token;

        public Form1()
        {
            InitializeComponent();
            fontsProjects();
            fonts();
        }

        PrivateFontCollection font;
        private void fontsProjects()
        {
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("FONTS/RLL.ttf");
            this.font.AddFontFile("FONTS/WS.ttf");



        }
        private void fonts()
        {
            labelLastName.Font = new Font(font.Families[0], 24);
            ORG.Font = new Font(font.Families[0], 24);
            labelFirstName.Font = new Font(font.Families[0], 18);
            delete_wall_post.Font = new Font(font.Families[0], 10);
            spam.Font = new Font(font.Families[0], 14);
            buttonChangeStatus.Font = new Font(font.Families[0], 10);
            RepFromGroupBTN.Font =  new Font(font.Families[0], 10);

        }






        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=6410347&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends+status+wall&response_type=token&v=5.73");
       
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = e.Url.ToString();
            if (url.Contains("error"))
            {
                MessageBox.Show("Ошибка");
            }
            if (url.Contains("access_token"))
            {
                //Выделяю access_token
                int IndexAccTok = url.IndexOf("access_token");
                access_token = url.Remove(0, IndexAccTok + 13);
                int IndexAmp = access_token.IndexOf("&");
                access_token = access_token.Remove(IndexAmp);

                //Зпрашиваю информацию о пользователе
                
                //Создаю XML документ
                XmlDocument doc = new XmlDocument();
                doc.Load("https://api.vk.com/method/users.get.xml?fields=photo_100&access_token="+access_token+"&v=5.73");
                XmlNode response = doc.SelectSingleNode("response");
                XmlNode user = response.SelectSingleNode("user");

                

                XmlNode FirstName = user.SelectSingleNode("first_name");
                labelFirstName.Text = FirstName.InnerText;
             
                XmlNode LastName = user.SelectSingleNode("last_name");
                labelLastName.Text = LastName.InnerText;

                pictureBoxAvatar.ImageLocation = user.SelectSingleNode("photo_100").InnerText;
                webBrowser1.Visible = false;
            }

        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            FormChangeStatus FRM3 = new FormChangeStatus();
            FRM3.ACT2 = access_token;
            FRM3.Show();
            
        }

        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {

        }

        private void delete_wall_post_MouseEnter(object sender, EventArgs e)
        {
            delete_wall_post.FlatAppearance.BorderSize = 2;
        }

        private void delete_wall_post_MouseLeave(object sender, EventArgs e)
        {
            delete_wall_post.FlatAppearance.BorderSize = 0;

        }

        private void spam_MouseEnter(object sender, EventArgs e)
        {
            spam.FlatAppearance.BorderSize = 2;

        }

        private void spam_MouseLeave(object sender, EventArgs e)
        {
            spam.FlatAppearance.BorderSize = 0;

        }

        private void buttonChangeStatus_MouseEnter(object sender, EventArgs e)
        {
            buttonChangeStatus.FlatAppearance.BorderSize = 2;

        }

        private void buttonChangeStatus_MouseLeave(object sender, EventArgs e)
        {
            buttonChangeStatus.FlatAppearance.BorderSize = 0;

        }

        private void spam_Click(object sender, EventArgs e)
        {
            FormSpam_DR T = new FormSpam_DR();
            T.access_token = access_token;
            T.Show();
        }

        private void RepFromGroupBTN_Click(object sender, EventArgs e)
        {
            RepFromGroupsForm FRM4 = new RepFromGroupsForm();
            FRM4.ACT3 = access_token;
            FRM4.Show();
        }

        private void RepFromGroupBTN_MouseLeave(object sender, EventArgs e)
        {
            RepFromGroupBTN.FlatAppearance.BorderSize = 0;
        }

        private void RepFromGroupBTN_MouseEnter(object sender, EventArgs e)
        {
            RepFromGroupBTN.FlatAppearance.BorderSize = 2;

        }

 
    }
}
