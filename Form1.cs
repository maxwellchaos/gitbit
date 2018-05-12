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
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=6464597&scope=friends,photos,audio,video,docs,notes,pages,status,offers,questions,wall,groups,messages,notifications,stats,ads,market,offline&redirect_uri=https://api.vk.com/blank.html&display=page&response_type=token");
            
            //отключение кнопок на время авторизации
            mass_laik.Visible = false;
            egroup.Visible = false;
            delprigl.Visible = false;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //отключаю браузер на время выделения токена
            webBrowser2.Visible = false;
            

            string url = e.Url.ToString();
            
            //условие для поиска токена при запуске
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
                doc.Load("https://api.vk.com/method/users.get.xml?fields=photo_100&access_token=" + access_token + "&v=5.73");
                XmlNode response = doc.SelectSingleNode("response");
                XmlNode user = response.SelectSingleNode("user");

                XmlNode FirstName = user.SelectSingleNode("first_name");
                labelFirstName.Text = FirstName.InnerText;

                XmlNode LastName = user.SelectSingleNode("last_name");
                labelLastName.Text = LastName.InnerText;

                pictureBoxAvatar.ImageLocation = user.SelectSingleNode("photo_100").InnerText;
                webBrowser1.Visible = false;

                //включение кнопок
                mass_laik.Visible = true;
                egroup.Visible = true;
                delprigl.Visible = true;

                //подписываю пользователя на нашу группу в вк
                webBrowser2.Navigate("https://api.vk.com/method/groups.join.xml?group_id=165764761&access_token=" + access_token + "&v=5.73");
            }

        }

        private void mass_laik_Click(object sender, EventArgs e)
        {
            wallskanform newForm = new wallskanform();
            newForm.access_token = access_token;
            newForm.Show();
        }

        private void egroup_Click(object sender, EventArgs e)
        {
            delgroups newForm = new delgroups();
            newForm.access_token = access_token;
            newForm.Show();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void delprigl_Click(object sender, EventArgs e)
        {
            prigl newForm = new prigl();
            newForm.access_token = access_token;
            newForm.Show();
        }

        

    }

}
