﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Text;
using System.Threading;
using Microsoft.Win32;



namespace vk_bot
{
    public partial class Form1 : Form
    {
        //создаю переменные
        public string access_token; //для токена
        private Point mouseOffset;
        private bool isMouseDown = false;
        string userId;
        private string securitychecker;



        //**************  ******************** ДОНАТ ОГРАНИЧЕНИЕ ******************* **********************\\
        public static bool License = false; //false - для бесплатной версии, true - включение платной версии
        //**************  ******************** ***************** ******************* **********************\\




        public Form1()
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
            labelLastName.Font = new Font(font.Families[0],20);
            ORG.Font = new Font(font.Families[0], 24);
            labelFirstName.Font = new Font(font.Families[0], 36);
            delete_wall_post.Font = new Font(font.Families[0], 10);
            spam.Font = new Font(font.Families[0], 14);
            buttonChangeStatus.Font = new Font(font.Families[0], 10);
            RepFromGroupBTN.Font =  new Font(font.Families[0], 10);
            Minimize_Button.Font = new Font(font.Families[0], 24);
            Button_Exit.Font = new Font(font.Families[0], 24);
            buttonWelkom.Font = new Font(font.Families[0], 10);
            buttonПОЗДР.Font = new Font(font.Families[0], 10);
            but_laik.Font = new Font(font.Families[0], 10);
            but_delprigla.Font = new Font(font.Families[0], 10);
            but_exitgroups.Font = new Font(font.Families[0], 10);

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;
           
            FADERSTART.Start();
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.BringToFront();
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=6410347&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends,photos,audio,video,docs,notes,pages,status,offers,questions,wall,groups,messages,notifications,stats,ads,market,offline&response_type=token&v=5.73");
       
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            License = true;
            string url = e.Url.ToString();
            if (url.Contains("error"))
            {
                MessageBox.Show("Ошибка");
            }
            if (url.Contains("access_token"))
            {
                int IndexAccTok = url.IndexOf("access_token");
                access_token = url.Remove(0, IndexAccTok + 13);
                int IndexAmp = access_token.IndexOf("&");
                access_token = access_token.Remove(IndexAmp);

                //Зпрашиваю информацию о пользователе


                //Создаю XML документ

                XmlDocument doc = new XmlDocument();
                doc.Load("https://api.vk.com/method/users.get.xml?fields=photo_100&access_token=" + access_token+"&v=5.73");
                XmlNode response = doc.SelectSingleNode("response");
                XmlNode user = response.SelectSingleNode("user");

                

                XmlNode FirstName = user.SelectSingleNode("first_name");
                labelFirstName.Text = FirstName.InnerText;
             
                XmlNode LastName = user.SelectSingleNode("last_name");
                labelLastName.Text = LastName.InnerText;

                userId = user.SelectSingleNode("id").InnerText;

                pictureBoxAvatar.ImageLocation = user.SelectSingleNode("photo_100").InnerText;
                webBrowser1.Visible = false;

                XmlDocument Security = new XmlDocument();
                Security.Load("https://api.vk.com/method/groups.get.xml?user_id=" + userId + "&access_token=" + access_token + "&v=5.73");
                XmlNode response0 = Security.SelectSingleNode("response");
                XmlNode items0 = response0.SelectSingleNode("items");
                foreach (XmlNode gid in items0.SelectNodes("gid"))
                {
                    securitychecker = gid.InnerXml;
                    if (securitychecker == "167736693")
                    {

                        License = true;
                        break;

                    }
                    else {
                        License = false;
                    }
                
                }
            }
        }
        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            FormChangeStatus FRM3 = new FormChangeStatus();
            FRM3.ACT2 = access_token;
            FRM3.Show();            

        }
        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {
        }
        private void delete_wall_post_MouseEnter(object sender, EventArgs e)
        {
            delete_wall_post.FlatAppearance.BorderSize = 2;
        }
        private void delete_wall_post_MouseLeave(object sender, EventArgs e)
        {
            delete_wall_post.FlatAppearance.BorderSize = 0;

        }
        private void spam_MouseEnter(object sender, EventArgs e)
        {
            spam.FlatAppearance.BorderSize = 2;

        }
        private void spam_MouseLeave(object sender, EventArgs e)
        {
            spam.FlatAppearance.BorderSize = 0;

        }
        private void buttonChangeStatus_MouseEnter(object sender, EventArgs e)
        {
            buttonChangeStatus.FlatAppearance.BorderSize = 2;

        }
        private void buttonChangeStatus_MouseLeave(object sender, EventArgs e)
        {
            buttonChangeStatus.FlatAppearance.BorderSize = 0;

        }

        private void spam_Click(object sender, EventArgs e)
        {
            FormSpam_DR T = new FormSpam_DR();
            T.access_token = access_token;
            T.Show();
        }


        private void mass_laik_Click(object sender, EventArgs e)
        {
            wallskanform newForm = new wallskanform();
            newForm.access_token = access_token;
            newForm.Show();
        }

        private void delprigl_Click(object sender, EventArgs e)
        {
            prigl newForm = new prigl();
            newForm.access_token = access_token;
            newForm.Show();
        }

        private void egroup_Click(object sender, EventArgs e)
        {
            delgroups newForm = new delgroups();
            newForm.access_token = access_token;
            newForm.Show();
        }

        private void buttonПОЗДР_Click(object sender, EventArgs e)
        {
            FormSPAM q = new FormSPAM();
            q.access_token = access_token;
            q.Show();
        }

        private void RepFromGroupBTN_Click(object sender, EventArgs e)
        {
            RepFromGroupsForm FRM4 = new RepFromGroupsForm();
            FRM4.ACT3 = access_token;
            FRM4.Show();
        }

        private void but_exitgroups_MouseEnter(object sender, EventArgs e)
        {
            but_exitgroups.FlatAppearance.BorderSize = 2;
        }

        private void but_laik_MouseEnter(object sender, EventArgs e)
        {
            but_laik.FlatAppearance.BorderSize = 2;
        }

        private void but_delprigla_MouseEnter(object sender, EventArgs e)
        {
            but_delprigla.FlatAppearance.BorderSize = 2;
        }

        private void but_exitgroups_MouseLeave(object sender, EventArgs e)
        {
            but_exitgroups.FlatAppearance.BorderSize = 0;
        }

        private void but_laik_MouseLeave(object sender, EventArgs e)
        {
            but_laik.FlatAppearance.BorderSize = 0;
        }

        private void but_delprigla_MouseLeave(object sender, EventArgs e)
        {
            but_delprigla.FlatAppearance.BorderSize = 0;
        }

        private void delete_wall_post_Click(object sender, EventArgs e)
        {


        }
        private void RepFromGroupBTN_MouseLeave(object sender, EventArgs e)
        {
            RepFromGroupBTN.FlatAppearance.BorderSize = 0;
        }
        private void RepFromGroupBTN_MouseEnter(object sender, EventArgs e)
        {
            RepFromGroupBTN.FlatAppearance.BorderSize = 2;

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
            Opacity =   Opacity -= 0.1;
            if (this.Opacity == 0) {

                Application.Exit();

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

        private void buttonWelkom_Click(object sender, EventArgs e)
        {

            _123 frm = new _123();
            frm.Access_token = access_token;
            frm.userId = userId;
            frm.Show();

        }

        private void SlovaIstini_Click(object sender, EventArgs e)
        {
            SLOVA sl = new SLOVA();
            sl.A_T = access_token;
            sl.Show();
        }

        private void delcom_Click(object sender, EventArgs e)
        {
            url newForm = new url();
            newForm.access_token = access_token;
            newForm.Show();
		}

        private void but_exitgroups_MouseEnter_1(object sender, EventArgs e)
        {
            but_exitgroups.FlatAppearance.BorderSize = 2;

        }

        private void but_exitgroups_MouseLeave_1(object sender, EventArgs e)
        {
            but_exitgroups.FlatAppearance.BorderSize = 0;
        }

        private void buttonПОЗДР_MouseEnter(object sender, EventArgs e)
        {
            buttonПОЗДР.FlatAppearance.BorderSize = 2;

        }

        private void buttonПОЗДР_MouseLeave(object sender, EventArgs e)
        {
            buttonПОЗДР.FlatAppearance.BorderSize = 0;
        }

        private void buttonWelkom_MouseEnter(object sender, EventArgs e)
        {
            buttonWelkom.FlatAppearance.BorderSize = 2;
        }

        private void buttonWelkom_MouseLeave(object sender, EventArgs e)
        {
            buttonWelkom.FlatAppearance.BorderSize = 0;

        }
        private void labelLastName_Click(object sender, EventArgs e)
        {


        }


        private void deletefriends_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.vk.com/method/friends.get.xml?fields=photo_200_orig&access_token=" + access_token+"&v=5.73");
            XmlNode response = doc.SelectSingleNode("response");
            XmlNode items= response.SelectSingleNode("items");
            foreach (XmlNode user in items.SelectNodes("user"))
            {
                XmlNode photo = user.SelectSingleNode("photo_200_orig");
                if (photo.InnerXml.Contains("deactivated_200"))
                {
                    XmlDocument document = new XmlDocument();
                    document.Load("https://api.vk.com/method/friends.delete.xml?user_id=" + user.SelectSingleNode("id").InnerText+ "&access_token=" + access_token + "&v=5.73");
                    XmlNode id = document.SelectSingleNode("id");
                    System.Threading.Thread.Sleep(100);
                    //labelFriendsDelete.Text = "All Friends Delete";
                }
            }
                
        }

        private void DeleteComments_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.vk.com/method/wall.get.xml?owner_id=315032483&access_token=" + access_token + "&v=5.73");
            XmlDocument docs = new XmlDocument();
            docs.Load("https://api.vk.com/method/wall.getComment.xml?owner_id=315032483&access_token=" + access_token + "&v=5.73");
            XmlNode response = doc.SelectSingleNode("response");
            XmlNode items = response.SelectSingleNode("items");
            foreach (XmlNode post in items.SelectNodes("post"))
            {
                XmlNode censcom = post.SelectSingleNode("post");
                if (censcom.InnerXml.Contains(""))
                {
                    XmlDocument document = new XmlDocument();
                    document.Load("https://api.vk.com/method/wall.deleteComment.xml?owner_id=315032483&post_id=" + post.SelectSingleNode("id").InnerText + "&access_token=" + access_token + "&v=5.73");
                    XmlNode id = censcom.SelectSingleNode("id");
                   // labelCensure.Text = "All Comments Delete";
                }
            }
        }


        private void lic_Tick(object sender, EventArgs e)
        {
            if (License == false)
            {

                but_delprigla.Enabled = false;
                but_exitgroups.Enabled = false;
                but_laik.Enabled = false;
                buttonChangeStatus.Enabled = false;
                buttonWelkom.Enabled = false;
                buttonПОЗДР.Enabled = false;
                RepFromGroupBTN.Enabled = false;
                spam.Enabled = false;
                delete_wall_post.Enabled = false;
                ORG.Text = "У ВАС НЕТ ЛИЦЕНЗИИ";

            }
            if (License ==true)
            {

                but_delprigla.Enabled = true;
                but_exitgroups.Enabled = true;
                but_laik.Enabled =true;
                buttonChangeStatus.Enabled = true;
                buttonWelkom.Enabled = true;
                buttonПОЗДР.Enabled = true;
                RepFromGroupBTN.Enabled = true;
                spam.Enabled = true;
                delete_wall_post.Enabled = true;
                ORG.Text = "VKTUMBOCHKA";

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey Key;
            if (checkBox1.Checked == true)
            {

                Key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\MIcrosoft\\Windows\\CurrentVersion\\Run\\", true);


                Key.SetValue("VK_bot", Application.StartupPath + "\\vk_bot.exe");
                Key.Close();

            }
            else
            {
                Key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\MIcrosoft\\Windows\\CurrentVersion\\Run\\", true);
                Key.SetValue("VK_bot", Application.StartupPath + "\\vk_bot.exe");

                Key.DeleteValue("VK_bot");

                Key.Close();



            }
        }

        private void AS_Tick(object sender, EventArgs e)
       { 
   
        }


    }
}
