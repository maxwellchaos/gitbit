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
    public partial class wallskanform : Form
    {
        //создаю переменные
        public string textboxer;
        public string access_token;
        public string idpostlist;
        public string id2postlist;
        public string score;

        public wallskanform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textboxer = textBox1.Text;

            webBrowser1.Navigate("https://api.vk.com/method/wall.get.xml?&owner_id=-" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
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

            //добираюсь до id
            XmlDocument tags = new XmlDocument();
            tags.Load("https://api.vk.com/method/wall.get.xml?&owner_id=-" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
            XmlNode response = tags.SelectSingleNode("response");
            XmlNode tager = response.SelectSingleNode("items");

            foreach(  XmlNode utag in tager.SelectNodes("post") )
            {
                XmlNode postid = utag.SelectSingleNode("id");
                XmlDocument dopdoo = new XmlDocument();

                dopdoo.Load("https://api.vk.com/method/likes.add.xml?type=post&owner_id=-" + textBox1.Text + "&item_id=" + textboxer + "&access_token=" + access_token + "&v=5.73");

                textboxer = postid.InnerXml;

                Thread.Sleep(300);
                Application.DoEvents();
            }

                //считаю кол-во
                tags.Load("https://api.vk.com/method/wall.get.xml?&owner_id=-" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
                response = tags.SelectSingleNode("response");
                tager = response.SelectSingleNode("count");

                label4.Text = tager.InnerXml;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://api.vk.com/method/likes.add.xml?type=post&owner_id=-" + textBox1.Text + "&item_id=" + textboxer + "&access_token=" + access_token + "&v=5.73");
        }

        private void wallskanform_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Инструкция: 1. Нажмите на кнопку ВЫПОЛНИТЬ ЗАПРОС | 2. Нажми на кнопку НАЧАТЬ АВТОЛАЙКИНГ");
        }

      

    }
}
