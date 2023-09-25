using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolenMoonee_Leave_Managment_System
{
    public partial class ViewStatistic : Form
    {
        DataHandler handler = new DataHandler();
        SqlConnection con = new SqlConnection(@"Data Source=DESTINYSHANE\SQLEXPRESS;Initial Catalog=EmployeeAdminPortal;Integrated Security=True");
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        public ViewStatistic()
        {
            InitializeComponent();
        }

        private void ViewStatistic_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt1 = new SqlDataAdapter("select * from tblAppovedOrRejected", con);
            adapt1 = new SqlDataAdapter("select * from tblAppovedOrRejected", con);
            dt = new DataTable();
            adapt1.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            ReadData1();

            lblrow.Text = $"Total Records: {dataGridView1.RowCount}";



            

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

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_of_all_employee_leave_request VS = new View_of_all_employee_leave_request();
            VS.Show();
        }
    }
}
