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
    public partial class Main : Form
    {
        public Main(string strText)
        {
            InitializeComponent();
            lblUser.Text = strText;
        }



        private void newRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void savingACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationFrm obj = new RegistrationFrm();
            obj.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn obj = new LogIn();
            obj.Show();
            this.Close();

        }

        private void currentACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New obj = new New();
            obj.Show();
        }

        private void allotIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposite obj = new Deposite();
            obj.Show();
        }

        private void withdrawlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Withdrawal obj = new Withdrawal();
            obj.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }




        private void newAllotmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDAllotment obj = new IDAllotment();
            obj.Show();
        }

        private void allotedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllotList obj = new AllotList();
            obj.Show();
        }

        private void customerProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            obj.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferMoney obj = new TransferMoney();
            obj.Show();
        }
    }
}
