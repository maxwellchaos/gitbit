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
    public partial class FormChangeStatus : Form
    {

        public string ACT2;
        public string CST;
        public string ID;
        public FormChangeStatus()
        {
            InitializeComponent();
        }

        private void FormChangeStatus_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.vk.com/method/users.get.xml?fields=photo_100&access_token=" + ACT2 + "&v=5.73");
            XmlNode response = doc.SelectSingleNode("response");
            XmlNode user = response.SelectSingleNode("user");
            XmlNode id = user.SelectSingleNode("id");
            ID = id.InnerXml;
        }

        private void buttonChangeStatusOK_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = CST;
            if (dateTimePicker1.Value == DateTime.Today)
            {
                webBrowserCST.Navigate("https://api.vk.com/method/status.set.xml?text=" + CST + "&access_token="+ ACT2 +"&v=5.52");
                timer1.Enabled = false;

            }
        }
    }
}
