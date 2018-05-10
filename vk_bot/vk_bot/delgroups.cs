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
    public partial class delgroups : Form
    {
        public string access_token;
        public string index;
        

        public delgroups()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://api.vk.com/method/groups.get.xml?offset=1&access_token=" 
                + access_token + "&v=5.73");
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

                //добираюсь до индентификаторов групп
                XmlDocument doo = new XmlDocument();
                doo.Load("https://api.vk.com/method/groups.get.xml?&access_token=" 
                    + access_token + "&v=5.73");

                XmlNode response = doo.SelectSingleNode("response");
                XmlNode groups = response.SelectSingleNode("items");

                foreach (XmlNode groupsid in groups.SelectNodes("gid"))
                {
                    doo.Load("https://api.vk.com/method/groups.get.xml?&access_token=" 
                        + access_token + "&v=5.73");

                    XmlNode id = groups.SelectSingleNode("gid");
                    index = groupsid.InnerXml;

                    XmlDocument dop = new XmlDocument();

                    dop.Load("https://api.vk.com/method/groups.leave.xml?group_id="
                + index + "&access_token=" + access_token + "&v=5.73");

                    Thread.Sleep(500);
                    Application.DoEvents();
                    
                }

                    //считаю кол-во записей в группе
                    doo.Load("https://api.vk.com/method/groups.get.xml?&access_token=" 
                        + access_token + "&v=5.73");

                    response = doo.SelectSingleNode("response");
                    XmlNode dopres = response.SelectSingleNode("count");

                    label1.Text = dopres.InnerXml;
                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://api.vk.com/method/groups.leave.xml?group_id=" 
                + index + "&access_token=" + access_token + "&v=5.73");
        }

        private void delgroups_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Инструкция: 1. Нажмите на кнопку ВЫПОЛНИТЬ ЗАПРОС | 2. Нажмите на НАЧАТЬ УДАЛЯТЬ");
        }
    }
}
