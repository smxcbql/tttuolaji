namespace HRMSystem2023Pan
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslshow = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiuser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiadd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmilocked = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisearchuser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimovedata = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiemployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmikist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmichange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisalary = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisalarycreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisalaryexplort = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmielse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmichangepwd = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslshow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 834);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1506, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslshow
            // 
            this.tsslshow.Name = "tsslshow";
            this.tsslshow.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.tsmiemployee,
            this.tsmidepartment,
            this.tsmisalary,
            this.tsmielse});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1506, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiuser,
            this.tsmiLogQuery,
            this.tsmimovedata});
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(76, 28);
            this.tsmiAdmin.Text = "管理员";
            // 
            // tsmiuser
            // 
            this.tsmiuser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiadd,
            this.tsmidelete,
            this.tsmilocked,
            this.tsmisearchuser});
            this.tsmiuser.Name = "tsmiuser";
            this.tsmiuser.Size = new System.Drawing.Size(210, 30);
            this.tsmiuser.Text = "用户管理";
            this.tsmiuser.Click += new System.EventHandler(this.操作员管理ToolStripMenuItem_Click);
            // 
            // tsmiadd
            // 
            this.tsmiadd.Name = "tsmiadd";
            this.tsmiadd.Size = new System.Drawing.Size(128, 30);
            this.tsmiadd.Text = "添加";
            this.tsmiadd.Click += new System.EventHandler(this.tsmiadd_Click);
            // 
            // tsmidelete
            // 
            this.tsmidelete.Name = "tsmidelete";
            this.tsmidelete.Size = new System.Drawing.Size(128, 30);
            this.tsmidelete.Text = "删除";
            this.tsmidelete.Click += new System.EventHandler(this.tsmidelete_Click);
            // 
            // tsmilocked
            // 
            this.tsmilocked.Name = "tsmilocked";
            this.tsmilocked.Size = new System.Drawing.Size(128, 30);
            this.tsmilocked.Text = "锁定";
            this.tsmilocked.Click += new System.EventHandler(this.tsmilocked_Click);
            // 
            // tsmisearchuser
            // 
            this.tsmisearchuser.Name = "tsmisearchuser";
            this.tsmisearchuser.Size = new System.Drawing.Size(128, 30);
            this.tsmisearchuser.Text = "查询";
            this.tsmisearchuser.Click += new System.EventHandler(this.tsmisearchuser_Click);
            // 
            // tsmiLogQuery
            // 
            this.tsmiLogQuery.Name = "tsmiLogQuery";
            this.tsmiLogQuery.Size = new System.Drawing.Size(210, 30);
            this.tsmiLogQuery.Text = "查询日志";
            this.tsmiLogQuery.Click += new System.EventHandler(this.tsmiLogQuery_Click);
            // 
            // tsmimovedata
            // 
            this.tsmimovedata.Name = "tsmimovedata";
            this.tsmimovedata.Size = new System.Drawing.Size(210, 30);
            this.tsmimovedata.Text = "数据迁移";
            this.tsmimovedata.Click += new System.EventHandler(this.tsmimovedata_Click);
            // 
            // tsmiemployee
            // 
            this.tsmiemployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmikist});
            this.tsmiemployee.Name = "tsmiemployee";
            this.tsmiemployee.Size = new System.Drawing.Size(94, 28);
            this.tsmiemployee.Text = "员工管理";
            // 
            // tsmikist
            // 
            this.tsmikist.Name = "tsmikist";
            this.tsmikist.Size = new System.Drawing.Size(210, 30);
            this.tsmikist.Text = "员工列表";
            this.tsmikist.Click += new System.EventHandler(this.tsmikist_Click);
            // 
            // tsmidepartment
            // 
            this.tsmidepartment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmisearch,
            this.tsmichange});
            this.tsmidepartment.Name = "tsmidepartment";
            this.tsmidepartment.Size = new System.Drawing.Size(94, 28);
            this.tsmidepartment.Text = "部门管理";
            // 
            // tsmisearch
            // 
            this.tsmisearch.Name = "tsmisearch";
            this.tsmisearch.Size = new System.Drawing.Size(210, 30);
            this.tsmisearch.Text = "查询";
            this.tsmisearch.Click += new System.EventHandler(this.tsmidesearch_Click);
            // 
            // tsmichange
            // 
            this.tsmichange.Name = "tsmichange";
            this.tsmichange.Size = new System.Drawing.Size(210, 30);
            this.tsmichange.Text = "部门变更";
            this.tsmichange.Click += new System.EventHandler(this.tsmichange_Click);
            // 
            // tsmisalary
            // 
            this.tsmisalary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmisalarycreate,
            this.tsmisalaryexplort});
            this.tsmisalary.Name = "tsmisalary";
            this.tsmisalary.Size = new System.Drawing.Size(112, 28);
            this.tsmisalary.Text = "工资单管理";
            this.tsmisalary.Click += new System.EventHandler(this.tsmisalary_Click);
            // 
            // tsmisalarycreate
            // 
            this.tsmisalarycreate.Name = "tsmisalarycreate";
            this.tsmisalarycreate.Size = new System.Drawing.Size(210, 30);
            this.tsmisalarycreate.Text = "工资单生成";
            this.tsmisalarycreate.Click += new System.EventHandler(this.tsmisalarycreate_Click);
            // 
            // tsmisalaryexplort
            // 
            this.tsmisalaryexplort.Name = "tsmisalaryexplort";
            this.tsmisalaryexplort.Size = new System.Drawing.Size(210, 30);
            this.tsmisalaryexplort.Text = "工资单导出";
            this.tsmisalaryexplort.Click += new System.EventHandler(this.tsmisalaryexplort_Click);
            // 
            // tsmielse
            // 
            this.tsmielse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmichangepwd});
            this.tsmielse.Name = "tsmielse";
            this.tsmielse.Size = new System.Drawing.Size(58, 28);
            this.tsmielse.Text = "其他";
            // 
            // tsmichangepwd
            // 
            this.tsmichangepwd.Name = "tsmichangepwd";
            this.tsmichangepwd.Size = new System.Drawing.Size(210, 30);
            this.tsmichangepwd.Text = "修改密码";
            this.tsmichangepwd.Click += new System.EventHandler(this.tsmichangepwd_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 856);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "人力资源管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslshow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiuser;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmielse;
        private System.Windows.Forms.ToolStripMenuItem tsmimovedata;
        private System.Windows.Forms.ToolStripMenuItem tsmiemployee;
        private System.Windows.Forms.ToolStripMenuItem tsmikist;
        private System.Windows.Forms.ToolStripMenuItem tsmidepartment;
        private System.Windows.Forms.ToolStripMenuItem tsmisearch;
        private System.Windows.Forms.ToolStripMenuItem tsmichange;
        private System.Windows.Forms.ToolStripMenuItem tsmisalary;
        private System.Windows.Forms.ToolStripMenuItem tsmisalarycreate;
        private System.Windows.Forms.ToolStripMenuItem tsmisalaryexplort;
        private System.Windows.Forms.ToolStripMenuItem tsmiadd;
        private System.Windows.Forms.ToolStripMenuItem tsmidelete;
        private System.Windows.Forms.ToolStripMenuItem tsmilocked;
        private System.Windows.Forms.ToolStripMenuItem tsmisearchuser;
        private System.Windows.Forms.ToolStripMenuItem tsmichangepwd;
    }
}