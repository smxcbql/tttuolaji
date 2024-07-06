using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using HRMSystem.DAL;
using HRMSystem.Model;
using HRMSystem.BLL;

namespace HRMSystem2023Pan
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string un = textBoxName.Text.Trim();
            string pwd = textBoxPassword.Text.Trim();

            SystemGuard sg = new SystemGuard();
            UserType ut = sg.Check(un, CommonHelper.GetMD5(pwd));

            if (ut == UserType.NoUser)
            {
                CommonHelper.ShowErrorMessageBox("用户不存在！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if(ut == UserType.PasswordError)
            {
                CommonHelper.ShowErrorMessageBox("密码不正确！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (ut == UserType.Deleted)
            {
                CommonHelper.ShowErrorMessageBox("用户已删除！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (ut == UserType.Locked)
            {
                CommonHelper.ShowErrorMessageBox("用户已锁定！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {

                CommonHelper.ShowSuccessMessageBox("登陆成功！");
                this.DialogResult = DialogResult.OK;
            }

       
            
        }
    }
}
