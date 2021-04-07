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
    public partial class AllotList : Form
    {
        MainCls obj = new MainCls();
        public AllotList()
        {
            InitializeComponent();
        }

        private void AllotList_Load(object sender, EventArgs e)
        {
            
            string query = "select * from CustIDPass";
            DataTable dt = new DataTable();
            dt = obj.datatab(query);
            dataGridView1.DataSource = dt;
           
        }
    }
}
