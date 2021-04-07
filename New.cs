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
    public partial class New : Form
    {
        public New()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text == "" || txtname.Text == "" || txtpass.Text == "" || txtpost.Text == "")
                {
                    MessageBox.Show("All the fields are compulsory.");
                }
                else
                {
                    int i;
                    MainCls obj = new MainCls();
                    i = obj.Empinsert(txtname.Text, txtid.Text, txtpass.Text, txtpost.Text);
                    if (i == 1)
                    {
                        txtid.Text = "";
                        txtname.Text = "";
                        txtpass.Text = "";
                        txtpost.Text = "";
                        MessageBox.Show("Employee Registered Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Kindly contact to admin");
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Kindly contact to administrator.");
            }
        }
    }
}
