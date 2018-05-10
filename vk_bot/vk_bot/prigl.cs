using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Threading;


namespace vk_bot
{
    public partial class prigl : Form
    {
        public string access_token;
        public string indexer;

        public prigl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://api.vk.com/method/groups.getInvitedUsers.xml?group_id=" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
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
            }

            //добираюсь до индентификаторов
            XmlDocument doo = new XmlDocument();
            doo.Load("https://api.vk.com/method/groups.getInvitedUsers.xml?group_id=" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
            XmlNode response = doo.SelectSingleNode("response");
            XmlNode tager = response.SelectSingleNode("items");

            foreach (XmlNode prof in tager.SelectNodes("user"))
            {
                doo.Load("https://api.vk.com/method/groups.removeUser.xml?user_id=" + indexer + "&group_id=" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
                XmlNode id = prof.SelectSingleNode("id");
                indexer = id.InnerXml;

                Thread.Sleep(220);
                Application.DoEvents();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://api.vk.com/method/groups.removeUser.xml?user_id="+indexer+"&group_id="+textBox1.Text+"&access_token=" + access_token + "&v=5.73");
        }

        private void prigl_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Инструкция: 1. Нажмите на кнопку ВЫПОЛНИТЬ ЗАПРОС | 2. Нажмите на кнопку НАЧАТЬ УДАЛЯТЬ ПРИГЛАШЕНИЯ");
        }

    }
}
