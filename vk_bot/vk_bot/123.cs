using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Text;
using System.Media;

namespace vk_bot
{
    public partial class _123 : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        public string Access_token;
        public string userId;
        public _123()
        

        {
            InitializeComponent();
            fontsProjects();
            fonts();
        }
        PrivateFontCollection font;
        private void fontsProjects()
        {
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("FONTS/RLL.ttf");
            this.font.AddFontFile("FONTS/WS.ttf");  
        }
        private void fonts()
        {
            textBox2.Font = new Font(font.Families[0], 18);
            textBox1.Font = new Font(font.Families[0], 14);
            button1.Font = new Font(font.Families[0], 24);
            ORG.Font = new Font(font.Families[0], 22);
            Minimize_Button.Font = new Font(font.Families[0], 24);
            Button_Exit.Font = new Font(font.Families[0], 24);
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

                    System.Threading.Thread.Sleep(400);
                    XmlDocument doc1 = new XmlDocument();
                    doc1.Load("https://api.vk.com/method/groups.invite.xml?user_id=" + a.InnerText + "&group_id=" + textBox2.Text + "&access_token=" + Access_token + "&v=5.73");
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
            Opacity = 0;

            FADERSTART.Start();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

   

        private void WindowHalfBorder_Click(object sender, EventArgs e)
        {

        }

        private void ORG_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            FADER.Enabled = true;

        }
        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            FADERMINI.Enabled = true;
        }

        private void FADER_Tick(object sender, EventArgs e)
        {
            Opacity = Opacity -= 0.1;
            if (this.Opacity == 0)
            {

                Close();
            }
        }

        private void FADERMINI_Tick(object sender, EventArgs e)
        {
            Opacity = Opacity -= 0.1;
            if (this.Opacity == 0)
            {

                this.WindowState = FormWindowState.Minimized;
                FADERMINI.Stop();
                Opacity = 1;
            }

        }

        private void FADERSTART_Tick(object sender, EventArgs e)
        {
            Opacity = Opacity += 0.1;
            if (Opacity == 1)
            {

                FADERSTART.Stop();

            }
        }
    }
}
