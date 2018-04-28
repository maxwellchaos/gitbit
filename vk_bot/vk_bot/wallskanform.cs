﻿using System;
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

                //добираюсь до id
                XmlDocument tags = new XmlDocument();
                tags.Load("https://api.vk.com/method/wall.get.xml?owner_id=-" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
                XmlNode response = tags.SelectSingleNode("response");
                XmlNode tager = response.SelectSingleNode("items");
                
                foreach(XmlNode post in tager.SelectNodes("post"))
                {
                    tags.Load("https://api.vk.com/method/likes.add.xml?type=post&owner_id=-" + textBox1.Text + "&item_id=" + textbox + "&access_token=" + access_token + "&v=5.73");
                    XmlNode id = post.SelectSingleNode("id");
                    textbox = id.InnerXml;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://api.vk.com/method/likes.add.xml?type=post&owner_id=-" + textBox1.Text + "&item_id=" + textbox + "&access_token=" + access_token + "&v=5.73");
        }
    }
}