namespace MyBugTracker
{
    partial class FixedBug
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_fixed = new System.Windows.Forms.DataGridView();
            this.button_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fixed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 453);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-6, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "View Bug History";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_fixed
            // 
            this.dgv_fixed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fixed.Location = new System.Drawing.Point(292, 2);
            this.dgv_fixed.Name = "dgv_fixed";
            this.dgv_fixed.Size = new System.Drawing.Size(510, 391);
            this.dgv_fixed.TabIndex = 11;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Navy;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_close.Location = new System.Drawing.Point(682, 416);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(93, 31);
            this.button_close.TabIndex = 12;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // FixedBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 459);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.dgv_fixed);
            this.Controls.Add(this.panel1);
            this.Name = "FixedBug";
            this.Text = "FixedBug";
            this.Load += new System.EventHandler(this.FixedBug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fixed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_fixed;
        private System.Windows.Forms.Button button_close;
    }
}