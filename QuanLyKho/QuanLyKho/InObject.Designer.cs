namespace QuanLyKho
{
    partial class InObject
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
            this.cbmh = new System.Windows.Forms.ComboBox();
            this.intt = new System.Windows.Forms.Button();
            this.indstt = new System.Windows.Forms.Button();
            this.report_ob = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng";
            // 
            // cbmh
            // 
            this.cbmh.FormattingEnabled = true;
            this.cbmh.Location = new System.Drawing.Point(227, 29);
            this.cbmh.Name = "cbmh";
            this.cbmh.Size = new System.Drawing.Size(168, 24);
            this.cbmh.TabIndex = 1;
            // 
            // intt
            // 
            this.intt.Location = new System.Drawing.Point(506, 12);
            this.intt.Name = "intt";
            this.intt.Size = new System.Drawing.Size(163, 23);
            this.intt.TabIndex = 2;
            this.intt.Text = "In tổng tiền";
            this.intt.UseVisualStyleBackColor = true;
            this.intt.Click += new System.EventHandler(this.intt_Click);
            // 
            // indstt
            // 
            this.indstt.Location = new System.Drawing.Point(506, 62);
            this.indstt.Name = "indstt";
            this.indstt.Size = new System.Drawing.Size(163, 23);
            this.indstt.TabIndex = 3;
            this.indstt.Text = "In DS tổng tiền";
            this.indstt.UseVisualStyleBackColor = true;
            this.indstt.Click += new System.EventHandler(this.indstt_Click);
            // 
            // report_ob
            // 
            this.report_ob.DocumentMapWidth = 62;
            this.report_ob.Location = new System.Drawing.Point(12, 106);
            this.report_ob.Name = "report_ob";
            this.report_ob.Size = new System.Drawing.Size(952, 361);
            this.report_ob.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.report_ob);
            this.Controls.Add(this.indstt);
            this.Controls.Add(this.intt);
            this.Controls.Add(this.cbmh);
            this.Controls.Add(this.label1);
            this.Name = "InObject";
            this.Text = "InObject";
            this.Load += new System.EventHandler(this.InObject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmh;
        private System.Windows.Forms.Button intt;
        private System.Windows.Forms.Button indstt;
        private Microsoft.Reporting.WinForms.ReportViewer report_ob;
        private System.Windows.Forms.Button button1;
    }
}