using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_MS
{
    public partial class Slide_Show_Log_In_Page : UserControl
    {
        public Slide_Show_Log_In_Page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Slide_Show_Log_In_Page_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            slide_show_timer.Start();
            
        }

        private void slide_show_timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            slide_show_timer.Stop();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            slide_show_timer.Start();
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            slide_show_timer.Stop();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            slide_show_timer.Start();
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            slide_show_timer.Stop();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            slide_show_timer.Start();
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            slide_show_timer.Stop();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            slide_show_timer.Start();
        }
    }
}
