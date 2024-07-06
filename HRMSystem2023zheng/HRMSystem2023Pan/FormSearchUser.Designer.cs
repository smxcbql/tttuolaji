namespace HRMSystem2023Pan
{
    partial class FormSearchUser
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
            this.labelIsLocked = new System.Windows.Forms.Label();
            this.labelRealName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIsDeleted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIsLocked
            // 
            this.labelIsLocked.AutoSize = true;
            this.labelIsLocked.Location = new System.Drawing.Point(50, 368);
            this.labelIsLocked.Name = "labelIsLocked";
            this.labelIsLocked.Size = new System.Drawing.Size(0, 18);
            this.labelIsLocked.TabIndex = 15;
            // 
            // labelRealName
            // 
            this.labelRealName.AutoSize = true;
            this.labelRealName.Location = new System.Drawing.Point(50, 313);
            this.labelRealName.Name = "labelRealName";
            this.labelRealName.Size = new System.Drawing.Size(0, 18);
            this.labelRealName.TabIndex = 14;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(50, 247);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(0, 18);
            this.labelPassword.TabIndex = 13;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(50, 175);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 18);
            this.labelUserName.TabIndex = 12;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(50, 112);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 18);
            this.labelId.TabIndex = 11;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(557, 26);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 42);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "查询";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(173, 34);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(353, 28);
            this.textBoxUserName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "请输入要查询的用户名:";
            // 
            // labelIsDeleted
            // 
            this.labelIsDeleted.AutoSize = true;
            this.labelIsDeleted.Location = new System.Drawing.Point(50, 448);
            this.labelIsDeleted.Name = "labelIsDeleted";
            this.labelIsDeleted.Size = new System.Drawing.Size(0, 18);
            this.labelIsDeleted.TabIndex = 16;
            // 
            // FormSearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 642);
            this.Controls.Add(this.labelIsDeleted);
            this.Controls.Add(this.labelIsLocked);
            this.Controls.Add(this.labelRealName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label1);
            this.Name = "FormSearchUser";
            this.Text = "查询用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIsLocked;
        private System.Windows.Forms.Label labelRealName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIsDeleted;
    }
}