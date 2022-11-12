namespace QuanLyKho
{
    partial class InHangXuat
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
            this.intheoma = new System.Windows.Forms.Button();
            this.inds = new System.Windows.Forms.Button();
            this.cbout = new System.Windows.Forms.ComboBox();
            this.report_out = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng Nhập";
            // 
            // intheoma
            // 
            this.intheoma.Location = new System.Drawing.Point(594, 12);
            this.intheoma.Name = "intheoma";
            this.intheoma.Size = new System.Drawing.Size(192, 40);
            this.intheoma.TabIndex = 1;
            this.intheoma.Text = "In Hàng";
            this.intheoma.UseVisualStyleBackColor = true;
            this.intheoma.Click += new System.EventHandler(this.intheoma_Click);
            // 
            // inds
            // 
            this.inds.Location = new System.Drawing.Point(594, 71);
            this.inds.Name = "inds";
            this.inds.Size = new System.Drawing.Size(192, 38);
            this.inds.TabIndex = 2;
            this.inds.Text = "In DS Hàng";
            this.inds.UseVisualStyleBackColor = true;
            this.inds.Click += new System.EventHandler(this.inds_Click);
            // 
            // cbout
            // 
            this.cbout.FormattingEnabled = true;
            this.cbout.Location = new System.Drawing.Point(235, 29);
            this.cbout.Name = "cbout";
            this.cbout.Size = new System.Drawing.Size(321, 24);
            this.cbout.TabIndex = 3;
            // 
            // report_out
            // 
            this.report_out.Location = new System.Drawing.Point(42, 141);
            this.report_out.Name = "report_out";
            this.report_out.Size = new System.Drawing.Size(1189, 468);
            this.report_out.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1185, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InHangXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.report_out);
            this.Controls.Add(this.cbout);
            this.Controls.Add(this.inds);
            this.Controls.Add(this.intheoma);
            this.Controls.Add(this.label1);
            this.Name = "InHangXuat";
            this.Text = "InHangXuat";
            this.Load += new System.EventHandler(this.InHangXuat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button intheoma;
        private System.Windows.Forms.Button inds;
        private System.Windows.Forms.ComboBox cbout;
        private Microsoft.Reporting.WinForms.ReportViewer report_out;
        private System.Windows.Forms.Button button1;
    }
}