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
    public partial class DepositeHistory : Form
    {
        MainCls obj = new MainCls();
        public DepositeHistory(string strtext)
        {
            InitializeComponent();
            label1.Text = strtext;
        }



        private void DepositeHistory_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(label1.Text);

                string query = "select * from deposite where ID='" + id + "'"; ;

                DataTable dt = new DataTable();
                dt = obj.datatab(query);
                dataGridView1.DataSource = dt;



            }
            catch (Exception)
            {

                MessageBox.Show("Kindly Contact to Admin.");
            }
            finally
            {

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
