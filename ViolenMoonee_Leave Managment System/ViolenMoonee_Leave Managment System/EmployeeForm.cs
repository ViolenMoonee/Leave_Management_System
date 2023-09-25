using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ViolenMoonee_Leave_Managment_System
{
    public partial class EmployeeForm : Form
    {
        
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection(@"Data Source=DESTINYSHANE\SQLEXPRESS;Initial Catalog=EmployeeAdminPortal;Integrated Security=True");
            string query = "Select * from tbllogin1 Where username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);

            if (tbl.Rows.Count == 1)
            {
                LeaverequesrForm LF = new LeaverequesrForm();
                this.Hide();
                MessageBox.Show("Login Successfully! Welcome to Employee Portal");
                LF.Show();
            }

            else
            {
                MessageBox.Show("Login Unsuccessfully , Try Again!");
            }

            }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePortalForm WelcomePortalForm = new WelcomePortalForm();
            WelcomePortalForm.Show();
        }
    }
    }

