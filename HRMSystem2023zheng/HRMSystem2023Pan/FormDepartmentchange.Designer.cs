namespace HRMSystem2023Pan
{
    partial class FormDepartmentchange
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
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonchange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxdepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(236, 123);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(185, 28);
            this.textBoxname.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "员工姓名：";
            // 
            // buttonchange
            // 
            this.buttonchange.Location = new System.Drawing.Point(200, 273);
            this.buttonchange.Name = "buttonchange";
            this.buttonchange.Size = new System.Drawing.Size(190, 70);
            this.buttonchange.TabIndex = 13;
            this.buttonchange.Text = "更换员工所属部门";
            this.buttonchange.UseVisualStyleBackColor = true;
            this.buttonchange.Click += new System.EventHandler(this.buttonchange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "更改部门：";
            // 
            // comboBoxdepartment
            // 
            this.comboBoxdepartment.FormattingEnabled = true;
            this.comboBoxdepartment.Location = new System.Drawing.Point(236, 185);
            this.comboBoxdepartment.Name = "comboBoxdepartment";
            this.comboBoxdepartment.Size = new System.Drawing.Size(184, 26);
            this.comboBoxdepartment.TabIndex = 16;
            // 
            // FormDepartmentchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 467);
            this.Controls.Add(this.comboBoxdepartment);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonchange);
            this.Controls.Add(this.label2);
            this.Name = "FormDepartmentchange";
            this.Text = "部门变更";
            this.Load += new System.EventHandler(this.FormDepartmentchange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxdepartment;
    }
}