namespace HRMSystem2023Pan
{
    partial class FormSalary
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
            this.comboBoxyear = new System.Windows.Forms.ComboBox();
            this.comboBoxmonth = new System.Windows.Forms.ComboBox();
            this.comboBoxdepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonsalary = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxyear
            // 
            this.comboBoxyear.FormattingEnabled = true;
            this.comboBoxyear.Location = new System.Drawing.Point(21, 43);
            this.comboBoxyear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxyear.Name = "comboBoxyear";
            this.comboBoxyear.Size = new System.Drawing.Size(163, 20);
            this.comboBoxyear.TabIndex = 0;
            // 
            // comboBoxmonth
            // 
            this.comboBoxmonth.FormattingEnabled = true;
            this.comboBoxmonth.Location = new System.Drawing.Point(247, 43);
            this.comboBoxmonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxmonth.Name = "comboBoxmonth";
            this.comboBoxmonth.Size = new System.Drawing.Size(105, 20);
            this.comboBoxmonth.TabIndex = 1;
            // 
            // comboBoxdepartment
            // 
            this.comboBoxdepartment.FormattingEnabled = true;
            this.comboBoxdepartment.Location = new System.Drawing.Point(456, 47);
            this.comboBoxdepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxdepartment.Name = "comboBoxdepartment";
            this.comboBoxdepartment.Size = new System.Drawing.Size(147, 20);
            this.comboBoxdepartment.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "部门";
            // 
            // buttonsalary
            // 
            this.buttonsalary.Location = new System.Drawing.Point(646, 38);
            this.buttonsalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsalary.Name = "buttonsalary";
            this.buttonsalary.Size = new System.Drawing.Size(104, 27);
            this.buttonsalary.TabIndex = 6;
            this.buttonsalary.Text = "生成工资单";
            this.buttonsalary.UseVisualStyleBackColor = true;
            this.buttonsalary.Click += new System.EventHandler(this.buttonsalary_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(729, 295);
            this.dataGridView1.TabIndex = 7;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(643, 413);
            this.buttonsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(107, 36);
            this.buttonsave.TabIndex = 8;
            this.buttonsave.Text = "保存";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // FormSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 467);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonsalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxdepartment);
            this.Controls.Add(this.comboBoxmonth);
            this.Controls.Add(this.comboBoxyear);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSalary";
            this.Text = "生成工资单";
            this.Load += new System.EventHandler(this.FormSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxyear;
        private System.Windows.Forms.ComboBox comboBoxmonth;
        private System.Windows.Forms.ComboBox comboBoxdepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonsalary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonsave;
    }
}