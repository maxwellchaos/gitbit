using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;



namespace vk_bot
{
    public partial class DebugOK : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;


        public DebugOK()
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
        label4.Font = new Font(font.Families[0], 24);
        ButtonDebOK.Font = new Font(font.Families[0], 28);
        Button_Exit.Font = new Font(font.Families[0], 24);
        Minimize_Button.Font = new Font(font.Families[0], 24);
        }
        private void DebugOK_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }   
        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            FADERMINI.Start();
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            FADER.Start();
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
        private void ButtonDebOK_Click(object sender, EventArgs e)
        {
            FADER.Start();
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

        private void FADER_Tick(object sender, EventArgs e)
        {
            Opacity = Opacity -= 0.1;
            if (this.Opacity == 0)
            {

                Close();

            }
        }

        private void DebugOK_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            FADERSTART.Start();
        }
    }
}
