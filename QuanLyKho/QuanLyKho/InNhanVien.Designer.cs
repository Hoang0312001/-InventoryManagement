namespace QuanLyKho
{
    partial class InNhanVien
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
            this.report_nv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.innv = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // report_nv
            // 
            this.report_nv.Location = new System.Drawing.Point(24, 154);
            this.report_nv.Name = "report_nv";
            this.report_nv.Size = new System.Drawing.Size(1104, 405);
            this.report_nv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // cbnv
            // 
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(343, 61);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(272, 24);
            this.cbnv.TabIndex = 2;
            // 
            // innv
            // 
            this.innv.Location = new System.Drawing.Point(645, 42);
            this.innv.Name = "innv";
            this.innv.Size = new System.Drawing.Size(197, 23);
            this.innv.TabIndex = 3;
            this.innv.Text = "In Nhân Viên";
            this.innv.UseVisualStyleBackColor = true;
            this.innv.Click += new System.EventHandler(this.innv_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "In Danh Sách Nhân Viên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1059, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.innv);
            this.Controls.Add(this.cbnv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.report_nv);
            this.Name = "InNhanVien";
            this.Text = "InNhanVien";
            this.Load += new System.EventHandler(this.InNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_nv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.Button innv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}