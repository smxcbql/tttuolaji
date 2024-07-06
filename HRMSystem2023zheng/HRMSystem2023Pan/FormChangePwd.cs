using HRMSystem.BLL;
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
    public partial class FormChangePwd : Form
    {
        public FormChangePwd()
        {
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
                    
            LoginUser lu = LoginUser.GetInstance();
            if (lu.Password.Equals(CommonHelper.GetMD5(textBoxbefore.Text)))
            {
                OperatorService op = new OperatorService();
                op.PwdModify(lu.UserName, CommonHelper.GetMD5(textBoxnow.Text));
                lu.Password = CommonHelper.GetMD5(textBoxnow.Text);
                CommonHelper.ShowSuccessMessageBox("密码修改成功，请重新登录！");
                Application.Restart();
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("原密码输入错误!");
            }
        }

    }
}

