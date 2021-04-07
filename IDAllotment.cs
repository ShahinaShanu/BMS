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
    public partial class IDAllotment : Form
    {
        public IDAllotment()
        {
            InitializeComponent();
        }

      
        MainCls obj = new MainCls();

        private void IDAllotment_Load(object sender, EventArgs e)
        {
            try
            {
                fillname();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void fillname()
        {
            try
            {
                string query = "select FName,ID from CustPersonalInfo where UserName is null";
                DataTable dt = new DataTable();
                dt = obj.datatab(query);

                cmbNew.DataSource = dt;
                cmbNew.ValueMember = "ID";
                cmbNew.DisplayMember = "FName";

                txtpassword.Enabled = false;
                button1.Enabled = false;
                txtusername.Focus();
            }
            catch (Exception)
            {

                MessageBox.Show("There is some error kindly contact to administrator.");

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtpassword.Text=="" ||txtusername.Text=="")
            {
                MessageBox.Show("Kindly Enter the correct Information.");
            }
            else
            {

                int a = Convert.ToInt32(cmbNew.SelectedValue);
                       int b;
            b = obj.updateusername(a, txtusername.Text);
 
            insert();
            MessageBox.Show("UserName and Password Sucessfully Alloted.");
            txtpassword.Text = "";
            txtusername.Text = "";
            fillname();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("There is some error kindly contact to administrator.");
            }
        }

        void insert()
        {

            int a = Convert.ToInt32(cmbNew.SelectedValue);
            string b = cmbNew.Text.ToString();
            string query = "insert into CustIDPass(customerid,name,userid,password)values('" + a + "','" + b + "','" + txtusername.Text + "','" + txtpassword.Text + "')";
            int i = obj.insertidpassword(a, b, txtusername.Text, txtpassword.Text);
            if (i == 1)
            {
                MessageBox.Show("Data Inserted sucessfully.");
            }
            else
            {
                MessageBox.Show("Data not inserted.");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                string query = "select userid from CustIDPass where userid='" + txtusername.Text + "'";
                DataTable dt = new DataTable();
                dt = obj.datatab(query);
                if (dt.Rows.Count >= 1)
                {
                    txtpassword.Enabled = false;
                    MessageBox.Show("This Username is already given.");
                    txtusername.Focus();
                }
                else
                {
                    txtpassword.Enabled = true;
                    MessageBox.Show("Congrates ! UserName is Available.");
                    txtpassword.Focus();
                    button1.Enabled = true;
                }



            }
            catch (Exception)
            {

                MessageBox.Show("Contact to administrator.");
            }
        }
    }
}
