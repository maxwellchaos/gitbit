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
    public partial class wallskanform : Form
    {
        //создаю переменные
        public string textbox;
        public string access_token;
        public string idpostlist;
        public string id2postlist;

        public wallskanform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textbox = textBox1.Text;

            webBrowser1.Navigate("https://api.vk.com/method/wall.get.xml?owner_id=-" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
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

                //добираюсь до id 1
                XmlDocument tags = new XmlDocument();
                tags.Load("https://api.vk.com/method/wall.get.xml?owner_id=-" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
                XmlNode response = tags.SelectSingleNode("response");
                XmlNode tager = response.SelectSingleNode("items");
                XmlNode post = tager.SelectSingleNode("post");
                XmlNode id = post.SelectSingleNode("id");
                textbox = id.InnerXml;

                //добираюсь до id 2
                XmlDocument tags1 = new XmlDocument();
                tags1.Load("https://api.vk.com/method/wall.get.xml?owner_id=-" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
                XmlNode response1 = tags1.SelectSingleNode("response");
                XmlNode tager1 = response1.SelectSingleNode("items");
                XmlNode post1 = tager1.SelectSingleNode("post");
                XmlNode id1 = post1.SelectSingleNode("id");
                id1 = post1.SelectSingleNode("id");
                id2postlist = id1.InnerXml;
                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://api.vk.com/method/likes.add.xml?type=post&owner_id=-" + textBox1.Text + "&item_id=" + textbox + "&access_token=" + access_token + "&v=5.73");
            webBrowser1.Navigate("https://api.vk.com/method/likes.add.xml?type=post&owner_id=-" + textBox1.Text + "&item_id=" + id2postlist + "&access_token=" + access_token + "&v=5.73");
        }
    }
}
