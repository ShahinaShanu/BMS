using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankManagementSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Kindly select the category first.");
                }
                else
                {
                    if (txtID.Text == "" || txtPW.Text == "")
                    {
                        MessageBox.Show("Kindly enter the username of password.");
                    }
                    else
                    {
                        int cat;
                        if (radioButton1.Checked)
                        {
                            cat = 1;
                        }
                        else
                        {
                            cat = 2;
                        }

                        MainCls obj = new MainCls();
                        int i = obj.Login(txtID.Text, txtPW.Text, cat);
                        if (i == 1)
                        {
                            if (cat == 1)
                            {
                                MessageBox.Show("Congrates you are login sucessfully.");
                                Main obj2 = new Main(txtID.Text);
                                obj2.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Congrates you are login sucessfully.");
                                CWS obj2 = new CWS(txtID.Text);
                                obj2.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password.");
                            txtID.Text = "";
                            txtPW.Text = "";
                            txtID.Focus();
                        }
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kinldy contact to administrator.");
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            btnOK.ForeColor = Color.Brown;
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnOK.ForeColor = Color.Navy;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you forget your password then contact to administrator.");
            txtPW.Focus();
        }






    }
}


