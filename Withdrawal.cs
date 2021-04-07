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
    public partial class Withdrawal : Form
    {
        public Withdrawal()
        {
            InitializeComponent();
        }
        MainCls obj = new MainCls();

        long bal;
        private void Withdrawal_Load(object sender, EventArgs e)
        {
            start();
        }
        void start()
        {
            txtname.Text = "";
            txtname.Enabled = false;
            txtamount.Text = "";
            txtamount.Enabled = false;
            btnwithdrawal.Enabled = false;

            label6.Text = "";
            txtuserid.Focus();
            lbltotwith.Text = "";
            lbltotdepo.Text = "";
            txtamount.ForeColor = Color.Black;
        }

        private void lblSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtuserid.Text == "")
                {
                }
                else
                {
                    string d, w;
                    d = totaldeposite();
                    w = totalWithdrawal();
                    //MessageBox.Show(""+d);
                    //MessageBox.Show("" + w);

                  bal= Convert.ToInt64(d) - Convert.ToInt64(w);
                    label6.Text = bal.ToString();
                    if (bal > 0)
                    {
                        DataTable dt2 = new DataTable();
                        string query2 = "select name from Deposite where id='" + txtuserid.Text + "' ";
                        dt2 = obj.datatab(query2);
                        txtname.Text = dt2.Rows[0]["name"].ToString();
                        txtamount.Enabled = true;
                        btnwithdrawal.Enabled = true;
                        lbltotdepo.Text = "Total Deposite till date is : " + d;
                        lbltotwith.Text = "Total Withdrawal till date is : " + w;

                    }
                    else
                    {
                        MessageBox.Show("Kindly enter the correct userid.");
                    }
                   
                }
            }
            catch (Exception)
            {

                MessageBox.Show("There is some error kindly contact to administrator.");
            }
            finally
            {
                
            }
        }


        string totaldeposite()
        {

            string deposited = Convert.ToString("0");
            string query = "select sum(amount) amt from deposite where id='" + txtuserid.Text + "' group by id"; ;

            DataTable dt = new DataTable();

            dt = obj.datatab(query);
            if (dt.Rows.Count >= 1)
            {
                txtamount.Enabled = true;
                txtamount.Focus();
                deposited = dt.Rows[0]["amt"].ToString();
            }
             
            return deposited;
        }


        string totalWithdrawal()
        {

            string withdrawal = Convert.ToString("0");

            string query = "select sum(amount) amt from Withdrawal where id='" + txtuserid.Text + "' group by id"; ;
            DataTable dt = new DataTable();
            dt = obj.datatab(query);
            if (dt.Rows.Count >= 1)
            {
                txtamount.Enabled = true;
                txtamount.Focus();
                withdrawal = dt.Rows[0]["amt"].ToString();
            }
            
            return withdrawal;
        }


        private void btnwithdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                if (bal < Convert.ToInt16(txtamount.Text))
                {
                    MessageBox.Show("Entered amount access than the balance available.");
                    txtamount.Focus();
                    txtamount.ForeColor = Color.Red;
                }
                else
                {
                    int id = Convert.ToInt32(txtuserid.Text);
                    int amount = Convert.ToInt32(txtamount.Text);
                    string date = dtpdate.Text.ToString(); ;
                    int i = obj.Withdrawal(id, amount, date, txtname.Text);
                    MessageBox.Show("Amount Withdrawal sucessfully.");
                
                    txtuserid.Text = "";
                    txtname.Text = "";
                    txtamount.Text = "";
                    start();
                }
            }
            catch (Exception)
            {

                throw;
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
