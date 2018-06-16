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
    public partial class url : Form
    {
        public string access_token;
        public string textbox;
        public string ddos;
        public string idcommentlist;
        public string delscore;
        public string textid;

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
            foreach (XmlNode post in tager.SelectNodes("post"))
            {

                XmlNode id = post.SelectSingleNode("id");
                ddos = id.InnerXml;

                XmlDocument comnt = new XmlDocument();
                comnt.Load("https://api.vk.com/method/wall.getComments.xml?owner_id=-" + textbox1.Text + "&post_id=" + ddos + "&access_token=" + access_token + "&v=5.73");

                //делаю паузу
                Thread.Sleep(500);
                Application.DoEvents();

                XmlNode response2 = comnt.SelectSingleNode("response");
                XmlNode tager2 = response2.SelectSingleNode("count");
                XmlNode post2 = tager2.SelectSingleNode("comment");
                XmlNode id2 = response2.SelectSingleNode("items");

                //делаю паузу
                Thread.Sleep(500);
                Application.DoEvents();


                foreach (XmlNode utag2 in id2.SelectNodes("comment"))
                {
                    if (utag2.InnerText.Contains("http") || utag2.InnerText.Contains("https") || utag2.InnerText.Contains("https://")) 

                    {
                        XmlDocument vopros = new XmlDocument();
                        XmlNode who = utag2.SelectSingleNode("id");
                        XmlNode http = utag2.SelectSingleNode("text");


                        vopros.Load("https://api.vk.com/method/wall.deleteComment.xml?owner_id=-" + textbox1.Text + "&comment_id=" + who.InnerText + "&access_token=" + access_token + "&v=5.73");

                        //делаю паузу
                        Thread.Sleep(500);
                        Application.DoEvents();
                    }
                }
            }
        }
    }
}
           
        
    
