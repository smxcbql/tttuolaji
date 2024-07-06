using HRMSystem.BLL;
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
    public partial class FormSalary : Form
    {
        public FormSalary()
        {
            InitializeComponent();
        }

        private void FormSalary_Load(object sender, EventArgs e)
        {
            DepartmentService ds = new DepartmentService();
            comboBoxdepartment.ValueMember = "Id";
            comboBoxdepartment.DisplayMember = "Name";
            comboBoxdepartment.DataSource = ds.GetAllDepartments();
            comboBoxdepartment.SelectedIndex = -1;
            DataTable months = new DataTable();
            months.Columns.Add("Mouth");
            months.Columns.Add("Value");
            for (int i = 1; i <= 12; i++)
            {
                DataRow dr = months.NewRow();
                dr["Mouth"] = i.ToString();
                dr["Value"] = i;
                months.Rows.Add(dr);
            }
            comboBoxmonth.DataSource = months;
            comboBoxmonth.DisplayMember = "Month";
            comboBoxmonth.ValueMember = "Value";
            comboBoxmonth.SelectedIndex = -1;

            DataTable years = new DataTable();
            years.Columns.Add("Year");
            years.Columns.Add("Value");
            for (int i = 2012; i <= 2032; i++)
            {
                DataRow dr = years.NewRow();
                dr["Year"] = i.ToString();
                dr["Value"] = i;
                years.Rows.Add(dr);
            }
            comboBoxyear.DataSource = years;
            comboBoxyear.DisplayMember = "Year";
            comboBoxyear.ValueMember = "Value";
            comboBoxyear.SelectedIndex = -1;

        }

        private void buttonsalary_Click(object sender, EventArgs e)
        {
            if(comboBoxdepartment.SelectedIndex==-1||comboBoxmonth.SelectedIndex==-1||comboBoxyear.SelectedIndex==-1)
            {
                CommonHelper.ShowErrorMessageBox("请选择正确的年月以及部门！");
                return;
            }
            SalarySheet sheet = new SalarySheet();
            sheet.Id = Guid.NewGuid();
            sheet.Month = Convert.ToInt32(comboBoxmonth.SelectedValue);
            sheet.Year = Convert.ToInt32(comboBoxyear.SelectedValue);
            sheet.DepartmentId = (Guid)comboBoxdepartment.SelectedValue;

            EmptyJudge ej = new EmptyJudge();
            if(!ej.isEmployeeExist(sheet.DepartmentId))
            {
                CommonHelper.ShowErrorMessageBox("该部门没有员工！");
                return;
            }
            SalarySheetService sss = new SalarySheetService();
            SalarySheetItemService ssis = new SalarySheetItemService();

            if (!ej.isSheetExist(sheet.Month, sheet.Year, sheet.DepartmentId))
            {
                Guid sheetId = sss.BuildNewSalarySheet(sheet);
                ssis.BuildSalarySheetItems(sheetId, sheet.DepartmentId);
                dataGridView1.DataSource = ssis.GetSalarySheetItems(sheetId);
            }
            else
            {
                DialogResult dr = CommonHelper.ShowChooseMessageBox("该工资表此前已经生成过了,按'是'显示原有表数据,按'否'重新生成新表");
                if (dr == DialogResult.Yes)
                {
                    Guid sheetId = sss.GetSalarySheetId(sheet.Month, sheet.Year, sheet.DepartmentId);
                    dataGridView1.DataSource = ssis.GetSalarySheetItems(sheetId);
                }
                else if (dr == DialogResult.No)
                {
                    DialogResult drr = CommonHelper.ShowChooseMessageBox("确认是否重新生成新表?(此操作不可撤回)");
                    if (drr == DialogResult.Yes)
                    {
                        Guid sheetId = sss.GetSalarySheetId(sheet.Month, sheet.Year, sheet.DepartmentId);
                        ssis.ReBuildSalarySheetItem(sheetId);
                        dataGridView1.DataSource = ssis.GetSalarySheetItems(sss.GetSalarySheetId(sheet.Month, sheet.Year, sheet.DepartmentId));
                    }
                    else
                    {
                        Guid sheetId = sss.GetSalarySheetId(sheet.Month, sheet.Year, sheet.DepartmentId);
                        dataGridView1.DataSource = ssis.GetSalarySheetItems(sheetId);
                    }
                }
            }
            }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SalarySheetItemService ssis = new SalarySheetItemService();
            SalarySheetItem item = null;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                item = new SalarySheetItem();
                item.Id = (Guid)dataGridView1.Rows[i].Cells[0].Value;
                item.BaseSalary = (decimal)dataGridView1.Rows[i].Cells[2].Value;
                item.Bonus = (decimal)dataGridView1.Rows[i].Cells[3].Value;
                item.Fine = (decimal)dataGridView1.Rows[i].Cells[4].Value;
                item.Other = (decimal)dataGridView1.Rows[i].Cells[5].Value;
                ssis.SaveSheetItem(item);
            }
            CommonHelper.ShowSuccessMessageBox("工资单保存成功!");
        }
    }
}
