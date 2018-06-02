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
        public string errors;

        public prigl()
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
                //добираюсь до индентификаторов
                XmlDocument doo = new XmlDocument();
                doo.Load("https://api.vk.com/method/groups.getInvitedUsers.xml?group_id=" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");
                XmlNode response = doo.SelectSingleNode("response");
                XmlNode tager = response.SelectSingleNode("items");

                foreach (XmlNode prof in tager.SelectNodes("user"))
                {
                    XmlNode id = prof.SelectSingleNode("id");
                    indexer = id.InnerXml;
                    doo.Load("https://api.vk.com/method/groups.removeUser.xml?user_id=" + indexer + "&group_id=" + textBox1.Text + "&access_token=" + access_token + "&v=5.73");


                    //ищу ошибки

                    if (doo.InnerXml.Contains("error"))
                    {
                        errors += 1;
                        label3.Text = Convert.ToString(errors);
                    }

                    //делаю паузу
                    Thread.Sleep(300);
                    Application.DoEvents();

                }

                label4.Text = "ГОТОВО!";
            }
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void prigl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
