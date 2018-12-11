namespace MyBugTracker
{
    partial class ChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userDashboardLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_oldpwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_newPwd = new System.Windows.Forms.TextBox();
            this.buttonChangePwd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.userDashboardLabel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 45);
            this.panel1.TabIndex = 2;
            // 
            // userDashboardLabel
            // 
            this.userDashboardLabel.AutoSize = true;
            this.userDashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDashboardLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userDashboardLabel.Location = new System.Drawing.Point(202, 9);
            this.userDashboardLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.userDashboardLabel.Name = "userDashboardLabel";
            this.userDashboardLabel.Size = new System.Drawing.Size(179, 24);
            this.userDashboardLabel.TabIndex = 0;
            this.userDashboardLabel.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(95, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Old Password";
            // 
            // txt_oldpwd
            // 
            this.txt_oldpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_oldpwd.Location = new System.Drawing.Point(260, 92);
            this.txt_oldpwd.Margin = new System.Windows.Forms.Padding(7);
            this.txt_oldpwd.Name = "txt_oldpwd";
            this.txt_oldpwd.Size = new System.Drawing.Size(363, 24);
            this.txt_oldpwd.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(95, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "New Password";
            // 
            // txt_newPwd
            // 
            this.txt_newPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_newPwd.Location = new System.Drawing.Point(260, 139);
            this.txt_newPwd.Margin = new System.Windows.Forms.Padding(7);
            this.txt_newPwd.Name = "txt_newPwd";
            this.txt_newPwd.Size = new System.Drawing.Size(363, 24);
            this.txt_newPwd.TabIndex = 33;
            this.txt_newPwd.TextChanged += new System.EventHandler(this.txt_newPwd_TextChanged);
            // 
            // buttonChangePwd
            // 
            this.buttonChangePwd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangePwd.Location = new System.Drawing.Point(207, 190);
            this.buttonChangePwd.Margin = new System.Windows.Forms.Padding(7);
            this.buttonChangePwd.Name = "buttonChangePwd";
            this.buttonChangePwd.Size = new System.Drawing.Size(214, 42);
            this.buttonChangePwd.TabIndex = 34;
            this.buttonChangePwd.Text = "Confirm";
            this.buttonChangePwd.UseVisualStyleBackColor = false;
            this.buttonChangePwd.Click += new System.EventHandler(this.buttonChangePwd_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 248);
            this.Controls.Add(this.buttonChangePwd);
            this.Controls.Add(this.txt_newPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_oldpwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userDashboardLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_oldpwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_newPwd;
        private System.Windows.Forms.Button buttonChangePwd;
    }
}