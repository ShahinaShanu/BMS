using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class ResetPwd : Form
    {

        MainCls obj = new MainCls();
        public ResetPwd(string strtext)
        {
            InitializeComponent();
            label4.Text = strtext;
        }




        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetPwd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewpwd.Text == txtConfpwd.Text)
            {
                MainCls obj = new MainCls();
                int i;
                i = obj.Updateidpassword(Convert.ToInt32(label4.Text), txtoldpwd.Text, txtNewpwd.Text);
                if (i == 0)
                {
                    MessageBox.Show("Not Updated, Check the data");
                }
                else
                {
                    MessageBox.Show("Password updated successfully.");
                    
                    txtNewpwd.Text = "";
                    txtConfpwd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Newpassword and Confirm Password Doesn't match.");
                txtConfpwd.Text = "";
                txtNewpwd.Text = "";
                txtoldpwd.Text = "";
            }
        }

        private void txtoldpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
