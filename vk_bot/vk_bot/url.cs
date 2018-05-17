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
    public partial class url : Form
    {
        public string access_token;
        public string textbox;
        public string ddos;
        public string idcommentlist;
        public string delscore;

        public url()
        {

            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {


            XmlDocument gg = new XmlDocument();
            gg.Load("https://api.vk.com/method/wall.get.xml?owner_id=-" + textbox1.Text + "&access_token=" + access_token + "&v=5.73");

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument tags = new XmlDocument();
            textbox = textbox1.Text;
            tags.Load("https://api.vk.com/method/wall.get.xml?owner_id=-" + textbox + "&access_token=" + access_token + "&v=5.73");
            XmlNode response = tags.SelectSingleNode("response");
            XmlNode tager = response.SelectSingleNode("items");
            XmlNode post = tager.SelectSingleNode("post");
            XmlNode id = post.SelectSingleNode("id");
            ddos = id.InnerText;


            XmlDocument comnt = new XmlDocument();
            comnt.Load("https://api.vk.com/method/wall.getComments.xml?owner_id=-" + textbox1.Text + "&post_id=" + ddos + "&access_token=" + access_token + "&v=5.73");
            //webBrowser1.Navigate("https://api.vk.com/method/wall.get.xml?owner_id=-" + textbox + "&access_token=" + access_token + "&v=5.73");
            response = tags.SelectSingleNode("response");
            tager = response.SelectSingleNode("items");
            post = tager.SelectSingleNode("post");

            XmlNode comments = post.SelectSingleNode("comments");
            XmlNode canpost = comments.SelectSingleNode("can_post");
            delscore = canpost.InnerXml;


            webBrowser1.Navigate("https://api.vk.com/method/wall.deleteComment.xml?owner_id=" + textbox1.Text + "&comment_id=" + delscore + "&access_token=" + access_token + "&v=5.73");

        }
    }
}