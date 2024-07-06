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
    public partial class FormDepartmentchange : Form
    {
        public FormDepartmentchange()
        {
            InitializeComponent();
        }

        private void FormDepartmentchange_Load(object sender, EventArgs e)
        {
            DepartmentService dts = new DepartmentService();
            comboBoxdepartment.DataSource = dts.GetAllDepartments();
            comboBoxdepartment.ValueMember = "Id";
            comboBoxdepartment.DisplayMember = "Name";
            comboBoxdepartment.SelectedValue = -1;
        }

        private void buttonchange_Click(object sender, EventArgs e)
        {
            string name = textBoxname.Text.Trim();
            string dname = comboBoxdepartment.Text;
            DepartmentService.Change(name, dname);
        }
    }
}
