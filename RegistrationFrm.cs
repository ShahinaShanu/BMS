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
    public partial class RegistrationFrm : Form
    {
        public RegistrationFrm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "" || txtFatherName.Text == "" || txtcity.Text == "" || txtpin.Text == "" || txtstreet.Text == "" || txtMotherName.Text == "" || txtIDProof.Text == ""||cmbstate.SelectedIndex==0)
                {
                    MessageBox.Show("Kindly Fill Data in All the Compulsory Fields.");
                   
                }
                else

                {

                MainCls obj = new MainCls();
                string type;
                if (rdbCurrent.Checked)
                {
                    type = "Current";

                }
                else
                {
                    type = "Saving";
                }
                int s, t, u, v;
                s = obj.insert(txtFirstName.Text, txtMiddleName.Text, txtSurName.Text, txtFatherName.Text, txtMotherName.Text, txtspousename.Text);
                int p1, p2;
                string m1, m2;
                p1 =Convert.ToInt32( txtpin.Text);
                p2 = Convert.ToInt32(txt2pin.Text);
                m1 = txtmobile.Text;
                m2 = txtaltermobile.Text;
                t = obj.insertCont(txtHno.Text, txtstreet.Text, txtcity.Text, cmbstate.SelectedItem.ToString(), p1, txt2hno.Text, txt2street.Text, txt2city.Text, cmb2state.SelectedItem.ToString(), p2, m1, m2, txtemail.Text);
                u = obj.insertOther(txtotherAccount.Text, txtUID.Text, txtIDProof.Text, txtPAN.Text, cmbeducation.SelectedItem.ToString(), cmbCommunity.SelectedItem.ToString(), dateTimePicker1.Text.ToString(), type);
                v = s + t + u;
                if (v == 3)
                {
                    MessageBox.Show("Congratulations ! Primary registration done sucessfully.");
                    txt2city.Text = "";
                    txt2hno.Text = "";
                    txt2pin.Text = "";
                    txt2street.Text = "";
                    txtaltermobile.Text = "";
                    txtcity.Text = "";
                    txtemail.Text = "";
                    txtFatherName.Text = "";
                    txtFirstName.Text = "";
                    txtHno.Text = "";
                    txtIDProof.Text = "";
                    txtMiddleName.Text = "";
                    txtmobile.Text = "";
                    txtMotherName.Text = "";
                    txtotherAccount.Text = "";
                    txtPAN.Text = "";
                    txtpin.Text = "";
                    txtspousename.Text = "";
                    txtstreet.Text = "";
                    txtSurName.Text = "";
                    txtUID.Text = "";
                    cmb2state.SelectedIndex = 0;
                    cmbCommunity.SelectedIndex = 0;
                    cmbeducation.SelectedIndex = 0;
                    cmbstate.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Kindly Enter Correct Information.");
                }
                
                }

            }
            catch (Exception)
            {
                MessageBox.Show("There is some error, Kindly contact to Administrator.");
            }
            finally
            {

            }
        }


        private void RegistrationFrm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbstate.SelectedIndex = 0;
                cmb2state.SelectedIndex = 0;
                cmbCommunity.SelectedIndex = 0;
                cmbeducation.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt2hno.Text = txtHno.Text;
                txt2street.Text = txtstreet.Text;
                txt2city.Text = txtcity.Text;
                txt2pin.Text = txtpin.Text;
                cmb2state.SelectedIndex = cmbstate.SelectedIndex;

            }
            else
            {
                txt2city.Text = "";
                txt2hno.Text = "";
                txt2pin.Text = "";
                txt2street.Text = "";
                cmb2state.SelectedIndex = 0;
            }

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
