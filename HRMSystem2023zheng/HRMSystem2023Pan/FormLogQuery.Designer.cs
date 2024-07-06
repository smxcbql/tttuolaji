namespace HRMSystem2023Pan
{
    partial class FormLogQuery
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
            this.dgvLogList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelperpage = new System.Windows.Forms.LinkLabel();
            this.linkLabelnextpage = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelfirstpage = new System.Windows.Forms.LinkLabel();
            this.linkLabellastpage = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxname = new System.Windows.Forms.ComboBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxtime = new System.Windows.Forms.CheckBox();
            this.checkBoxname = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogList
            // 
            this.dgvLogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogList.Location = new System.Drawing.Point(35, 165);
            this.dgvLogList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLogList.Name = "dgvLogList";
            this.dgvLogList.RowTemplate.Height = 23;
            this.dgvLogList.Size = new System.Drawing.Size(1201, 479);
            this.dgvLogList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 668);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "共0页";
            // 
            // linkLabelperpage
            // 
            this.linkLabelperpage.AutoSize = true;
            this.linkLabelperpage.Location = new System.Drawing.Point(956, 668);
            this.linkLabelperpage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelperpage.Name = "linkLabelperpage";
            this.linkLabelperpage.Size = new System.Drawing.Size(62, 18);
            this.linkLabelperpage.TabIndex = 2;
            this.linkLabelperpage.TabStop = true;
            this.linkLabelperpage.Text = "上一页";
            this.linkLabelperpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelperpage_LinkClicked);
            // 
            // linkLabelnextpage
            // 
            this.linkLabelnextpage.AutoSize = true;
            this.linkLabelnextpage.Location = new System.Drawing.Point(1064, 668);
            this.linkLabelnextpage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelnextpage.Name = "linkLabelnextpage";
            this.linkLabelnextpage.Size = new System.Drawing.Size(62, 18);
            this.linkLabelnextpage.TabIndex = 3;
            this.linkLabelnextpage.TabStop = true;
            this.linkLabelnextpage.Text = "下一页";
            this.linkLabelnextpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelnextpage_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 668);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "当前第1页";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabelfirstpage
            // 
            this.linkLabelfirstpage.AutoSize = true;
            this.linkLabelfirstpage.Location = new System.Drawing.Point(836, 668);
            this.linkLabelfirstpage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelfirstpage.Name = "linkLabelfirstpage";
            this.linkLabelfirstpage.Size = new System.Drawing.Size(44, 18);
            this.linkLabelfirstpage.TabIndex = 5;
            this.linkLabelfirstpage.TabStop = true;
            this.linkLabelfirstpage.Text = "首页";
            this.linkLabelfirstpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelfirstpage_LinkClicked);
            // 
            // linkLabellastpage
            // 
            this.linkLabellastpage.AutoSize = true;
            this.linkLabellastpage.Location = new System.Drawing.Point(1175, 668);
            this.linkLabellastpage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabellastpage.Name = "linkLabellastpage";
            this.linkLabellastpage.Size = new System.Drawing.Size(44, 18);
            this.linkLabellastpage.TabIndex = 6;
            this.linkLabellastpage.TabStop = true;
            this.linkLabellastpage.Text = "尾页";
            this.linkLabellastpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabellastpage_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxname);
            this.groupBox1.Controls.Add(this.buttonsearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkBoxtime);
            this.groupBox1.Controls.Add(this.checkBoxname);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 146);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // comboBoxname
            // 
            this.comboBoxname.FormattingEnabled = true;
            this.comboBoxname.Location = new System.Drawing.Point(203, 23);
            this.comboBoxname.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxname.Name = "comboBoxname";
            this.comboBoxname.Size = new System.Drawing.Size(182, 26);
            this.comboBoxname.TabIndex = 18;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(636, 89);
            this.buttonsearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(154, 50);
            this.buttonsearch.TabIndex = 17;
            this.buttonsearch.Text = "搜索";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(820, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "到";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(876, 24);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 28);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(630, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 28);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // checkBoxtime
            // 
            this.checkBoxtime.AutoSize = true;
            this.checkBoxtime.Location = new System.Drawing.Point(503, 28);
            this.checkBoxtime.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxtime.Name = "checkBoxtime";
            this.checkBoxtime.Size = new System.Drawing.Size(106, 22);
            this.checkBoxtime.TabIndex = 11;
            this.checkBoxtime.Text = "日期范围";
            this.checkBoxtime.UseVisualStyleBackColor = true;
            // 
            // checkBoxname
            // 
            this.checkBoxname.AutoSize = true;
            this.checkBoxname.Location = new System.Drawing.Point(80, 28);
            this.checkBoxname.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxname.Name = "checkBoxname";
            this.checkBoxname.Size = new System.Drawing.Size(70, 22);
            this.checkBoxname.TabIndex = 9;
            this.checkBoxname.Text = "姓名";
            this.checkBoxname.UseVisualStyleBackColor = true;
            // 
            // FormLogQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabellastpage);
            this.Controls.Add(this.linkLabelfirstpage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabelnextpage);
            this.Controls.Add(this.linkLabelperpage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLogList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogQuery";
            this.Text = "日志查询";
            this.Load += new System.EventHandler(this.FormLogQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelperpage;
        private System.Windows.Forms.LinkLabel linkLabelnextpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelfirstpage;
        private System.Windows.Forms.LinkLabel linkLabellastpage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxname;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxtime;
        private System.Windows.Forms.CheckBox checkBoxname;
    }
}