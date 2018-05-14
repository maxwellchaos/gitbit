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
        public string errors;

        public wallskanform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите id!");
            }

            else
            {
                //передаю id из текстбокса в переменную
                textboxer = textBox1.Text;

                //добираюсь до id
                XmlDocument tags = new XmlDocument();
                tags.Load("https://api.vk.com/method/wall.get.xml?&owner_id=-" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
                XmlNode response = tags.SelectSingleNode("response");
                XmlNode tager = response.SelectSingleNode("items");

                //цикл
                foreach (XmlNode utag in tager.SelectNodes("post"))
                {
                    XmlNode postid = utag.SelectSingleNode("id");
                    XmlDocument dopdoo = new XmlDocument();

                    dopdoo.Load("https://api.vk.com/method/likes.add.xml?type=post&owner_id=-" + textBox1.Text + "&item_id=" + textboxer + "&access_token=" + access_token + "&v=5.73");

                    textboxer = postid.InnerXml;

                    //ищу ошибки
                    if (dopdoo.InnerXml.Contains("error"))
                    {
                        errors += 1;
                        label5.Text = errors;
                    }

                    //делаю паузу
                    Thread.Sleep(200);
                    Application.DoEvents();
                }

                label3.Text = "ГОТОВО!";

                //считаю кол-во
                tags.Load("https://api.vk.com/method/wall.get.xml?&owner_id=-" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
                response = tags.SelectSingleNode("response");
                tager = response.SelectSingleNode("count");

                label4.Text = tager.InnerXml;
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void wallskanform_Load(object sender, EventArgs e)
        {
            
        }

    }
}
