using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BankManagementSystem
{
    public partial class Personal : Form
    {

        MainCls obj = new MainCls();

        public Personal(string strtext)
        {
            InitializeComponent();
            lblID.Text = strtext;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Personal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcity.Text == "" ||txtHNo.Text==""||txtMobile.Text==""||txtpin.Text==""||txtstate.Text==""||txtstreet.Text=="")
                {
                    MessageBox.Show("All the Fields are mandatory.");
                }
                else
                {

                    int i = Convert.ToInt32(lblID.Text);
                    int j = obj.UpdateProfile(i, txtHNo.Text, txtstreet.Text, txtcity.Text, txtstate.Text, txtpin.Text, txtMobile.Text);
                    if (j == 1)
                    {
                        MessageBox.Show("Data Updated sucessfully.");
                        txtcity.Text = "";
                        txtHNo.Text = "";
                        txtMobile.Text = "";
                        txtpin.Text = "";
                        txtstate.Text = "";
                        txtstreet.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Not updated");

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kindly contact to administrator.");
            }
            finally
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcity.Text = "";
            txtHNo.Text = "";
            txtMobile.Text = "";
            txtpin.Text = "";
            txtstate.Text = "";
            txtstreet.Text = "";

        }
    }
}
