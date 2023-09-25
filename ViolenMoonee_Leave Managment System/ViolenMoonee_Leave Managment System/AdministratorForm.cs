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
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePortalForm welcomePortalForm = new WelcomePortalForm();
            welcomePortalForm.Show();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESTINYSHANE\SQLEXPRESS;Initial Catalog=EmployeeAdminPortal;Integrated Security=True");
            string query = "Select * from tbladmin Where username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);

            if (tbl.Rows.Count == 1)
            {
                View_of_all_employee_leave_request view_Of_All_Employee_Leave_Request = new View_of_all_employee_leave_request();
                this.Hide();
                MessageBox.Show("Login Successfully! Welcome to Administration Portal");
                view_Of_All_Employee_Leave_Request.Show();
            }

            else
            {
                MessageBox.Show("Login Unsuccessfully , Try Again!");
            }
        }
    }
}
