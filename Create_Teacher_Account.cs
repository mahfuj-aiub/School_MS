﻿using System;
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
    public partial class Create_Teacher_Account : UserControl
    {
        public Create_Teacher_Account()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButtonSignup_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (!Validation_Check.check_Name_Pattern(bunifuMaterialTextboxUserName.Text))
            {
                flag = false;
                bunifuMaterialTextboxUserName.Text = "";
                MessageBox.Show("Insert Valid Name");
            }
            if (!Validation_Check.check_Name_Pattern(bunifuMaterialTextbox1.Text))
            {
                flag = false;
                bunifuMaterialTextbox1.Text = "";
                MessageBox.Show("Insert Valid Name");
            }
            if (!Validation_Check.check_Email_Pattern(bunifuMaterialTextboxEmail.Text))
            {
                flag = false;
                bunifuMaterialTextboxEmail.Text = "";
                MessageBox.Show("Insert Valid Email");
            }
            if (!Validation_Check.check_Number_Pattern(bunifuMaterialTextbox3.Text))
            {
                flag = false;
                bunifuMaterialTextbox3.Text = "";
                MessageBox.Show("Insert Valid Phone Number");
            }
            if (flag == true)
            {
                string q = "insert into Name(first_name,last_name) values('" + bunifuMaterialTextboxUserName.Text + "','" + bunifuMaterialTextbox1.Text + "'); select scope_identity()";
                int pk = Data_Access.Insert_Into_Table(q);
                DateTime dob = Convert.ToDateTime(bunifuDatepicker1.Value);
                q = "insert into Teacher(teacher_id,name_id,phone,email,address,dob) values('" + bunifuMaterialTextboxID.Text + "','" + pk + "','" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextboxEmail.Text + "','" + bunifuMaterialTextbox4.Text + "','" + dob + "');  select scope_identity() ";
                pk = Data_Access.Insert_Into_Table(q);
                q = "insert into Log_In_Id(teacher_id) values('" + bunifuMaterialTextboxID.Text + "'); select scope_identity()";
                pk = Data_Access.Insert_Into_Table(q);
                q = "insert into Log_In(l_id,password,role) values('" + pk + "','" + bunifuMaterialTextbox2.Text + "','Teacher'); select scope_identity()";
                pk = Data_Access.Insert_Into_Table(q);
                MessageBox.Show("Registration Successful");
                bunifuDatepicker1.Value = DateTime.Now;
                bunifuMaterialTextbox1.Text = bunifuMaterialTextbox2.Text = bunifuMaterialTextbox3.Text = bunifuMaterialTextbox4.Text = bunifuMaterialTextboxEmail.Text = bunifuMaterialTextboxID.Text = bunifuMaterialTextboxUserName.Text = "";

            }
            else
                MessageBox.Show("Registration Failed");

        }

        private void Create_Teacher_Account_Load(object sender, EventArgs e)
        {
            bunifuMaterialTextboxID.Text = Generate_Random_Value.generate_Teacher_Id();
            bunifuMaterialTextbox2.Text = Generate_Random_Value.generate_Password().ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Generate_Random_Value.Increment_Teacher_Id();
            bunifuMaterialTextboxID.Text = Generate_Random_Value.generate_Teacher_Id();
            bunifuMaterialTextbox2.Text = Generate_Random_Value.generate_Password().ToString();
            bunifuMaterialTextbox1.Text = bunifuMaterialTextbox3.Text = bunifuMaterialTextbox4.Text =bunifuMaterialTextboxUserName.Text= "";
        }
    }
}
