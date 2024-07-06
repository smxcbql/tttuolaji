namespace HRMSystem2023Pan
{
    partial class FormAdduser
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
            this.textBoxRealNameAdd = new System.Windows.Forms.TextBox();
            this.textBoxPasswordAdd = new System.Windows.Forms.TextBox();
            this.textBoxUserNameAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRealNameAdd
            // 
            this.textBoxRealNameAdd.Location = new System.Drawing.Point(182, 193);
            this.textBoxRealNameAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRealNameAdd.Name = "textBoxRealNameAdd";
            this.textBoxRealNameAdd.Size = new System.Drawing.Size(319, 28);
            this.textBoxRealNameAdd.TabIndex = 14;
            // 
            // textBoxPasswordAdd
            // 
            this.textBoxPasswordAdd.Location = new System.Drawing.Point(182, 114);
            this.textBoxPasswordAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPasswordAdd.Name = "textBoxPasswordAdd";
            this.textBoxPasswordAdd.Size = new System.Drawing.Size(319, 28);
            this.textBoxPasswordAdd.TabIndex = 13;
            // 
            // textBoxUserNameAdd
            // 
            this.textBoxUserNameAdd.Location = new System.Drawing.Point(182, 38);
            this.textBoxUserNameAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUserNameAdd.Name = "textBoxUserNameAdd";
            this.textBoxUserNameAdd.Size = new System.Drawing.Size(319, 28);
            this.textBoxUserNameAdd.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "密码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "用户名:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(158, 274);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(267, 110);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAdduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 422);
            this.Controls.Add(this.textBoxRealNameAdd);
            this.Controls.Add(this.textBoxPasswordAdd);
            this.Controls.Add(this.textBoxUserNameAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormAdduser";
            this.Text = "添加用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRealNameAdd;
        private System.Windows.Forms.TextBox textBoxPasswordAdd;
        private System.Windows.Forms.TextBox textBoxUserNameAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
    }
}