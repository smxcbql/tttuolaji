using HRMSystem.DAL;
using HRMSystem.Model;
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
    public partial class FormEmployeeList : Form
    {
        public FormEmployeeList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            DepartmentService dts = new DepartmentService();
            comboBoxdepartment.DataSource = dts.GetAllDepartments();
            comboBoxdepartment.DisplayMember = "Name";
            comboBoxdepartment.ValueMember = "Id";
            comboBoxdepartment.SelectedIndex = -1;
            dataGridView1.DataSource = EmployeeService.GetEmployeeList();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            EmployeeService ey = new EmployeeService();
            EmployeeSelect emp = new EmployeeSelect();
            if(checkBoxname.Checked)
            {
                if(textBoxname.Text == "")
                {
                    CommonHelper.ShowErrorMessageBox("请输入姓名！");
                }
                else
                {
                    emp.Name = textBoxname.Text.Trim();
                }
            }
            if (checkBoxdepartment.Checked)
            {
                if (comboBoxdepartment.SelectedIndex==-1)
                {
                    CommonHelper.ShowErrorMessageBox("请选择部门！");
                }
                else
                {
                    emp.DepartmentId = (Guid)comboBoxdepartment.SelectedValue;
                }
            }
            if (checkBoxtime.Checked)
            {
                emp.TimeCheck = true;
                emp.Inday1 = dateTimePicker1.Value;
                emp.Inday2 = dateTimePicker2.Value;
            }
            dataGridView1.DataSource = ey.GetEmployeeList(emp);
        }

        private void toolStripButtonadd_Click(object sender, EventArgs e)
        {
            Form fmEmpAdd = new FormEmpadd();
            DialogResult dr = fmEmpAdd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                EmployeeService es = new EmployeeService();
                CommonHelper.ShowSuccessMessageBox("保存成功！");
                dataGridView1.DataSource = EmployeeService.GetEmployeeList();
            }
            else if (dr == DialogResult.Cancel)
            {
                CommonHelper.ShowErrorMessageBox("取消保存！");
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("保存失败！");
            }

        }

        private void toolStripButtonedit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = "";
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (string.IsNullOrEmpty(id))
                {
                    CommonHelper.ShowErrorMessageBox("请先选中员工！");
                }
                else
                {
                    Guid empid = Guid.Parse(id);
                    Form fmEmpAdd = new FormEmpadd(empid);
                    DialogResult dr = fmEmpAdd.ShowDialog();
                    EmployeeService es = new EmployeeService();
                    dataGridView1.DataSource = EmployeeService.GetEmployeeList();
                    if (dr == DialogResult.OK)
                    {
                        CommonHelper.ShowSuccessMessageBox("修改成功!");
                    }
                    else
                    {
                        CommonHelper.ShowErrorMessageBox("取消修改!");
                    }
                }
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("请选中行！");
            }

        }

        private void toolStripButtondelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = "";
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (string.IsNullOrEmpty(id))
                {
                    CommonHelper.ShowErrorMessageBox("请先选中员工！");
                }
                else
                {
                    DialogResult dr=MessageBox.Show("确定要删除该员工吗？","警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    Guid empid = Guid.Parse(id);
                    EmployeeService es = new EmployeeService();
                    if (dr == DialogResult.OK)
                    {
                        if (es.deleteEmployeeById(empid))
                        {
                            CommonHelper.ShowSuccessMessageBox("删除成功!");
                        }
                        else
                        {
                            CommonHelper.ShowErrorMessageBox("删除失败!");
                        }
                    }
                    dataGridView1.DataSource = EmployeeService.GetEmployeeList();
                }
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("请选中行！");
            }

        }

        private void toolStripButtonexport_Click(object sender, EventArgs e)
        {
            ExcelService es = new ExcelService();
            string path = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "保存文件";
            sfd.Filter = "Excel 文件(*.xls)|*.xls|Excel 文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            sfd.FileName = "员工信息.xls";
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                path = sfd.FileName;
            }
            else
            {
                return;
            }
            if(es.CreateExcel(path))
            {
                CommonHelper.ShowSuccessMessageBox("导出成功！");
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("导出失败！");
            }
        }
    }
}
