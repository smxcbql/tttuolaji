using HRMSystem.BLL;
using HRMSystem.DAL;
using HRMSystem.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class FormSalaryExport : Form
    {
        public FormSalaryExport()
        {
            InitializeComponent();
        }

        private void FormSalaryExport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
         
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
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxmonth.SelectedIndex == -1 || comboBoxyear.SelectedIndex == -1 || comboBoxdepartment.SelectedIndex == -1)
            {
                CommonHelper.ShowErrorMessageBox("请选择正确的年份,月份和部门");
                return;
            }

            SalarySheetService sss = new SalarySheetService();
            SalarySheet sheet = new SalarySheet();
            sheet.Month = Convert.ToInt32(comboBoxmonth.SelectedValue);
            sheet.Year = Convert.ToInt32(comboBoxyear.SelectedValue);
            sheet.DepartmentId = (Guid)comboBoxdepartment.SelectedValue;
            sheet.Id = sss.GetSalarySheetId(sheet.Month, sheet.Year, sheet.DepartmentId);
            EmptyJudge ej = new EmptyJudge();
            SalarySheetItemService ssis = new SalarySheetItemService();
            if (ej.isSheetExist(sheet.Month, sheet.Year, sheet.DepartmentId))
            {

                DataTable dt1 = new DataTable();
                dt1 = ssis.GetReportSheet(sheet.Id);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt1));
                reportViewer1.RefreshReport();
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("该工资单尚未生成!");
            }
        }
    }
}

