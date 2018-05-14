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
        public string errors;
        

        public delgroups()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

                    //ищу ошибки
                    if (dop.InnerXml.Contains("error"))
                    {
                        errors += 1;
                        label3.Text = errors;
                    }

                    Thread.Sleep(500);
                    Application.DoEvents();
                    
                }

                label4.Text = "ГОТОВО!";

                    //считаю кол-во записей в группе
                    doo.Load("https://api.vk.com/method/groups.get.xml?&access_token=" 
                        + access_token + "&v=5.73");

                    response = doo.SelectSingleNode("response");
                    XmlNode dopres = response.SelectSingleNode("count");

                    label1.Text = dopres.InnerXml;
        }

       
    }
}
