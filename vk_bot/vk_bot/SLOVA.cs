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
    public partial class SLOVA : Form
    {
        public string A_T;
        string userID;
        string text;
        string a;
        string b;
        bool igra = false;
        public SLOVA()
        {
            InitializeComponent();
        }

        private void SLOVA_Load(object sender, EventArgs e)
        {

        }

        private void Vremia_Tick(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.vk.com/method/messages.getDialogs.xml?unread=1&access_token=" + A_T + "&v=5.73");
            if (doc == null)
            {

            }
            else
            {
                XmlNode response = doc.SelectSingleNode("response");
                XmlNode items = response.SelectSingleNode("items");
                XmlNode dialog = items.SelectSingleNode("dialog");
                if (dialog == null)
                {

                }
                else
                {
                    XmlNode message = dialog.SelectSingleNode("message");
                    XmlNode user_id = message.SelectSingleNode("user_id");
                    userID = user_id.InnerText;
                    XmlNode body = message.SelectSingleNode("body");
                    text = body.InnerText;
                    if (text == "Играть в слова")
                    {
                        igra = true;
                        a = "Ты первый(P.S. если захочешь остановить иру напиши \"СТОПЭ\" ";
                        byte[] bytes = Encoding.GetEncoding("UTF-8").GetBytes(a);
                        byte[] bit = Encoding.Convert( Encoding.GetEncoding("Windows-1251"), Encoding.GetEncoding("UTF-8"), bytes);
                        
                        webBrowser1.Navigate("https://api.vk.com/method/messages.send.xml?user_id=" + userID + "&message=" + a + "&access_token=" + A_T + "&v=5.73");
                        text = "0" ;
                    }
                    if (text == "играть в слова")
                    {
                        igra = true;
                        a = "Ты первый(P.S. если захочешь остановить иру напиши \"СТОПЭ\" ";
                        byte[] bytes = Encoding.Default.GetBytes(a);
                        webBrowser1.Navigate("https://api.vk.com/method/messages.send.xml?user_id=" + userID + "&message=" + a + "&access_token=" + A_T + "&v=5.73");
                        text = "0" ;
                    }
                    if (igra == true)
                    {
                        if (text == "0")
                        {

                        }
                        else
                        {
                            if (text == "СТОПЭ")
                            {
                                igra = false;
                            }
                            else
                            {

                            }                            
                        }
                    }
                }
            }
        }
    }
}
