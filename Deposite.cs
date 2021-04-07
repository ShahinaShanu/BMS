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
    public partial class Deposite : Form
    {
        public Deposite()
        {
            InitializeComponent();
        }
        MainCls obj = new MainCls();
        
        private void Deposite_Load(object sender, EventArgs e)
        {
            start();
        }

        void start()
        {
            txtamount.Enabled = false;
            txtname.Enabled = false;
            btndeposite.Enabled = false;
            txtid.Focus();
            //553392
            //573392
        }

        private void btndeposite_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtid.Text);
                int amount=Convert.ToInt32(txtamount.Text);
                string date = dateTimePicker1.Text.ToString(); ;
                //string query = "insert into deposite(id,amount,date,name)values('"+txtid.Text+"','"+txtamount.Text+"','"+date+"','"+txtname.Text+"')";
                int i = obj.Deposite(id, amount, date, txtname.Text);

                if (i == 1)
                {
                    MessageBox.Show("Amount deposited sucessfully.");
                    txtid.Text = "";
                    txtname.Text = "";
                    txtamount.Text = "";
                    start();
                }
                else
                {
                    MessageBox.Show("Kindly contact to administrator.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Check the amount or contact to admin.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                 
                string query = "select name from CustIDPass where customerid='" + txtid.Text + "'";
                
                DataTable dt = new DataTable();
                dt = obj.datatab(query);
                if (dt.Rows.Count >= 1)
                {
                    txtamount.Enabled = true;
                    btndeposite.Enabled = true;
                    txtamount.Focus();
                    txtname.Text = dt.Rows[0]["Name"].ToString();
                }
                else
                {
               MessageBox.Show("Kindly enter the correct userid.");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
