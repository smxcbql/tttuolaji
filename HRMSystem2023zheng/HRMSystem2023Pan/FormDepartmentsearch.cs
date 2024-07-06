using HRMSystem.DAL;
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
    public partial class FormDepartmentsearch : Form
    {
        public FormDepartmentsearch()
        {
            InitializeComponent();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            string name = textBoxname.Text.Trim();
            string Dname = DepartmentService.Search(name);
            if (Dname == null)
            { label2.Text = "未找到该员工或暂未分管部门！"; }
            else
            { label2.Text = "所属部门是：" + Dname; }
        }
    }
}
