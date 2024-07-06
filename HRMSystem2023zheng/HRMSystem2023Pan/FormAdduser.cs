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
    public partial class FormAdduser : Form
    {
        public FormAdduser()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OperatorService opSev = new OperatorService();
            if (opSev.InsertOperator(textBoxPasswordAdd.Text, CommonHelper.GetMD5(textBoxRealNameAdd.Text), textBoxUserNameAdd.Text))
            {
                CommonHelper.ShowSuccessMessageBox("添加成功!");
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("添加失败!");
            }
        }
    }
}
