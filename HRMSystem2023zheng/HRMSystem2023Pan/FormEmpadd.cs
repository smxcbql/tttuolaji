using HRMSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2023Pan
{
    public partial class FormEmpadd : Form
    {
        Guid empid = Guid.Empty;
        Employee emp = new Employee();
        public FormEmpadd()
        {
            InitializeComponent();
        }
        public FormEmpadd(Guid a)
        {
            InitializeComponent();
            empid = a;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void FormEmpadd_Load(object sender, EventArgs e)
        {
            DictService ds = new DictService();
            comboBoxsex.DisplayMember = "Name";
            comboBoxsex.ValueMember = "Id";
            comboBoxsex.DataSource = ds.GetComboList("性别");
            comboBoxsex.SelectedIndex = -1;
            comboBoxmarrige.DisplayMember = "Name";
            comboBoxmarrige.ValueMember = "Id";
            comboBoxmarrige.DataSource = ds.GetComboList("婚姻状况");
            comboBoxmarrige.SelectedIndex = -1;
            comboBoxzhengzhimm.DisplayMember = "Name";
            comboBoxzhengzhimm.ValueMember = "Id";
            comboBoxzhengzhimm.DataSource = ds.GetComboList("政治面貌");
            comboBoxzhengzhimm.SelectedIndex = -1;
            comboBoxxueli.DisplayMember = "Name";
            comboBoxxueli.ValueMember = "Id";
            comboBoxxueli.DataSource = ds.GetComboList("学历");
            comboBoxxueli.SelectedIndex = -1;
            DepartmentService deptSer = new DepartmentService();
            comboBoxdepartment.ValueMember = "Id";
            comboBoxdepartment.DisplayMember = "Name";
            comboBoxdepartment.DataSource = deptSer.GetAllDepartments();
            comboBoxdepartment.SelectedIndex = -1;
            if (empid != Guid.Empty)
            {
                EmployeeService es = new EmployeeService();
                emp = es.GetEmpById(empid);
                textBoxname.Text = emp.Name;
                textBoxminzu.Text = emp.Nation;
                textBoxnumble.Text = emp.Number;
                textBoxdizhi.Text = emp.Address;
                textBoxjiguan.Text = emp.NativePlace;
                textBoxemail.Text = emp.Email;
                textBoxphone.Text = emp.Telephone;
                richTextBox1.Text = emp.Resume;
                richTextBoxbeizhu.Text = emp.Remarks;
                comboBoxdepartment.SelectedValue = emp.DepartmentId;
                comboBoxsex.SelectedValue = emp.GenderId;
                comboBoxmarrige.SelectedValue = emp.MarriageId;
                comboBoxzhengzhimm.SelectedValue = emp.PartyId;
                comboBoxxueli.SelectedValue = emp.EducationId;
                MemoryStream ms = new MemoryStream(emp.Photo);
                pictureBox1.Image = new Bitmap(ms);
            }
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("请输入姓名!");
                return;
            }
            else
            {
                emp.Name = textBoxname.Text;
            }
            if (textBoxminzu.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("请输入民族!");
                return;
            }
            else
            {
                emp.Nation = textBoxminzu.Text;
            }
            if (textBoxemail.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("请输入电子邮箱!");
                return;
            }
            else
            {
                emp.Email = textBoxemail.Text;
            }
            if (textBoxjiguan.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("请输入籍贯!");
                return;
            }
            else
            {
                emp.NativePlace = textBoxjiguan.Text;
            }
            if (textBoxnumble.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("请输入工号!");
                return;
            }
            else
            {
                emp.Number = textBoxnumble.Text;
            }
            if (textBoxdizhi.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("请输入联系地址!");
                return;
            }
            else
            {
                emp.Address = textBoxdizhi.Text;
            }
            if (textBoxphone.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("请输入联系电话!");
                return;
            }
            else
            {
                emp.Telephone = textBoxphone.Text;
            }
            if (richTextBoxbeizhu.Text == "")
            {
                emp.Remarks = "";
            }
            else
            {
                emp.Remarks = richTextBoxbeizhu.Text;
            }
            if (richTextBox1.Text == "")
            {
                emp.Resume = "";
            }
            else
            {
                emp.Resume = richTextBox1.Text;
            }
            emp.GenderId = (Guid)comboBoxsex.SelectedValue;
            emp.MarriageId = (Guid)comboBoxmarrige.SelectedValue;
            emp.PartyId = (Guid)comboBoxzhengzhimm.SelectedValue;
            emp.EducationId = (Guid)comboBoxxueli.SelectedValue;
            emp.DepartmentId = (Guid)comboBoxdepartment.SelectedValue;
            emp.BirthDay = dateTimePickerbirth.Value;
            emp.InDay = dateTimePickerruzhi.Value;
            emp.Id = Guid.NewGuid();
            if (emp.Photo == null)
            {
                CommonHelper.ShowErrorMessageBox("请选择照片!");
                return;
            }
            EmployeeService es = new EmployeeService();
            if (empid == Guid.Empty)
            {
                if (es.InsertEmployee(emp))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    CommonHelper.ShowErrorMessageBox("保存失败!");
                }
            }
            else
            {
                if (es.updateEmployee(emp, empid))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    CommonHelper.ShowErrorMessageBox("修改失败!");
                }
            }

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonchoose_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG图片|*.jpg|BMP图片|*.bmp|Gif图片|*.gif";
                ofd.ShowDialog();
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                emp.Photo = new byte[fs.Length];
                fs.Read(emp.Photo, 0, Convert.ToInt32(fs.Length));
            }
            catch (Exception ex)
            {
                CommonHelper.ShowErrorMessageBox("请选择图片");
            }

        }
    }
}
