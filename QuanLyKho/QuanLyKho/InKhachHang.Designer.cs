namespace QuanLyKho
{
    partial class InKhachHang
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
            this.report_kh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbkh = new System.Windows.Forms.ComboBox();
            this.In1nguoi = new System.Windows.Forms.Button();
            this.Inall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // report_kh
            // 
            this.report_kh.Location = new System.Drawing.Point(12, 166);
            this.report_kh.Name = "report_kh";
            this.report_kh.Size = new System.Drawing.Size(1022, 386);
            this.report_kh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // cbkh
            // 
            this.cbkh.FormattingEnabled = true;
            this.cbkh.Location = new System.Drawing.Point(251, 47);
            this.cbkh.Name = "cbkh";
            this.cbkh.Size = new System.Drawing.Size(227, 24);
            this.cbkh.TabIndex = 2;
            // 
            // In1nguoi
            // 
            this.In1nguoi.Location = new System.Drawing.Point(601, 38);
            this.In1nguoi.Name = "In1nguoi";
            this.In1nguoi.Size = new System.Drawing.Size(139, 23);
            this.In1nguoi.TabIndex = 3;
            this.In1nguoi.Text = "In Hoa Don";
            this.In1nguoi.UseVisualStyleBackColor = true;
            this.In1nguoi.Click += new System.EventHandler(this.In1nguoi_Click);
            // 
            // Inall
            // 
            this.Inall.Location = new System.Drawing.Point(601, 81);
            this.Inall.Name = "Inall";
            this.Inall.Size = new System.Drawing.Size(139, 31);
            this.Inall.TabIndex = 4;
            this.Inall.Text = "In All Customer";
            this.Inall.UseVisualStyleBackColor = true;
            this.Inall.Click += new System.EventHandler(this.Inall_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(973, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Inall);
            this.Controls.Add(this.In1nguoi);
            this.Controls.Add(this.cbkh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.report_kh);
            this.Name = "InKhachHang";
            this.Text = "InKhachHang";
            this.Load += new System.EventHandler(this.InKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_kh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbkh;
        private System.Windows.Forms.Button In1nguoi;
        private System.Windows.Forms.Button Inall;
        private System.Windows.Forms.Button button1;
    }
}