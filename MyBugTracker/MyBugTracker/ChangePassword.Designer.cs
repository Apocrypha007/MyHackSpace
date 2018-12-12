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
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1533, 100);
            this.panel1.TabIndex = 2;
            // 
            // userDashboardLabel
            // 
            this.userDashboardLabel.AutoSize = true;
            this.userDashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDashboardLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userDashboardLabel.Location = new System.Drawing.Point(471, 20);
            this.userDashboardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userDashboardLabel.Name = "userDashboardLabel";
            this.userDashboardLabel.Size = new System.Drawing.Size(374, 48);
            this.userDashboardLabel.TabIndex = 0;
            this.userDashboardLabel.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(222, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 40);
            this.label2.TabIndex = 27;
            this.label2.Text = "Old Password";
            // 
            // txt_oldpwd
            // 
            this.txt_oldpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_oldpwd.Location = new System.Drawing.Point(607, 205);
            this.txt_oldpwd.Margin = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.txt_oldpwd.Name = "txt_oldpwd";
            this.txt_oldpwd.PasswordChar = '*';
            this.txt_oldpwd.Size = new System.Drawing.Size(842, 45);
            this.txt_oldpwd.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(222, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 40);
            this.label1.TabIndex = 32;
            this.label1.Text = "New Password";
            // 
            // txt_newPwd
            // 
            this.txt_newPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_newPwd.Location = new System.Drawing.Point(607, 310);
            this.txt_newPwd.Margin = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.txt_newPwd.Name = "txt_newPwd";
            this.txt_newPwd.PasswordChar = '*';
            this.txt_newPwd.Size = new System.Drawing.Size(842, 45);
            this.txt_newPwd.TabIndex = 33;
            this.txt_newPwd.TextChanged += new System.EventHandler(this.txt_newPwd_TextChanged);
            // 
            // buttonChangePwd
            // 
            this.buttonChangePwd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangePwd.Location = new System.Drawing.Point(483, 424);
            this.buttonChangePwd.Margin = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.buttonChangePwd.Name = "buttonChangePwd";
            this.buttonChangePwd.Size = new System.Drawing.Size(499, 94);
            this.buttonChangePwd.TabIndex = 34;
            this.buttonChangePwd.Text = "Confirm";
            this.buttonChangePwd.UseVisualStyleBackColor = false;
            this.buttonChangePwd.Click += new System.EventHandler(this.buttonChangePwd_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1540, 553);
            this.Controls.Add(this.buttonChangePwd);
            this.Controls.Add(this.txt_newPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_oldpwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
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