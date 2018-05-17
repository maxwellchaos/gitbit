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
        string access_token;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=6464597&scope=friends,comment,photos,audio,video,docs,notes,pages,status,offers,questions,wall,groups,messages,notifications,stats,ads,market,offline&redirect_uri=https://api.vk.com/blank.html&display=page&response_type=token");
       
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

        private void delcom_Click(object sender, EventArgs e)
        {
            url newForm = new url();
            newForm.access_token = access_token;
            newForm.Show();
        }
    }
}
