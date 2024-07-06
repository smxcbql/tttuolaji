namespace HRMSystem2023Pan
{
    partial class FormChangePwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxbefore = new System.Windows.Forms.TextBox();
            this.textBoxnow = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // textBoxbefore
            // 
            this.textBoxbefore.Location = new System.Drawing.Point(133, 68);
            this.textBoxbefore.Name = "textBoxbefore";
            this.textBoxbefore.Size = new System.Drawing.Size(311, 28);
            this.textBoxbefore.TabIndex = 2;
            // 
            // textBoxnow
            // 
            this.textBoxnow.Location = new System.Drawing.Point(133, 167);
            this.textBoxnow.Name = "textBoxnow";
            this.textBoxnow.Size = new System.Drawing.Size(311, 28);
            this.textBoxnow.TabIndex = 3;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(133, 279);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(243, 95);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "修改";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // FormChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 435);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxnow);
            this.Controls.Add(this.textBoxbefore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangePwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxbefore;
        private System.Windows.Forms.TextBox textBoxnow;
        private System.Windows.Forms.Button buttonChange;
    }
}