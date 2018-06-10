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

using System.Drawing.Text;
using System.Media;

namespace vk_bot
{
    public partial class delgroups : Form
    {
        public string access_token;
        public string index;
        public string errors;

        private Point mouseOffset;
        private bool isMouseDown = false;

        public delgroups()
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
            label1.Font = new Font(font.Families[0], 18);
            label2.Font = new Font(font.Families[0], 48);
            label3.Font = new Font(font.Families[0], 18);
            label5.Font = new Font(font.Families[0], 18);
            label7.Font = new Font(font.Families[0], 48);
            label8.Font = new Font(font.Families[0], 18);
            button1.Font = new Font(font.Families[0], 36);
            Minimize_Button.Font = new Font(font.Families[0], 24);
            Button_Exit.Font = new Font(font.Families[0], 24);
            ORG.Font = new Font(font.Families[0], 24);

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

            DebugOK OK = new DebugOK();
            SystemSounds.Asterisk.Play();
            OK.Show();


            //считаю кол-во записей в группе
            doo.Load("https://api.vk.com/method/groups.get.xml?&access_token=" 
                        + access_token + "&v=5.73");

                    response = doo.SelectSingleNode("response");
                    XmlNode dopres = response.SelectSingleNode("count");

                    label1.Text = dopres.InnerXml;
        }


        private void delgroups_Load(object sender, EventArgs e)
        {
            Opacity = 0;

            FADERSTART.Start();
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
