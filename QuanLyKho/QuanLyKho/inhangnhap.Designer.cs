namespace QuanLyKho
{
    partial class inhangnhap
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
            this.cbin = new System.Windows.Forms.ComboBox();
            this.inone = new System.Windows.Forms.Button();
            this.inds = new System.Windows.Forms.Button();
            this.report_in = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng Nhập";
            // 
            // cbin
            // 
            this.cbin.FormattingEnabled = true;
            this.cbin.Location = new System.Drawing.Point(280, 28);
            this.cbin.Name = "cbin";
            this.cbin.Size = new System.Drawing.Size(251, 24);
            this.cbin.TabIndex = 1;
            // 
            // inone
            // 
            this.inone.Location = new System.Drawing.Point(575, 32);
            this.inone.Name = "inone";
            this.inone.Size = new System.Drawing.Size(191, 23);
            this.inone.TabIndex = 2;
            this.inone.Text = "In Hàng Nhập";
            this.inone.UseVisualStyleBackColor = true;
            this.inone.Click += new System.EventHandler(this.inone_Click);
            // 
            // inds
            // 
            this.inds.Location = new System.Drawing.Point(575, 76);
            this.inds.Name = "inds";
            this.inds.Size = new System.Drawing.Size(191, 23);
            this.inds.TabIndex = 3;
            this.inds.Text = "In DS hàng nhập";
            this.inds.UseVisualStyleBackColor = true;
            this.inds.Click += new System.EventHandler(this.inds_Click);
            // 
            // report_in
            // 
            this.report_in.Location = new System.Drawing.Point(12, 120);
            this.report_in.Name = "report_in";
            this.report_in.Size = new System.Drawing.Size(1032, 394);
            this.report_in.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(965, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inhangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.report_in);
            this.Controls.Add(this.inds);
            this.Controls.Add(this.inone);
            this.Controls.Add(this.cbin);
            this.Controls.Add(this.label1);
            this.Name = "inhangnhap";
            this.Text = "inhangnhap";
            this.Load += new System.EventHandler(this.inhangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbin;
        private System.Windows.Forms.Button inone;
        private System.Windows.Forms.Button inds;
        private Microsoft.Reporting.WinForms.ReportViewer report_in;
        private System.Windows.Forms.Button button1;
    }
}