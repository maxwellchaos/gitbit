﻿using System;
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
    public partial class RepFromGroupForm : Form
    {

        public string ACT3;
        public string GrID;
        public string postID;
        public string ShortLink;

        public RepFromGroupForm()
        {
            InitializeComponent();
        }

        private void RepFromGroupForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonChangeStatusOK_Click(object sender, EventArgs e)
        {
           ShortLink  = textBox1.Text;

           // webBrowser1.Navigate("https://api.vk.com/method/utils.resolveScreenName.xml?screen_name=" + ShortLink + "&access_token=" + ACT3 + "&v=5.52");
            XmlDocument doc2 = new XmlDocument();
            doc2.Load("https://api.vk.com/method/utils.resolveScreenName.xml?screen_name=" + ShortLink + "&access_token=" + ACT3 + "&v=5.52");
            XmlNode response2 = doc2.SelectSingleNode("response");
            XmlNode obid = response2.SelectSingleNode("object_id");
            GrID = obid.InnerXml;






            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.vk.com/method/wall.get.xml?owner_id="+"-"+ GrID + "&access_token=" + ACT3 + "&v=5.52");
            XmlNode response = doc.SelectSingleNode("response");
            XmlNode items = response.SelectSingleNode("items");
            XmlNode post = items.SelectSingleNode("post");
            XmlNode id = post.SelectSingleNode("id");
            postID = id.InnerXml;




           webBrowser1.Navigate("https://api.vk.com/method/wall.repost.XML?object="+ "wall" +"-"+ GrID + "_" + postID + "&access_token=" + ACT3 + "&v=5.52");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
