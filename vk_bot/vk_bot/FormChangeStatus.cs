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

namespace vk_bot
{
    public partial class FormChangeStatus : Form
    {
        //access_token
        public string ACT2;
        //статусы расписаний
        public string CST;
        public string CST2;
        public string CST3;
        public string CST4;
        public string CST5;

        public string ID;
        public FormChangeStatus()
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
            ST1.Font = new Font(font.Families[0], 24);
            label1.Font = new Font(font.Families[0], 20);
            label2.Font = new Font(font.Families[0], 24);
            label3.Font = new Font(font.Families[0], 24);
            label4.Font = new Font(font.Families[0], 20);
            label5.Font = new Font(font.Families[0], 20);
            label6.Font = new Font(font.Families[0], 24);
            label8.Font = new Font(font.Families[0], 24);
            label9.Font = new Font(font.Families[0], 20);
            label7.Font = new Font(font.Families[0], 20);         
            buttonChangeStatusOK.Font = new Font(font.Families[0], 24);
            dateTimePicker1.Font = new Font(font.Families[0], 14);
            dateTimePicker2.Font = new Font(font.Families[0], 14);
            dateTimePicker3.Font = new Font(font.Families[0], 14);
            dateTimePicker4.Font = new Font(font.Families[0], 14);
            CSTdatatimer.Font = new Font(font.Families[0], 14);
            CSTinter.Font = new Font(font.Families[0], 18);
            textBox1.Font = new Font(font.Families[0], 18);
            textBox2.Font = new Font(font.Families[0], 18);
            textBox3.Font = new Font(font.Families[0], 18);
            textBox4.Font = new Font(font.Families[0], 18);


        }



        private void FormChangeStatus_Load(object sender, EventArgs e)
        {



            CSTinter.Text = Properties.Settings.Default.ST1;
            textBox1.Text = Properties.Settings.Default.ST2;
            textBox2.Text = Properties.Settings.Default.ST3;
            textBox3.Text = Properties.Settings.Default.ST4;
            textBox4.Text = Properties.Settings.Default.ST5;


            CSTdatatimer.Value = Properties.Settings.Default.TIME1;
            dateTimePicker1.Value = Properties.Settings.Default.TIME2;
            dateTimePicker2.Value = Properties.Settings.Default.TIME3;
            dateTimePicker3.Value = Properties.Settings.Default.TIME4;
            dateTimePicker4.Value = Properties.Settings.Default.TIME5;




       
       
      
           

            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.vk.com/method/users.get.xml?fields=photo_100&access_token=" + ACT2 + "&v=5.73");
            XmlNode response = doc.SelectSingleNode("response");
            XmlNode user = response.SelectSingleNode("user");
            XmlNode id = user.SelectSingleNode("id");
            ID = id.InnerXml;
        }

        private void buttonChangeStatusOK_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            Properties.Settings.Default.Save();



        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            CST = CSTinter.Text;
            Properties.Settings.Default.ST1 = CST;
            Properties.Settings.Default.TIME1 = CSTdatatimer.Value;

         
            if (CSTdatatimer.Value == DateTime.Today)
            {
                webBrowserCST.Navigate("https://api.vk.com/method/status.set.xml?text=" + CST + "&access_token="+ ACT2 +"&v=5.52");
                timer1.Enabled = false;
             

            }




        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            CST2 = textBox1.Text;

            Properties.Settings.Default.ST2 = CST2;
            Properties.Settings.Default.TIME2 = dateTimePicker1.Value;






            if (dateTimePicker1.Value == DateTime.Today)
            {
                webBrowser1.Navigate("https://api.vk.com/method/status.set.xml?text=" + CST2 + "&access_token=" + ACT2 + "&v=5.52");
                timer2.Enabled = false;

            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            CST3 = textBox2.Text;
            Properties.Settings.Default.ST3 = CST3;
            Properties.Settings.Default.TIME3 = dateTimePicker2.Value;


            if (dateTimePicker2.Value == DateTime.Today)
            {
                webBrowser2.Navigate("https://api.vk.com/method/status.set.xml?text=" + CST3 + "&access_token=" + ACT2 + "&v=5.52");
                timer3.Enabled = false;

            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            CST4 = textBox3.Text;
            Properties.Settings.Default.ST4 = CST4;
            Properties.Settings.Default.TIME4 = dateTimePicker3.Value;


            if (dateTimePicker3.Value == DateTime.Today)
            {
                webBrowser3.Navigate("https://api.vk.com/method/status.set.xml?text=" + CST4 + "&access_token=" + ACT2 + "&v=5.52");
                timer4.Enabled = false;

            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            CST5 = textBox3.Text;
            Properties.Settings.Default.ST5 = CST5;
            Properties.Settings.Default.TIME5 = dateTimePicker4.Value;


            if (dateTimePicker3.Value == DateTime.Today)

                webBrowser4.Navigate("https://api.vk.com/method/status.set.xml?text=" + CST5 + "&access_token=" + ACT2 + "&v=5.52");
                timer5.Enabled = false;

            }

        private void button6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        }
    }


