using HRMSystem.DAL;
using HRMSystem2023Pan;
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

namespace HRMSystem2023Pan
{
    public partial class Formmovedata : Form
    {
        public Formmovedata()
        {
            InitializeComponent();
        }

        private void buttonmove_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
           if(OperationLogService.MoveData(dt))
            {
                CommonHelper.ShowSuccessMessageBox("迁移成功！");
            }
           else
            {
                CommonHelper.ShowErrorMessageBox("迁移失败！");
            }


        }
    }
}
