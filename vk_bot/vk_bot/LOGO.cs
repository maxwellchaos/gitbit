using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Threading;
namespace vk_bot
{
    public partial class LOGO : Form
    {
        PrivateFontCollection font;
        Boolean END = false;
        public LOGO()
        {
            InitializeComponent();
            fontsProjects();
            fonts();
        }
        private void fontsProjects()
        {
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("FONTS/TUMB2.otf");

        }
        private void fonts()
        {
            PIC.Font = new Font(font.Families[0], 224);
        }
            

            private void LOGO_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            FADERSTART.Start();
        }

        private void FADER_Tick(object sender, EventArgs e)
        {
            Opacity = Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                LAUNCHER.Start();
                END = true;
                FADER.Stop();
                

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
                Thread.Sleep(3000);
                FADER.Start();
                LAUNCHER.Start();
                FADERSTART.Stop();

            }
        }

        private void LAUNCHER_Tick(object sender, EventArgs e)
        {
            if (END == true) {
                
               
                
                END = false;
                Close();
            
            }
         
        }
    }
}
