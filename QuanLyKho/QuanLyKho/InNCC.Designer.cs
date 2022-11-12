namespace QuanLyKho
{
    partial class InNCC
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
            this.cbncc = new System.Windows.Forms.ComboBox();
            this.report_ncc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.innhacc = new System.Windows.Forms.Button();
            this.inds = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà CC";
            // 
            // cbncc
            // 
            this.cbncc.FormattingEnabled = true;
            this.cbncc.Location = new System.Drawing.Point(273, 26);
            this.cbncc.Name = "cbncc";
            this.cbncc.Size = new System.Drawing.Size(257, 24);
            this.cbncc.TabIndex = 1;
            // 
            // report_ncc
            // 
            this.report_ncc.Location = new System.Drawing.Point(25, 113);
            this.report_ncc.Name = "report_ncc";
            this.report_ncc.Size = new System.Drawing.Size(1064, 431);
            this.report_ncc.TabIndex = 2;
            // 
            // innhacc
            // 
            this.innhacc.Location = new System.Drawing.Point(598, 12);
            this.innhacc.Name = "innhacc";
            this.innhacc.Size = new System.Drawing.Size(197, 34);
            this.innhacc.TabIndex = 3;
            this.innhacc.Text = "In Nhà Cung Cấp";
            this.innhacc.UseVisualStyleBackColor = true;
            this.innhacc.Click += new System.EventHandler(this.innhacc_Click);
            // 
            // inds
            // 
            this.inds.Location = new System.Drawing.Point(598, 62);
            this.inds.Name = "inds";
            this.inds.Size = new System.Drawing.Size(197, 31);
            this.inds.TabIndex = 4;
            this.inds.Text = "In Danh Sách Nhà Cấp Cung";
            this.inds.UseVisualStyleBackColor = true;
            this.inds.Click += new System.EventHandler(this.inds_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1032, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inds);
            this.Controls.Add(this.innhacc);
            this.Controls.Add(this.report_ncc);
            this.Controls.Add(this.cbncc);
            this.Controls.Add(this.label1);
            this.Name = "InNCC";
            this.Text = "InNCC";
            this.Load += new System.EventHandler(this.InNCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbncc;
        private Microsoft.Reporting.WinForms.ReportViewer report_ncc;
        private System.Windows.Forms.Button innhacc;
        private System.Windows.Forms.Button inds;
        private System.Windows.Forms.Button button1;
    }
}