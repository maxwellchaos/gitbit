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

namespace vk_bot
{
    public partial class RepFromGroupsForm : Form
    {

        public string ACT3;
        public string GrID;
        public string postID;
        public string ShortLink;
        public string UrGrID;

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
            textBoxREP2.Font = new Font(font.Families[0], 24);
            textBoxShName.Font = new Font(font.Families[0], 24);





        }







        private void RepFromGroupForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonRep_Click(object sender, EventArgs e)
        {
            ShortLink = textBoxShName.Text;

            // webBrowser1.Navigate("https://api.vk.com/method/utils.resolveScreenName.xml?screen_name=" + ShortLink + "&access_token=" + ACT3 + "&v=5.52");
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
        }




    }
}
