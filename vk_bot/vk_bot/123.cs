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
    public partial class _123 : Form
    {
        public string Access_token;
        public string userId;
        public _123()
            

        {
            InitializeComponent();
        }

        private void _123_Click(object sender, EventArgs e)
        {
           
         
            
            webBrowser1.Visible = false;
                

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
           
        {

            if (Access_token == null)
            {
                textBox1.Text = "Войдите в аккаунт";  
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("https://api.vk.com/method/friends.get.xml?user_id=" + userId + "&access_token=" + Access_token + "&v=5.73");

                XmlNode response = doc.SelectSingleNode("response");
                XmlNode items = response.SelectSingleNode("items");
                foreach (XmlNode a in items.SelectNodes("user_id"))
                {
                    textBox1.Text = textBox1.Text + a.InnerText + " ";
                    XmlDocument doc3 = new XmlDocument();
                    doc3.Load("https://api.vk.com/method/groups.getById.xml?group_id="+textBox2.Text+"&access_token="+Access_token+"&v=5.52");
                    XmlNode response2 = doc3.SelectSingleNode("response");
                        XmlNode group = response2.SelectSingleNode("group");
                    XmlNode id = group.SelectSingleNode("id");
                    System.Threading.Thread.Sleep(400);
                    XmlDocument doc1 = new XmlDocument();
                    doc1.Load("https://api.vk.com/method/groups.invite.xml?user_id=" + a.InnerText + "&group_id=" + id.InnerText + "&access_token=" + Access_token + "&v=5.73");
                    XmlNode response1 = doc1.SelectSingleNode("response");
                    XmlNode user = response.SelectSingleNode("user");

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {

        }

        private void _123_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
