namespace MyBugTracker
{
    partial class AddBugSolution
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
            this.lbl_bugID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_header = new System.Windows.Forms.Label();
            this.lbl_project = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_desc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_bugTitle = new System.Windows.Forms.Label();
            this.lbl_bugDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_reportDate = new System.Windows.Forms.Label();
            this.txtBox_bugID = new System.Windows.Forms.TextBox();
            this.txtboxProject = new System.Windows.Forms.TextBox();
            this.txt_bugtitle = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.reportDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBox_status = new System.Windows.Forms.ComboBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.txt_bugsol = new System.Windows.Forms.TextBox();
            this.solvedate = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.button_cls = new System.Windows.Forms.Button();
            this.dgv_sol = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sol)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bugID
            // 
            this.lbl_bugID.AutoSize = true;
            this.lbl_bugID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugID.Location = new System.Drawing.Point(16, 66);
            this.lbl_bugID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_bugID.Name = "lbl_bugID";
            this.lbl_bugID.Size = new System.Drawing.Size(61, 21);
            this.lbl_bugID.TabIndex = 48;
            this.lbl_bugID.Text = "Bug ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 47);
            this.panel1.TabIndex = 49;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_header.Location = new System.Drawing.Point(391, 7);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(222, 31);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Add Bug Solution";
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_project.Location = new System.Drawing.Point(16, 104);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(64, 21);
            this.lbl_project.TabIndex = 53;
            this.lbl_project.Text = "Project";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(16, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "Bug Title";
            // 
            // txtbox_desc
            // 
            this.txtbox_desc.AutoSize = true;
            this.txtbox_desc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbox_desc.Location = new System.Drawing.Point(16, 191);
            this.txtbox_desc.Name = "txtbox_desc";
            this.txtbox_desc.Size = new System.Drawing.Size(89, 21);
            this.txtbox_desc.TabIndex = 65;
            this.txtbox_desc.Text = "Error code";
            this.txtbox_desc.Click += new System.EventHandler(this.txtbox_desc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 67;
            this.label5.Text = "Report Date\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(21, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Status";
            // 
            // lbl_bugTitle
            // 
            this.lbl_bugTitle.AutoSize = true;
            this.lbl_bugTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugTitle.Location = new System.Drawing.Point(590, 62);
            this.lbl_bugTitle.Name = "lbl_bugTitle";
            this.lbl_bugTitle.Size = new System.Drawing.Size(49, 21);
            this.lbl_bugTitle.TabIndex = 72;
            this.lbl_bugTitle.Text = "Class";
            // 
            // lbl_bugDescription
            // 
            this.lbl_bugDescription.AutoSize = true;
            this.lbl_bugDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugDescription.Location = new System.Drawing.Point(590, 107);
            this.lbl_bugDescription.Name = "lbl_bugDescription";
            this.lbl_bugDescription.Size = new System.Drawing.Size(73, 21);
            this.lbl_bugDescription.TabIndex = 73;
            this.lbl_bugDescription.Text = "Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 74;
            this.label2.Text = "Line no.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(590, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 75;
            this.label4.Text = "Solved code";
            // 
            // lbl_reportDate
            // 
            this.lbl_reportDate.AutoSize = true;
            this.lbl_reportDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reportDate.Location = new System.Drawing.Point(590, 342);
            this.lbl_reportDate.Name = "lbl_reportDate";
            this.lbl_reportDate.Size = new System.Drawing.Size(94, 21);
            this.lbl_reportDate.TabIndex = 76;
            this.lbl_reportDate.Text = "Solve date";
            this.lbl_reportDate.Click += new System.EventHandler(this.lbl_reportDate_Click);
            // 
            // txtBox_bugID
            // 
            this.txtBox_bugID.Location = new System.Drawing.Point(156, 67);
            this.txtBox_bugID.Name = "txtBox_bugID";
            this.txtBox_bugID.ReadOnly = true;
            this.txtBox_bugID.Size = new System.Drawing.Size(136, 20);
            this.txtBox_bugID.TabIndex = 77;
            // 
            // txtboxProject
            // 
            this.txtboxProject.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtboxProject.Location = new System.Drawing.Point(156, 104);
            this.txtboxProject.Name = "txtboxProject";
            this.txtboxProject.ReadOnly = true;
            this.txtboxProject.Size = new System.Drawing.Size(309, 24);
            this.txtboxProject.TabIndex = 78;
            // 
            // txt_bugtitle
            // 
            this.txt_bugtitle.BackColor = System.Drawing.SystemColors.Control;
            this.txt_bugtitle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_bugtitle.Location = new System.Drawing.Point(156, 144);
            this.txt_bugtitle.Name = "txt_bugtitle";
            this.txt_bugtitle.ReadOnly = true;
            this.txt_bugtitle.Size = new System.Drawing.Size(309, 24);
            this.txt_bugtitle.TabIndex = 79;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(156, 194);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.ReadOnly = true;
            this.txtdes.Size = new System.Drawing.Size(309, 134);
            this.txtdes.TabIndex = 80;
            this.txtdes.TextChanged += new System.EventHandler(this.txtdes_TextChanged);
            // 
            // reportDate
            // 
            this.reportDate.Checked = false;
            this.reportDate.CustomFormat = "yyyy-MM-dd";
            this.reportDate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.reportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportDate.Location = new System.Drawing.Point(156, 339);
            this.reportDate.Name = "reportDate";
            this.reportDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportDate.Size = new System.Drawing.Size(200, 24);
            this.reportDate.TabIndex = 81;
            this.reportDate.Value = new System.DateTime(2018, 11, 9, 0, 0, 0, 0);
            // 
            // cmbBox_status
            // 
            this.cmbBox_status.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbBox_status.FormattingEnabled = true;
            this.cmbBox_status.Items.AddRange(new object[] {
            "active",
            "solved"});
            this.cmbBox_status.Location = new System.Drawing.Point(156, 380);
            this.cmbBox_status.Name = "cmbBox_status";
            this.cmbBox_status.Size = new System.Drawing.Size(309, 25);
            this.cmbBox_status.TabIndex = 82;
            // 
            // txt_class
            // 
            this.txt_class.BackColor = System.Drawing.SystemColors.Control;
            this.txt_class.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_class.Location = new System.Drawing.Point(752, 63);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(309, 24);
            this.txt_class.TabIndex = 83;
            this.txt_class.TextChanged += new System.EventHandler(this.txt_class_TextChanged);
            // 
            // txt_method
            // 
            this.txt_method.BackColor = System.Drawing.SystemColors.Control;
            this.txt_method.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_method.Location = new System.Drawing.Point(752, 104);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(309, 27);
            this.txt_method.TabIndex = 84;
            // 
            // txt_line
            // 
            this.txt_line.BackColor = System.Drawing.SystemColors.Control;
            this.txt_line.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_line.Location = new System.Drawing.Point(752, 147);
            this.txt_line.Name = "txt_line";
            this.txt_line.Size = new System.Drawing.Size(309, 24);
            this.txt_line.TabIndex = 85;
            // 
            // txt_bugsol
            // 
            this.txt_bugsol.BackColor = System.Drawing.SystemColors.Control;
            this.txt_bugsol.Location = new System.Drawing.Point(752, 191);
            this.txt_bugsol.Multiline = true;
            this.txt_bugsol.Name = "txt_bugsol";
            this.txt_bugsol.Size = new System.Drawing.Size(309, 129);
            this.txt_bugsol.TabIndex = 86;
            // 
            // solvedate
            // 
            this.solvedate.Checked = false;
            this.solvedate.CustomFormat = "yyyy-MM-dd";
            this.solvedate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.solvedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.solvedate.Location = new System.Drawing.Point(752, 336);
            this.solvedate.Name = "solvedate";
            this.solvedate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.solvedate.Size = new System.Drawing.Size(200, 24);
            this.solvedate.TabIndex = 87;
            this.solvedate.Value = new System.DateTime(2018, 11, 9, 0, 0, 0, 0);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(877, 371);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 34);
            this.btn_save.TabIndex = 88;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button_cls
            // 
            this.button_cls.BackColor = System.Drawing.Color.Red;
            this.button_cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cls.Location = new System.Drawing.Point(980, 371);
            this.button_cls.Name = "button_cls";
            this.button_cls.Size = new System.Drawing.Size(81, 34);
            this.button_cls.TabIndex = 89;
            this.button_cls.Text = "Close";
            this.button_cls.UseVisualStyleBackColor = false;
            this.button_cls.Click += new System.EventHandler(this.button_cls_Click);
            // 
            // dgv_sol
            // 
            this.dgv_sol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sol.Location = new System.Drawing.Point(3, 411);
            this.dgv_sol.Name = "dgv_sol";
            this.dgv_sol.Size = new System.Drawing.Size(1058, 290);
            this.dgv_sol.TabIndex = 90;
            this.dgv_sol.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_sol_RowHeaderMouseClick);
            // 
            // AddBugSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 707);
            this.Controls.Add(this.dgv_sol);
            this.Controls.Add(this.button_cls);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.solvedate);
            this.Controls.Add(this.txt_bugsol);
            this.Controls.Add(this.txt_line);
            this.Controls.Add(this.txt_method);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.cmbBox_status);
            this.Controls.Add(this.reportDate);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txt_bugtitle);
            this.Controls.Add(this.txtboxProject);
            this.Controls.Add(this.txtBox_bugID);
            this.Controls.Add(this.lbl_reportDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_bugDescription);
            this.Controls.Add(this.lbl_bugTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_desc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_project);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_bugID);
            this.Name = "AddBugSolution";
            this.Text = "AddBugSolution";
            this.Load += new System.EventHandler(this.AddBugSolution_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bugID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label lbl_project;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtbox_desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_bugTitle;
        private System.Windows.Forms.Label lbl_bugDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_reportDate;
        private System.Windows.Forms.TextBox txtBox_bugID;
        private System.Windows.Forms.TextBox txtboxProject;
        private System.Windows.Forms.TextBox txt_bugtitle;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.DateTimePicker reportDate;
        private System.Windows.Forms.ComboBox cmbBox_status;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.TextBox txt_bugsol;
        private System.Windows.Forms.DateTimePicker solvedate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button_cls;
        private System.Windows.Forms.DataGridView dgv_sol;
    }
}