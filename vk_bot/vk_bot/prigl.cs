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
<<<<<<< HEAD
=======
using System.Drawing.Text;
using System.Media;
>>>>>>> pr/16

namespace vk_bot
{
    public partial class prigl : Form
    {
        public string access_token;
        public string indexer;
        public string errors;

        private Point mouseOffset;
        private bool isMouseDown = false;
        public prigl()
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
            label1.Font = new Font(font.Families[0], 48);
            label2.Font = new Font(font.Families[0], 48);
            label3.Font = new Font(font.Families[0], 18);
            label4.Font = new Font(font.Families[0],18);
            label5.Font = new Font(font.Families[0], 18);
            label6.Font = new Font(font.Families[0], 18);
            ORG.Font = new Font(font.Families[0], 24);
            button1.Font = new Font(font.Families[0], 36);
            Minimize_Button.Font = new Font(font.Families[0], 24);
            Button_Exit.Font = new Font(font.Families[0], 24);
            textBox1.Font = new Font(font.Families[0], 24);
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
                DebugOK OK = new DebugOK();
                SystemSounds.Asterisk.Play();
                OK.Show();
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
            Opacity = 0;

            FADERSTART.Start();
        }

        private void label2_Click(object sender, EventArgs e)
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
