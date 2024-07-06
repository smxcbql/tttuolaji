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
    public partial class FormDeleteUser : Form
    {
        public FormDeleteUser()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            OperatorService opSev = new OperatorService();
            if (opSev.DeleteOperator(textBoxUserName.Text))
            {
                CommonHelper.ShowSuccessMessageBox("删除成功!");
                textBoxUserName.Clear();
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("无此用户,删除失败!");
            }
        }
    }
}
