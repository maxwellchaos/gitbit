using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections.ObjectModel;
using System.IO;

namespace vk_bot
{
    public partial class SLOVA : Form
    {
        Collection<string> SL = new Collection<string>();

        XmlDocument mes = new XmlDocument();

        public string A_T;
        string userID;
        string text;
        string a;
        string[] b;
        string c;
        string f;
        string new_userID;
        string h;
        string i;

        bool first_timenach = true;
        bool igra = false;
        bool d = false;
        bool first_time = true;
        bool pravda;
        bool g = true;

        public SLOVA()
        {
            InitializeComponent();
        }
        private void start()
        {
            b = File.ReadAllLines(Application.StartupPath + "\\SLOVA\\slovas.txt");
            foreach (string row in b)
            {
                c = row;
                SL.Add(c);
            }
            c = null;
        }

        private void SLOVA_Load(object sender, EventArgs e)
        {
            start();
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
                    XmlNode body = message.SelectSingleNode("body");
                    text = body.InnerText;
                    XmlNode user_id = message.SelectSingleNode("user_id");
                    if (igra == false)
                    {
                        if (text.ToLower().Trim() == "играть в слова")
                        {
                            new_userID = user_id.InnerText;
                        }
                    }
                    if (igra == true)
                    {
                        new_userID = user_id.InnerText;
                    }
                    if (userID == null)
                    {
                        userID = new_userID;
                    }
                    if (new_userID != userID)
                    {
                        a = "Жди,ига идёт,и скоро до тебя дойдёт";
                        string request = "https://api.vk.com/method/messages.send.xml?user_id=" + new_userID + "&message=" + a + "&access_token=" + A_T + "&v=5.73";
                        byte[] bytes = Encoding.UTF8.GetBytes(request);
                        request = Encoding.GetEncoding("windows-1251").GetString(bytes);
                        webBrowser1.Navigate(request);
                    }
                    if (new_userID == userID)
                    {
                        if (text.ToLower().Trim() == "играть в слова")
                        {
                            if (first_timenach == true)
                            {
                                igra = true;
                                a = "Ты начинаешь, правила стандартные, играем в \"города\"(P.S. если захочешь остановить игру напиши \"СТОП\")";
                                string request = "https://api.vk.com/method/messages.send.xml?user_id=" + userID + "&message=" + a + "&access_token=" + A_T + "&v=5.73";
                                byte[] bytes = Encoding.UTF8.GetBytes(request);
                                request = Encoding.GetEncoding("windows-1251").GetString(bytes);
                                webBrowser1.Navigate(request);
                                first_timenach = false;
                                g = true;
                            }
                            else
                            {
                                a = "Игра уже идёт!";
                                string request = "https://api.vk.com/method/messages.send.xml?user_id=" + userID + "&message=" + a + "&access_token=" + A_T + "&v=5.73";
                                byte[] bytes = Encoding.UTF8.GetBytes(request);
                                request = Encoding.GetEncoding("windows-1251").GetString(bytes);
                                webBrowser1.Navigate(request);
                                g = true;
                            }
                        }

                        if (igra == true)
                        {
                             if (text.ToLower().Trim() == "стоп")
                                {
                                    igra = false;
                                    a = "GAME OVER";
                                    string request = "https://api.vk.com/method/messages.send.xml?user_id=" + userID + "&message=" + a + "&access_token=" + A_T + "&v=5.73";
                                    byte[] bytes = Encoding.UTF8.GetBytes(request);
                                    request = Encoding.GetEncoding("windows-1251").GetString(bytes);
                                    webBrowser1.Navigate(request);
                                    igra = false;
                                    text = "0";
                                    first_time = true;
                                    userID = null;
                                    first_timenach = true;
                                    h = null;
                                }
                             else if (igra == true && first_timenach == false)
                                {
                                    f = text.ToLower().Trim().Remove(1);
                                    if  (h == null)
                                    {
                                        
                                    }
                                    else
                                    {
                                        i = h.ToLower().Trim().Remove(0, h.Length - 1);
                                        if (i == "ь")
                                        {
                                            i = h.Remove(0, h.Length - 2);
                                            i = i.Remove(1);
                                        }
                                        if (i == "ы")
                                        {
                                            i = h.Remove(0, h.Length - 2);
                                            i = i.Remove(1);
                                        }
                                    }
                                    if  (h == null)
                                    {
                                        pravda = true;
                                    }
                                    else if (f == i || first_time == true)
                                    {
                                        pravda = true;
                                    }
                                    else if (first_time == true)
                                    {
                                        pravda = true;
                                    }
                                    else
                                    {
                                        pravda = false;
                                    }
                                    if (pravda == false)
                                    {
                                        a = "ВНИМАНИЕ Обнаружено нарушения правила последовательности слов в игре \"Каждое последующее слово должно начинаться с буквы, на каторую заканчивалось предидущее слово\" Отреагировать Изолировать Допросить";
                                        string request = "https://api.vk.com/method/messages.send.xml?user_id=" + userID + "&message=" + a + "&access_token=" + A_T + "&v=5.73";
                                        byte[] bytes = Encoding.UTF8.GetBytes(request);
                                        request = Encoding.GetEncoding("windows-1251").GetString(bytes);
                                        webBrowser1.Navigate(request);
                                    }
                                    if (pravda == true)
                                    {

                                        first_time = false;
                                        foreach (string c in SL)
                                        {
                                            if (text.ToLower().Trim() == c.ToLower().Trim())
                                            {
                                                d = true;
                                                SL.Remove(c);
                                                
                                                break;
                                            }
                                        }
                                        if (d == true)
                                        {
                                            f = text.Remove(0, text.Length - 1);
                                            if (f == "ь")
                                            {
                                                f = text.Remove(0, text.Length - 2);
                                                f = f.Remove(1);
                                            }
                                            if (f == "ы")
                                            {
                                                f = text.Remove(0, text.Length - 2);
                                                f = f.Remove(1);
                                            }
                                            foreach (string c in SL)
                                            {
                                                if (c.ToLower().Trim().Remove(1) == f)
                                                {
                                                    h = c;
                                                    string request = "https://api.vk.com/method/messages.send.xml?user_id=" + userID + "&message=" + h + "&access_token=" + A_T + "&v=5.73";
                                                    byte[] bytes = Encoding.UTF8.GetBytes(request);
                                                    request = Encoding.GetEncoding("windows-1251").GetString(bytes);
                                                    webBrowser1.Navigate(request);
                                                    SL.Remove(c);
                                                    d = false;
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (g == false)
                                            {
                                                a = "Данный город уже использовался/не существует в данной реальности";
                                                string request = "https://api.vk.com/method/messages.send.xml?user_id=" + userID + "&message=" + a + "&access_token=" + A_T + "&v=5.73";
                                                byte[] bytes = Encoding.UTF8.GetBytes(request);
                                                request = Encoding.GetEncoding("windows-1251").GetString(bytes);
                                                webBrowser1.Navigate(request);
                                            }
                                        }
                                        g = false;
                                    }
                                }
                            
                        }
                    }
                }
            }
        }
    }
}

