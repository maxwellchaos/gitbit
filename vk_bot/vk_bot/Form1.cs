using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace vk_bot
{
    public partial class Form1 : Form
    {
        public string access_token;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.BringToFront();
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=6410347&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends,photos,audio,video,docs,notes,pages,status,offers,questions,wall,groups,messages,notifications,stats,ads,market,offline&response_type=token&v=5.73");
       
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

        private void mass_laik_Click(object sender, EventArgs e)
        {
            wallskanform newForm = new wallskanform();
            newForm.access_token = access_token;
            newForm.Show();
        }

        private void delprigl_Click(object sender, EventArgs e)
        {
            prigl newForm = new prigl();
            newForm.access_token = access_token;
            newForm.Show();
        }

        private void egroup_Click(object sender, EventArgs e)
        {
            delgroups newForm = new delgroups();
            newForm.access_token = access_token;
            newForm.Show();
        }

        private void buttonПОЗДР_Click(object sender, EventArgs e)
        {
            FormSPAM q = new FormSPAM();
            q.access_token = access_token;
            q.Show();
        }

        private void but_exitgroups_MouseEnter(object sender, EventArgs e)
        {
            but_exitgroups.FlatAppearance.BorderSize = 2;
        }

        private void but_laik_MouseEnter(object sender, EventArgs e)
        {
            but_laik.FlatAppearance.BorderSize = 2;
        }

        private void but_delprigla_MouseEnter(object sender, EventArgs e)
        {
            but_delprigla.FlatAppearance.BorderSize = 2;
        }

        private void but_exitgroups_MouseLeave(object sender, EventArgs e)
        {
            but_exitgroups.FlatAppearance.BorderSize = 0;
        }

        private void but_laik_MouseLeave(object sender, EventArgs e)
        {
            but_laik.FlatAppearance.BorderSize = 0;
        }

        private void but_delprigla_MouseLeave(object sender, EventArgs e)
        {
            but_delprigla.FlatAppearance.BorderSize = 0;
        }

        private void delete_wall_post_Click(object sender, EventArgs e)
        {

        }
    }
}
