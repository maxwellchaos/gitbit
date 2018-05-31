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
    public partial class RepFromGroupsForm : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        public string ACT3;
        public string GrID;
        public string postID;
        public string ShortLink;
        public string UrGrID;
        string OWNG;
        string NG;
        public string TEMP_NG;
        public int TEMP_NG2;
        public int TEMP_NGLEN;
        public RepFromGroupsForm()
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
            label1.Font = new Font(font.Families[0], 36);
            label2.Font = new Font(font.Families[0], 20);
            label3.Font = new Font(font.Families[0], 36);
            label4.Font = new Font(font.Families[0], 20);
            listBox1.Font = new Font(font.Families[0], 20);
            ORG.Font = new Font(font.Families[0], 24);
            textBoxREP2.Font = new Font(font.Families[0], 24);
            textBoxShName.Font = new Font(font.Families[0], 24);
            ButtonRep.Font = new Font(font.Families[0], 36);
            Minimize_Button.Font = new Font(font.Families[0], 24);
            Button_Exit.Font = new Font(font.Families[0], 24);
        }
        private void RepFromGroupForm_Load(object sender, EventArgs e)
        {
            
            FADERSTART.Enabled = true;



            XmlDocument sps = new XmlDocument();
            sps.Load("https://api.vk.com/method/groups.get.xml?filter=admin"+"&access_token=" + ACT3 + "&v=5.52");
            XmlNode response3 = sps.SelectSingleNode("response");
            XmlNode items3 = response3.SelectSingleNode("items");
            foreach (XmlNode gid in items3.SelectNodes("gid"))
            {              
               OWNG = gid.InnerXml;
               XmlDocument gn = new XmlDocument();
               gn.Load("https://api.vk.com/method/groups.getById.xml?group_id="+ OWNG + "&access_token=" + ACT3 + "&v=5.52");
               XmlNode response4 = gn.SelectSingleNode("response");
               XmlNode  group = response4.SelectSingleNode("group");
               XmlNode name = group.SelectSingleNode("name");
               NG = name.InnerXml;
               listBox1.Items.AddRange(new string[]{            
                     OWNG + "  - " + NG                        
            });
            }                 
        }
        private void buttonRep_Click(object sender, EventArgs e)
        {      
            ShortLink = textBoxShName.Text;
            ShortLink=  ShortLink.Remove(0, 15);
            XmlDocument doc2 = new XmlDocument();
            doc2.Load("https://api.vk.com/method/utils.resolveScreenName.xml?screen_name=" + ShortLink + "&access_token=" + ACT3 + "&v=5.52");
            XmlNode response2 = doc2.SelectSingleNode("response");
            XmlNode obid = response2.SelectSingleNode("object_id");
            GrID = obid.InnerXml;
            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.vk.com/method/wall.get.xml?owner_id=" + "-" + GrID + "&access_token=" + ACT3 + "&v=5.52");
            XmlNode response = doc.SelectSingleNode("response");
            XmlNode items = response.SelectSingleNode("items");
            XmlNode post = items.SelectSingleNode("post");
            XmlNode id = post.SelectSingleNode("id");
            postID = id.InnerXml;
            UrGrID = textBoxREP2.Text;
            webBrowser1.Navigate("https://api.vk.com/method/wall.repost.XML?object=" + "wall" + "-" + GrID + "_" + postID + "&group_id=" + UrGrID + "&access_token=" + ACT3 + "&v=5.52");
            DebugOK OK = new DebugOK();
            SystemSounds.Asterisk.Play();
            OK.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TEMP_NG = listBox1.Text;

            TEMP_NG2 = TEMP_NG.IndexOf(" ");

            TEMP_NGLEN = TEMP_NG.Length;

            TEMP_NG = TEMP_NG.Remove(TEMP_NG2,TEMP_NGLEN - TEMP_NG2 );

            textBoxREP2.Text = TEMP_NG;
        }
        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            FADERMINI.Enabled = true;
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            FADER.Enabled = true;
        }
        private void WindowHalfBorder_MouseDown(object sender, MouseEventArgs e)
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
        private void WindowHalfBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void WindowHalfBorder_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void FADER_Tick(object sender, EventArgs e)
        {
            Opacity = Opacity -= 0.1;
            if (this.Opacity == 0)
            {

                Close();

            }
        }

        private void FADERSTART_Tick(object sender, EventArgs e)
        {
            Opacity = Opacity += 0.1;
            if (Opacity == 1) {

                FADERSTART.Stop();

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
    }  
}
