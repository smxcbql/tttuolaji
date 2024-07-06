namespace HRMSystem2023Pan
{
    partial class FormEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxdepartment = new System.Windows.Forms.ComboBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.checkBoxtime = new System.Windows.Forms.CheckBox();
            this.checkBoxdepartment = new System.Windows.Forms.CheckBox();
            this.checkBoxname = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonadd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonedit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtondelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonexport = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonsearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxdepartment);
            this.groupBox1.Controls.Add(this.textBoxname);
            this.groupBox1.Controls.Add(this.checkBoxtime);
            this.groupBox1.Controls.Add(this.checkBoxdepartment);
            this.groupBox1.Controls.Add(this.checkBoxname);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(302, 80);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(103, 33);
            this.buttonsearch.TabIndex = 8;
            this.buttonsearch.Text = "搜索";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "到";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(551, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 21);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(387, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // comboBoxdepartment
            // 
            this.comboBoxdepartment.FormattingEnabled = true;
            this.comboBoxdepartment.Location = new System.Drawing.Point(75, 80);
            this.comboBoxdepartment.Name = "comboBoxdepartment";
            this.comboBoxdepartment.Size = new System.Drawing.Size(123, 20);
            this.comboBoxdepartment.TabIndex = 4;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(74, 35);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(125, 21);
            this.textBoxname.TabIndex = 3;
            // 
            // checkBoxtime
            // 
            this.checkBoxtime.AutoSize = true;
            this.checkBoxtime.Location = new System.Drawing.Point(302, 37);
            this.checkBoxtime.Name = "checkBoxtime";
            this.checkBoxtime.Size = new System.Drawing.Size(72, 16);
            this.checkBoxtime.TabIndex = 2;
            this.checkBoxtime.Text = "入职时间";
            this.checkBoxtime.UseVisualStyleBackColor = true;
            // 
            // checkBoxdepartment
            // 
            this.checkBoxdepartment.AutoSize = true;
            this.checkBoxdepartment.Location = new System.Drawing.Point(20, 84);
            this.checkBoxdepartment.Name = "checkBoxdepartment";
            this.checkBoxdepartment.Size = new System.Drawing.Size(48, 16);
            this.checkBoxdepartment.TabIndex = 1;
            this.checkBoxdepartment.Text = "部门";
            this.checkBoxdepartment.UseVisualStyleBackColor = true;
            // 
            // checkBoxname
            // 
            this.checkBoxname.AutoSize = true;
            this.checkBoxname.Location = new System.Drawing.Point(20, 37);
            this.checkBoxname.Name = "checkBoxname";
            this.checkBoxname.Size = new System.Drawing.Size(48, 16);
            this.checkBoxname.TabIndex = 0;
            this.checkBoxname.Text = "姓名";
            this.checkBoxname.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(770, 181);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonadd,
            this.toolStripButtonedit,
            this.toolStripButtondelete,
            this.toolStripButtonexport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonadd
            // 
            this.toolStripButtonadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonadd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonadd.Image")));
            this.toolStripButtonadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonadd.Name = "toolStripButtonadd";
            this.toolStripButtonadd.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonadd.Text = "添加";
            this.toolStripButtonadd.Click += new System.EventHandler(this.toolStripButtonadd_Click);
            // 
            // toolStripButtonedit
            // 
            this.toolStripButtonedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonedit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonedit.Image")));
            this.toolStripButtonedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonedit.Name = "toolStripButtonedit";
            this.toolStripButtonedit.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonedit.Text = "编辑";
            this.toolStripButtonedit.Click += new System.EventHandler(this.toolStripButtonedit_Click);
            // 
            // toolStripButtondelete
            // 
            this.toolStripButtondelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtondelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtondelete.Image")));
            this.toolStripButtondelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtondelete.Name = "toolStripButtondelete";
            this.toolStripButtondelete.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtondelete.Text = "删除";
            this.toolStripButtondelete.Click += new System.EventHandler(this.toolStripButtondelete_Click);
            // 
            // toolStripButtonexport
            // 
            this.toolStripButtonexport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonexport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonexport.Image")));
            this.toolStripButtonexport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonexport.Name = "toolStripButtonexport";
            this.toolStripButtonexport.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonexport.Text = "导出excel表";
            this.toolStripButtonexport.Click += new System.EventHandler(this.toolStripButtonexport_Click);
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 380);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEmployeeList";
            this.Text = "员工列表";
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxtime;
        private System.Windows.Forms.CheckBox checkBoxdepartment;
        private System.Windows.Forms.CheckBox checkBoxname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxdepartment;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonadd;
        private System.Windows.Forms.ToolStripButton toolStripButtonedit;
        private System.Windows.Forms.ToolStripButton toolStripButtondelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonexport;
    }
}