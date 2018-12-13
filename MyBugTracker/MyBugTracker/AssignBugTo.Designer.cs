namespace MyBugTracker
{
    partial class AssignBugTo
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
            this.label4 = new System.Windows.Forms.Label();
            this.label_BugID = new System.Windows.Forms.Label();
            this.label_bugTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_bugID = new System.Windows.Forms.TextBox();
            this.textBox_BugTitle = new System.Windows.Forms.TextBox();
            this.comboBox_assign = new System.Windows.Forms.ComboBox();
            this.btn_appoint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 438);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(70, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 48);
            this.label4.TabIndex = 1;
            this.label4.Text = "Assign Bugs";
            // 
            // label_BugID
            // 
            this.label_BugID.AutoSize = true;
            this.label_BugID.BackColor = System.Drawing.Color.Transparent;
            this.label_BugID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_BugID.Location = new System.Drawing.Point(565, 28);
            this.label_BugID.Name = "label_BugID";
            this.label_BugID.Size = new System.Drawing.Size(61, 21);
            this.label_BugID.TabIndex = 34;
            this.label_BugID.Text = "Bug ID";
            // 
            // label_bugTitle
            // 
            this.label_bugTitle.AutoSize = true;
            this.label_bugTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_bugTitle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_bugTitle.Location = new System.Drawing.Point(565, 92);
            this.label_bugTitle.Name = "label_bugTitle";
            this.label_bugTitle.Size = new System.Drawing.Size(75, 21);
            this.label_bugTitle.TabIndex = 35;
            this.label_bugTitle.Text = "Bug Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Assign To ";
            // 
            // textBox_bugID
            // 
            this.textBox_bugID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_bugID.Location = new System.Drawing.Point(766, 28);
            this.textBox_bugID.Name = "textBox_bugID";
            this.textBox_bugID.ReadOnly = true;
            this.textBox_bugID.Size = new System.Drawing.Size(189, 27);
            this.textBox_bugID.TabIndex = 37;
            // 
            // textBox_BugTitle
            // 
            this.textBox_BugTitle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_BugTitle.Location = new System.Drawing.Point(766, 92);
            this.textBox_BugTitle.Name = "textBox_BugTitle";
            this.textBox_BugTitle.ReadOnly = true;
            this.textBox_BugTitle.Size = new System.Drawing.Size(189, 27);
            this.textBox_BugTitle.TabIndex = 38;
            // 
            // comboBox_assign
            // 
            this.comboBox_assign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_assign.FormattingEnabled = true;
            this.comboBox_assign.Items.AddRange(new object[] {
            "--Select--"});
            this.comboBox_assign.Location = new System.Drawing.Point(766, 144);
            this.comboBox_assign.Name = "comboBox_assign";
            this.comboBox_assign.Size = new System.Drawing.Size(189, 29);
            this.comboBox_assign.TabIndex = 39;
            this.comboBox_assign.SelectedIndexChanged += new System.EventHandler(this.comboBox_assign_SelectedIndexChanged);
            // 
            // btn_appoint
            // 
            this.btn_appoint.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_appoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appoint.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_appoint.Location = new System.Drawing.Point(722, 186);
            this.btn_appoint.Name = "btn_appoint";
            this.btn_appoint.Size = new System.Drawing.Size(98, 32);
            this.btn_appoint.TabIndex = 40;
            this.btn_appoint.Text = "Assign";
            this.btn_appoint.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(865, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 41;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 223);
            this.dataGridView1.TabIndex = 42;
            // 
            // AssignBugTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_appoint);
            this.Controls.Add(this.comboBox_assign);
            this.Controls.Add(this.textBox_BugTitle);
            this.Controls.Add(this.textBox_bugID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_bugTitle);
            this.Controls.Add(this.label_BugID);
            this.Controls.Add(this.panel1);
            this.Name = "AssignBugTo";
            this.Text = "AssignBugTo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_BugID;
        private System.Windows.Forms.Label label_bugTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_bugID;
        private System.Windows.Forms.TextBox textBox_BugTitle;
        private System.Windows.Forms.ComboBox comboBox_assign;
        private System.Windows.Forms.Button btn_appoint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}