using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolenMoonee_Leave_Managment_System
{
    public partial class LeaverequesrForm : Form
    {
        RequestLeave ReqLeave = new RequestLeave();
        DataHandler handler = new DataHandler();
        public LeaverequesrForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm form = new EmployeeForm();
            form.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ReqLeave.Fullname = txtfullname.Text;
            ReqLeave.Start = DateTime.Parse(DateStart.Text);
            ReqLeave.End = DateTime.Parse(DateEnd.Text);
            ReqLeave.Reason = txtreason.Text;

            handler.RequestLeave(ReqLeave.Fullname, ReqLeave.Start, ReqLeave.End, ReqLeave.Reason);
        }

        private void btmviewNote_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchStatus SS = new SearchStatus();
            SS.Show();
        }
    }
}
