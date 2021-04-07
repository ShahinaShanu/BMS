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
    public partial class MonyTransfer : Form
    {
        MainCls obj = new MainCls();
        public MonyTransfer(string strtxt)
        {
            InitializeComponent();
            label1.Text = strtxt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show("Enter the id first.");
                    txtid.Focus();
                }
                else
                {
                    DataTable dt2 = new DataTable();
                    string query2 = "select name from Deposite where id='" + txtid.Text + "' ";
                    dt2 = obj.datatab(query2);
                    if (dt2.Rows.Count > 0)
                    {
                        txtname.Text = dt2.Rows[0]["name"].ToString();
                        txtamt.Enabled = true;
                        txtamt.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No customer available for this account number.");
                    }
                
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kindly Contact to administrator.");
            }
        }
        void totalWithdrawal()
        {


            string query = "select sum(amount) amt from Withdrawal where id='" + label1.Text + "' group by id"; ;
            label8.Text = "No Withdrawal yet.";
            DataTable dt = new DataTable();
            dt = obj.datatab(query);
            if (dt.Rows.Count >= 1)
            {
                label8.Text = dt.Rows[0]["amt"].ToString();
            }

        }

        void totaldeposite()
        {

            string deposited = Convert.ToString("0");
            label10.Text = "No Deposite yet.";
            string query = "select sum(amount) amt from deposite where id='" + label1.Text + "' group by id"; ;

            DataTable dt = new DataTable();

            dt = obj.datatab(query);
            if (dt.Rows.Count >= 1)
            {

                label10.Text = dt.Rows[0]["amt"].ToString();
            }

        }

        void balance()
        {
            try
            {
                int b = Convert.ToInt32(label10.Text) - Convert.ToInt32(label8.Text);
                label6.Text = b.ToString();

            }
            catch (Exception)
            {
                label6.Text = label10.Text;
            }

        }

        private void MonyTransfer_Load(object sender, EventArgs e)
        {
            try
            {
                totaldeposite();
                totalWithdrawal();
                balance();
            txtamt.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Kinldy contact to administrator.");
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtamt.Text == "" || Convert.ToInt64(label6.Text) <= 500)
                {
                    MessageBox.Show("Operation not allowed. Check the amount or Balance.");
                }
                else
                {
                    string name = "Transfered-"+ label1.Text+"-"+ txtname.Text;

                    int id = Convert.ToInt32(label1.Text);
                    int amount = Convert.ToInt32(txtamt.Text);
                    string date = dateTimePicker1.Text.ToString();
                    int i = obj.Withdrawal(id, amount, date, name);


                    //////////////////////////////////////////
                    int id2 = Convert.ToInt32(txtid.Text);
                    int amount2 = Convert.ToInt16(txtamt.Text);
                    string date2 = dateTimePicker1.Text.ToString(); ;
                    int i2 = obj.Deposite(id2, amount2, date2,name);
                    if (i == 1 && i2 == 1)
                    {
                        MessageBox.Show("Mony transfered successfully.");
                        txtamt.Text = "";
                        txtid.Text = "";
                        txtname.Text = "";
                        totaldeposite();
                        totalWithdrawal();
                        balance();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Kinldy contact to administrator.");
            }
        }
    }
}
