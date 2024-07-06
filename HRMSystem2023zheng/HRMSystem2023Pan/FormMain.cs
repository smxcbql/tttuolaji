using HRMSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2023Pan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            if(fl.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
            
            LoginUser lu = LoginUser.GetInstance();
            if(!lu.IsAdmin)
            {
                tsmiAdmin.Visible = false;
            }
            tsslshow.Text = string.Format("欢迎{0}使用系统，登录时间是{1}", lu.RealName, DateTime.Now);
        }

       

        

        private void tsmiLogQuery_Click(object sender, EventArgs e)
        {
            FormLogQuery flq = new FormLogQuery();
            flq.MdiParent = this;
            flq.Show();
        }

        private void tsmimovedata_Click(object sender, EventArgs e)
        {
            Formmovedata fmd = new Formmovedata();
            fmd.MdiParent = this;
            fmd.Show();
        }

        private void tsmikist_Click(object sender, EventArgs e)
        {
            FormEmployeeList fe = new FormEmployeeList();
            fe.MdiParent = this;
            fe.Show();
        }

        private void tsmidesearch_Click(object sender, EventArgs e)
        {
            FormDepartmentsearch fd = new FormDepartmentsearch();
            fd.MdiParent = this;
            fd.Show();
        }

        private void tsmichange_Click(object sender, EventArgs e)
        {
            FormDepartmentchange fd = new FormDepartmentchange();
            fd.MdiParent = this;
            fd.Show();
        }

        private void tsmisalary_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmisalarycreate_Click(object sender, EventArgs e)
        {
            FormSalary fs = new FormSalary();
            fs.MdiParent = this;
            fs.Show();
        }

        private void tsmisalaryexplort_Click(object sender, EventArgs e)
        {
            FormSalaryExport fe = new FormSalaryExport();
            fe.MdiParent = this;
            fe.Show();
        }

        private void 操作员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiadd_Click(object sender, EventArgs e)
        {
            FormAdduser f = new FormAdduser();
            f.MdiParent = this;
            f.Show();
        }

        private void tsmidelete_Click(object sender, EventArgs e)
        {
            FormDeleteUser f = new FormDeleteUser();
            f.MdiParent = this;
            f.Show();
        }

        private void tsmilocked_Click(object sender, EventArgs e)
        {
            FormLockUser f = new FormLockUser();
            f.MdiParent = this;
            f.Show();
        }

        private void tsmisearchuser_Click(object sender, EventArgs e)
        {
            FormSearchUser f = new FormSearchUser();
            f.MdiParent = this;
            f.Show();
        }

        private void tsmichangepwd_Click(object sender, EventArgs e)
        {
            FormChangePwd f = new FormChangePwd();
            f.MdiParent = this;
            f.Show();
        }
    }
}
