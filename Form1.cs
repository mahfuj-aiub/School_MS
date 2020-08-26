using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Officer
{
    public partial class Login : Form
    {
       // public static string ID ="";
        public Login()
        {
            InitializeComponent();
           // this.SetStyle(ControlStyles.ResizeRedraw, true);

        }

        private void bunifuThinButtonLogin_Click(object sender, EventArgs e)
        {
            if (bunifuDropdownLoginAs.selectedValue == "Student")
            {

                Student_initiant_page sip = new Student_initiant_page();
                Student_Profile.UserId = bunifuMaterialTextboxUserName.Text;
                sip.Show();
                this.Hide();
            }
            else if(bunifuDropdownLoginAs.selectedValue=="Official")
            {
                Office_Profile.UserId = bunifuMaterialTextboxUserName.Text;
                office o = new office();
                o.Show();     
                this.Hide();
            }
              
          
       
        
        }

        /*private const int cGrip = 16;
         private const int cCaption = 32;

         protected override void WndProc(ref Message m)
         {
             if(m.Msg == 0x84)
             {
                 Point pos = new Point(m.LParam.ToInt32());
                 pos = this.PointToClient(pos);
                 if(pos.Y < cCaption)
                 {
                     m.Result = (IntPtr)2;
                 }
                 if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                 {
                     m.Result = (IntPtr)17;
                     return;
                 }
             }
             base.WndProc(ref m);
         }*/

    }
}
