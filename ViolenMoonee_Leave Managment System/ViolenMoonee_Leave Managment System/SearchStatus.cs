using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolenMoonee_Leave_Managment_System
{
    public partial class SearchStatus : Form
    {
        public SearchStatus()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESTINYSHANE\SQLEXPRESS;Initial Catalog=EmployeeAdminPortal;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    con.Open();
                    using (DataTable dt = new DataTable("tblAppovedOrRejected"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblAppovedOrRejected where fullname =@fullname",con))
                        {
                            cmd.Parameters.AddWithValue("fullname", txtsearch.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            lblrecord.Text = $"Total Records: {dataGridView1.RowCount}";
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaverequesrForm LR = new LeaverequesrForm();
            LR.Show();
        }

        private void SearchStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
