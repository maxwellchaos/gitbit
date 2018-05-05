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
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=6410347&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends+messages&response_type=token&v=5.74");       
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
                doc.Load("https://api.vk.com/method/account.getProfileInfo.xml?access_token=" + access_token + "&v=5.74");
                XmlNode response = doc.SelectSingleNode("response");

                XmlNode FirstName = response.SelectSingleNode("first_name");
                labelFirstName.Text = FirstName.InnerText;

                XmlNode LastName = response.SelectSingleNode("last_name");
                labelLastName.Text = LastName.InnerText;

                //pictureBoxAvatar.ImageLocation = response.SelectSingleNode("photo_100").InnerText;
                webBrowser1.Visible = false;
            }

        }

        private void spam_Click(object sender, EventArgs e)
        {
            FormDR T = new FormDR();
            T.access_token = access_token;
            T.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSPAM q = new FormSPAM();
            q.access_token = access_token;
            q.Show();
        }

        private void timerQwerty_Tick(object sender, EventArgs e)
        {

        }
    }
}
