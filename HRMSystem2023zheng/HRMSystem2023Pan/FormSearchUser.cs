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
    public partial class FormSearchUser : Form
    {
        public FormSearchUser()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OperatorService opSev = new OperatorService();
            Operator op = opSev.GetOperator(textBoxUserName.Text);
            if (op != null)
            {
                CommonHelper.ShowSuccessMessageBox("查询成功!");
                labelUserName.Text = "用户名:" + op.UserName;
                labelId.Text = "Id:" + op.Id;
                labelIsDeleted.Text = "是否被删除:" + op.IsDeleted;
                labelIsLocked.Text = "是否被锁定:" + op.IsLocked;
                labelRealName.Text = "姓名:" + op.RealName;
                labelPassword.Text = "密码:" + op.Password;
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("无此用户,查询失败!");
            }
        }
    }
}
