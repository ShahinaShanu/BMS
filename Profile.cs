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
    public partial class Profile : Form
    {
        MainCls obj = new MainCls();
        
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Enter the account number first.");
                }
                else
                {
                    personal();
                    Contact();
                    other();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kindly contact to the admin.");
            }
        }

        void personal()
        {
            try
            {
               
                string query = "select * from CustPersonalInfo where ID='" + txtID.Text + "'"; ;
                
                DataTable dt = new DataTable();
                dt = obj.datatab(query);
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
               
            }
        }

        void Contact()
        {
            try
            {
           
                string query = "select * from CustContactInfo where ID='" + txtID.Text + "'"; ;
                DataTable dt = new DataTable();
                dt = obj.datatab(query);
                dataGridView2.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
               
            }
        }

        void other()
        {
            try
            {
             
                string query = "select * from CustotherInfo where ID='" + txtID.Text + "'"; ;
                DataTable dt = new DataTable();
                dt = obj.datatab(query);
                dataGridView3.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            txtID.Focus();

        }
    }
}
