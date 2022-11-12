namespace QuanLyKho
{
    partial class inhangtrongkho
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
            this.cbkho = new System.Windows.Forms.ComboBox();
            this.in1 = new System.Windows.Forms.Button();
            this.inds = new System.Windows.Forms.Button();
            this.report_kho = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng:";
            // 
            // cbkho
            // 
            this.cbkho.FormattingEnabled = true;
            this.cbkho.Location = new System.Drawing.Point(251, 34);
            this.cbkho.Name = "cbkho";
            this.cbkho.Size = new System.Drawing.Size(279, 24);
            this.cbkho.TabIndex = 1;
            // 
            // in1
            // 
            this.in1.Location = new System.Drawing.Point(572, 35);
            this.in1.Name = "in1";
            this.in1.Size = new System.Drawing.Size(226, 23);
            this.in1.TabIndex = 2;
            this.in1.Text = "In Hang Trong Kho";
            this.in1.UseVisualStyleBackColor = true;
            this.in1.Click += new System.EventHandler(this.in1_Click);
            // 
            // inds
            // 
            this.inds.Location = new System.Drawing.Point(572, 81);
            this.inds.Name = "inds";
            this.inds.Size = new System.Drawing.Size(226, 23);
            this.inds.TabIndex = 3;
            this.inds.Text = "Nhóm Các Mặt Hàng";
            this.inds.UseVisualStyleBackColor = true;
            this.inds.Click += new System.EventHandler(this.inds_Click);
            // 
            // report_kho
            // 
            this.report_kho.Location = new System.Drawing.Point(21, 131);
            this.report_kho.Name = "report_kho";
            this.report_kho.Size = new System.Drawing.Size(1126, 411);
            this.report_kho.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1083, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inhangtrongkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.report_kho);
            this.Controls.Add(this.inds);
            this.Controls.Add(this.in1);
            this.Controls.Add(this.cbkho);
            this.Controls.Add(this.label1);
            this.Name = "inhangtrongkho";
            this.Text = "inhangtrongkho";
            this.Load += new System.EventHandler(this.inhangtrongkho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbkho;
        private System.Windows.Forms.Button in1;
        private System.Windows.Forms.Button inds;
        private Microsoft.Reporting.WinForms.ReportViewer report_kho;
        private System.Windows.Forms.Button button1;
    }
}