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
    public partial class FormLockUser : Form
    {
        public FormLockUser()
        {
            InitializeComponent();
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            OperatorService opSev = new OperatorService();
            if (opSev.LockOperator(textBoxUserName.Text))
            {
                CommonHelper.ShowSuccessMessageBox("锁定成功!");
                textBoxUserName.Clear();
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("无此用户,锁定失败!");
            }
        }
    }
}
