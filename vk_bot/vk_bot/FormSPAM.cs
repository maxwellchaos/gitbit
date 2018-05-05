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
    public partial class FormSPAM : Form
    {
        string p;
        string o;
        public string access_token;
        public FormSPAM()
        {
            InitializeComponent();
        }
        private void FormSPAM_Load(object sender, EventArgs e)
        {
            webBrowserNTV.Dock = DockStyle.Fill;
            webBrowserNTV.Navigate("https://oauth.vk.com/authorize?client_id=6410347&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends+messages&response_type=token&v=5.74");
        }

        private void webBrowserNTV_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowserNTV.Visible = false;
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
                
                
            }

        }

        private void spam_Click(object sender, EventArgs e)
        {

        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            FormDR q = new FormDR();
//            q.access_token = access_token;
//            q.Show();
//        }

        private void timerQwerty_Tick(object sender, EventArgs e)
        {

        }

        private void checkBoxу_CheckedChanged(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.vk.com/method/friends.get.xml?fields=bdate&access_token=" + access_token + "&v=5.74");
            XmlNode response = doc.SelectSingleNode("response");
            XmlNode items_list = response.SelectSingleNode("items");
            DateTime ds = DateTime.Now;
            foreach (XmlNode user in items_list.SelectNodes("user"))
            {
                XmlNode first_name = user.SelectSingleNode("first_name");
                XmlNode last_name = user.SelectSingleNode("last_name");
                XmlNode id = user.SelectSingleNode("id");
                XmlNode bdate = user.SelectSingleNode("bdate");
                if (bdate != null)
                {
                    int y = bdate.InnerText.IndexOf(".");
                    p = bdate.InnerText.Remove(y);
                    int u = bdate.InnerText.IndexOf(".");
                    o = bdate.InnerText.Remove(0, u + 1);
                    int t = o.IndexOf(".");
                    if (t > 0)
                    {
                        o = o.Remove(t);
                    }

                    if (ds.Day.ToString() == p)
                    {
                        if (ds.Month.ToString() == o)
                        {
                            textBoxT.Text = first_name.InnerText + " " + last_name.InnerText + " празднует день рождения!";
                            XmlDocument docqwerf = new XmlDocument();
                            doc.Load("https://api.vk.com/method/messages.send.xml?user_id=" + id.InnerText + "&message=C днём рождения " + first_name.InnerText + " " + last_name.InnerText + "!&access_token=" + access_token + "&v=5.74");
                        }
                    }
                }
            }
        }
    }
}
