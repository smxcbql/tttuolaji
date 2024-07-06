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
    public partial class FormLogQuery : Form
    {
        private const int NUMS_PER_PAGE = 10;
        private int currentPage = 0;
        private int pages = 0;
        private OperationLogService logServ = null;
        public FormLogQuery()
        {
            logServ = new OperationLogService();
            InitializeComponent();
        }

        private void show(int pageNo)
        {

            label1.Text = string.Format("共{0}页", pages);
            label2.Text = string.Format("第{0}页", currentPage);
            dgvLogList.DataSource = logServ.GetOperationLogList(pageNo, NUMS_PER_PAGE);
        }

        private void FormLogQuery_Load(object sender, EventArgs e)
        {

            pages = logServ.GetLogCount() / NUMS_PER_PAGE + 1;
            dgvLogList.AllowUserToAddRows = false;
            dgvLogList.ReadOnly = true;
            dgvLogList.Height = NUMS_PER_PAGE * dgvLogList.RowTemplate.Height + dgvLogList.ColumnHeadersHeight;
            currentPage = 1;
            show(currentPage);
            comboBoxname.DataSource=logServ.GetAllName();
            comboBoxname.DisplayMember = "RealName";
            comboBoxname.ValueMember = "Id";
            comboBoxname.SelectedIndex = -1;
        }
        
        private void linkLabelperpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPage = Math.Max(currentPage - 1, 1);
            show(currentPage);

        }

        private void linkLabelnextpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPage = Math.Min(currentPage + 1, pages);
            show(currentPage);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelfirstpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPage = 1;
            show(currentPage);
        }

        private void linkLabellastpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPage = pages;
            show(currentPage);
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            OperationLogService os = new OperationLogService();
            OperationLogSearch ols = new OperationLogSearch();
            if (checkBoxname.Checked)
            {
                if (checkBoxname.Text == "")
                {
                    CommonHelper.ShowErrorMessageBox("请输入姓名！");
                }
                else
                {
                    ols.RealName =comboBoxname.Text;
                }
            }
            if (checkBoxtime.Checked)
            {
                ols.ExistDate = true;
                ols.InDateFrom = dateTimePicker1.Value;
                ols.InDateTo = dateTimePicker2.Value;
            }
            dgvLogList.DataSource = os.GetOperationLogList(ols);
        }
    }
}
