using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ViolenMoonee_Leave_Managment_System
{
    internal class DataHandler
    {
        public DataHandler() { 

        }
        static string connect = @"Data Source=DESTINYSHANE\SQLEXPRESS;Initial Catalog=EmployeeAdminPortal;Integrated Security=True";

        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter reader;
        public DataTable UserDetails = new DataTable();

        public void RequestLeave(string fullname , DateTime start , DateTime end , string comment)
        {

            string query = $"INSERT INTO tblapplyleave VALUES('{fullname}', '{start}', '{end}', '{comment}')";
            con = new SqlConnection(connect);
            con.Open();
            command = new SqlCommand(query, con);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Register Successful");
                



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            finally
            {
                con.Close();
            }
        }

        private void ReadData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblapplyleave", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            con.Close();
        }

        private void ReadData1()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblAppovedOrRejected", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            con.Close();
        }


        public void ApproveOrReject(string fullname, DateTime start, DateTime end, string reason ,string Apprej , string comment)
        {

            string query = $"INSERT INTO tblAppovedOrRejected VALUES('{fullname}', '{start}', '{end}', '{reason}', '{Apprej}', '{comment}')";
            con = new SqlConnection(connect);
            con.Open();
            command = new SqlCommand(query, con);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Register Successful");




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
