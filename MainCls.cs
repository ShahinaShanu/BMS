using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BankManagementSystem
{
    class MainCls
    {

        // SqlConnection con=new SqlConnection (ConfigurationManager.ConnectionStrings["BankManagementSystem.Properties.Settings.Database1ConnectionString"].ConnectionString);
        // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["BankManagementSystem.Properties.Settings.Database1ConnectionString"].ConnectionString);
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\Shahina Project Final\BankManagementSystem\BankManagementSystem\Database1.mdf;Integrated Security=True;User Instance=True");

        public int test(string name)
        {
            int i = 0;
            con.Open();
            string query = "insert into test values('" + name + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            i = 1;
            con.Close();
            return i;
        }


        public int Login(String UN, String PW, int a)
        {
            int i = 0;

            if (a == 1)
            {
                con.Open();
                string query = "select * from elogin where empid='" + UN + "' and pass='" + PW + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                int aa = dt.Rows.Count;
                if (aa == 1)
                { i = 1; }
                con.Close();
            }
            else
            {

                con.Open();
                string query = "select * from CustIDPass where UserId='" + UN + "' and Password='" + PW + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                int aa = dt.Rows.Count;
                if (aa == 1)
                { i = 1; }
                con.Close();

            }
            return i;
        }

        public int insert(string FirstName, string MiddleName, string surname, string fathername, string mothername, string spousename)
        {
            int i = 0;
            con.Open();
            string query = "insert into CustPersonalInfo (FName,MName,SurName,FatherN,MotherN,SpouseN)values('" + FirstName + "','" + MiddleName + "','" + surname + "','" + fathername + "','" + mothername + "','" + spousename + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            i = 1;
            con.Close();
            return i;
        }

        public int insertCont(string HNo, string Street, string City, string State, int Pincode, string HNo2, string Street2, string City2, string State2, int Pincode2, string mobile, string altermobile, string email)
        {
            int i = 0;
            con.Open();
            string query = "insert into CustContactInfo(hno,street,city,state,pincode,hno2,street2,city2,state2,pincode2,mobile,altermobile,email) values('" + HNo + "','" + Street + "','" + City + "','" + State + "','" + Pincode + "','" + HNo2 + "','" + Street2 + "','" + City2 + "','" + State2 + "','" + Pincode2 + "','" + mobile + "','" + altermobile + "','" + email + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            i = 1;
            con.Close();
            return i;
        }

        public int insertOther(string othacc, string uid, string proof, string panno, string education, string community, string dob, string acctype)
        {
            int i = 0;
            con.Open();
            string query = "insert into CustOtherInfo values('" + othacc + "','" + uid + "','" + proof + "','" + panno + "','" + education + "','" + community + "','" + dob + "','" + acctype + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            i = 1;
            con.Close();
            return i;
        }

        public DataTable datatab(string query)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);
                
                con.Close();
                return dt;
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }
            finally
            {
                con.Close();
            }



        }

        public int insertidpassword(int id, string Name, string userid, string password)
        {
            try
            {
                int i = 0;
                con.Open();
                string query = "insert into CustIDPass(customerid,name,userid,password)values('" + id + "','" + Name + "','" + userid + "','" + password + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                i = 1;
                con.Close();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }


        }

        public int updateusername(int id, string username)
        {
            try
            {
                int i = 0;
                con.Open();
                string query = "update CustPersonalInfo set username='" + username + "' where id='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                i = 1;
                con.Close();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public int Deposite(int id, int amount, string date, string name)
        {
            try
            {
                int i = 0;
                con.Open();
                string query = "insert into deposite(id,amount,date,name)values('" + id + "','" + amount + "','" + date + "','" + name + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                i = 1;
                con.Close();
                return i;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            
        }

        public int Withdrawal(int id, int amount, string date, string name)
        {
            try
            {

                int i = 0;
                con.Open();
                string query = "insert into Withdrawal(id,amount,date,name)values('" + id + "','" + amount + "','" + date + "','" + name + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                i = 1;
                con.Close();
                return i;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public int UpdateProfile(int id,string HNo,string street,string city,string state,string pin,string mobile)
        {
            try
            {
                int i = 0;
                con.Open();
                string query = "update CustContactInfo set Hno='"+HNo+"',street='"+street+"',city='"+city+"',state='"+state+"',pincode='"+pin+"' where id='"+id+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                i = 1;
                con.Close();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public int Updateidpassword(int id, string PwdOld, string PwdNew)
        {
            try
            {
                int i = 0;
                con.Open();
                string query = "update CustIDPass set Password='"+PwdNew+"' where CustomerID='"+id+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                i = 1;
                con.Close();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }


        }

        public int Empinsert(string Name, string ID, string Password, string Post)
        {
            int i = 0;
            con.Open();
            string query = "insert into elogin (empid,ename,pass,Post)values('" + Name + "','" + ID + "','" + Password + "','" + Post + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            i = 1;
            con.Close();
            return i;
        }
    
    }
}
