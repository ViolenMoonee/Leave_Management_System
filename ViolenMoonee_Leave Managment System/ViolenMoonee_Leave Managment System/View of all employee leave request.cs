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
    public partial class View_of_all_employee_leave_request : Form
    {
        DataHandler handler = new DataHandler();
        SqlConnection con = new SqlConnection(@"Data Source=DESTINYSHANE\SQLEXPRESS;Initial Catalog=EmployeeAdminPortal;Integrated Security=True");
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();

        
        public View_of_all_employee_leave_request()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DT = new DataGridView();
            DT = dataGridView1;
            txtfullname.Text = DT.CurrentRow.Cells[0].Value.ToString();
            txtdatestart.Text = DT.CurrentRow.Cells[1].Value.ToString();
            txtdateend.Text = DT.CurrentRow.Cells[2].Value.ToString();
            txtreason.Text = DT.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorForm administratorForm1 = new AdministratorForm();
            administratorForm1.Show();
        }

        private void View_of_all_employee_leave_request_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from tblapplyleave", con);
            adapt = new SqlDataAdapter("select * from tblapplyleave", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            ReadData();


           


            
            

            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;




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

        private void button1_Click(object sender, EventArgs e)
        {
            FinalViewTable FS = new FinalViewTable();
            DataHandler Dhandler = new DataHandler();
            FS.Fullname = txtfullname.Text;
            FS.Start = DateTime.Parse(txtdatestart.Text);
            FS.End = DateTime.Parse(txtdateend.Text);
            FS.Reason = txtreason.Text;
            FS.Apprej = txtAppRej.Text;
            FS.Comment = Txtcomment.Text;

            handler.ApproveOrReject(FS.Fullname, FS.Start, FS.End, FS.Reason, FS.Apprej, FS.Comment);

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatistic CS  = new ViewStatistic();
            CS.Show();
        }
    }
}
