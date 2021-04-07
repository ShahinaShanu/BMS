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
    public partial class CWS : Form
    {
        MainCls obj = new MainCls();

        public CWS(string strText)
        {
            InitializeComponent();
            lblUserName.Text = strText;
        }
      
        private void CWS_Load(object sender, EventArgs e)
        {
            try
            {
                getid();
                totalWithdrawal();
                totaldeposite();
                balance();

            }
            catch (Exception)
            {
                MessageBox.Show("No Transaction.");
            }

            
        }

        void balance()
        {
            try
            {                
                    int b = Convert.ToInt32(label6.Text) - Convert.ToInt32(label2.Text);
                    label8.Text = b.ToString();
                 
            }
            catch (Exception)
            {
                label8.Text = label6.Text;
            }
           
        }


        void totaldeposite()
        {

            string deposited = Convert.ToString("0");
            label6.Text = "No Deposite yet.";
            string query = "select sum(amount) amt from deposite where id='" + label1.Text + "' group by id"; ;
            
            DataTable dt = new DataTable();

            dt = obj.datatab(query);
            if (dt.Rows.Count >= 1)
            {

                label6.Text = dt.Rows[0]["amt"].ToString();
            }
           
        }



        void getid()
        {

            string query = "select CustomerID from CustIDPass where UserId='" + lblUserName.Text + "'";
            DataTable dt = new DataTable();
            dt = obj.datatab(query);
            if (dt.Rows.Count >= 1)
            {

                label1.Text = dt.Rows[0]["CustomerID"].ToString();
            }
           
           // label1.Text = dt.Rows[0]["CustomerID"].ToString();
             

        }



        void totalWithdrawal()
        {

            
            string query = "select sum(amount) amt from Withdrawal where id='" + label1.Text + "' group by id"; ;
            label2.Text = "No Withdrawal yet.";
            DataTable dt = new DataTable();
            dt = obj.datatab(query);
            if (dt.Rows.Count >= 1)
            {
                label2.Text = dt.Rows[0]["amt"].ToString();
            }

        }



        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositeHistory obj = new DepositeHistory(label1.Text);
            obj.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn obj = new LogIn();
            obj.Show();
            this.Close();

        }

        private void withdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawalHistory obj = new WithdrawalHistory(label1.Text);
            obj.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal obj = new Personal(label1.Text);
            obj.Show();
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetPwd obj = new ResetPwd(label1.Text);
            obj.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonyTransfer obj = new MonyTransfer(label1.Text);
            obj.Show();
        }

  


    }
}
