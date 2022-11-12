namespace QuanLyKho
{
    partial class KHO
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.cbob = new System.Windows.Forms.ComboBox();
            this.cbemp = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.FIX = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_ob = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.list_kho = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản Lý Kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Hàng \r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng Chứa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsl);
            this.groupBox1.Controls.Add(this.cbob);
            this.groupBox1.Controls.Add(this.cbemp);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(31, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 309);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Dữ Liệu";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(165, 193);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(241, 22);
            this.txtsl.TabIndex = 7;
            // 
            // cbob
            // 
            this.cbob.FormattingEnabled = true;
            this.cbob.Location = new System.Drawing.Point(165, 142);
            this.cbob.Name = "cbob";
            this.cbob.Size = new System.Drawing.Size(243, 24);
            this.cbob.TabIndex = 6;
            // 
            // cbemp
            // 
            this.cbemp.FormattingEnabled = true;
            this.cbemp.Location = new System.Drawing.Point(165, 92);
            this.cbemp.Name = "cbemp";
            this.cbemp.Size = new System.Drawing.Size(243, 24);
            this.cbemp.TabIndex = 5;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(165, 48);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(244, 22);
            this.txtid.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Reset);
            this.groupBox2.Controls.Add(this.FIX);
            this.groupBox2.Controls.Add(this.Sort);
            this.groupBox2.Controls.Add(this.DEL);
            this.groupBox2.Controls.Add(this.ADD);
            this.groupBox2.Location = new System.Drawing.Point(905, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 191);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(120, 133);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "RESET";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // FIX
            // 
            this.FIX.Location = new System.Drawing.Point(190, 29);
            this.FIX.Name = "FIX";
            this.FIX.Size = new System.Drawing.Size(75, 23);
            this.FIX.TabIndex = 3;
            this.FIX.Text = "FIX";
            this.FIX.UseVisualStyleBackColor = true;
            this.FIX.Click += new System.EventHandler(this.FIX_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(190, 84);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 23);
            this.Sort.TabIndex = 2;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // DEL
            // 
            this.DEL.Location = new System.Drawing.Point(38, 84);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(75, 23);
            this.DEL.TabIndex = 1;
            this.DEL.Text = "DEL";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(38, 29);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list_ob);
            this.groupBox3.Location = new System.Drawing.Point(31, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 204);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Object";
            // 
            // list_ob
            // 
            this.list_ob.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.list_ob.GridLines = true;
            this.list_ob.Location = new System.Drawing.Point(24, 30);
            this.list_ob.Name = "list_ob";
            this.list_ob.Size = new System.Drawing.Size(584, 159);
            this.list_ob.TabIndex = 0;
            this.list_ob.UseCompatibleStateImageBehavior = false;
            this.list_ob.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IdObject";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "IdSuplier";
            this.columnHeader5.Width = 101;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Amount";
            this.columnHeader6.Width = 114;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.list_kho);
            this.groupBox4.Controls.Add(this.txtsearch);
            this.groupBox4.Location = new System.Drawing.Point(709, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(618, 287);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kho Chứa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Search By ID";
            // 
            // list_kho
            // 
            this.list_kho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.list_kho.FullRowSelect = true;
            this.list_kho.GridLines = true;
            this.list_kho.Location = new System.Drawing.Point(29, 113);
            this.list_kho.Name = "list_kho";
            this.list_kho.Size = new System.Drawing.Size(583, 159);
            this.list_kho.TabIndex = 0;
            this.list_kho.UseCompatibleStateImageBehavior = false;
            this.list_kho.View = System.Windows.Forms.View.Details;
            this.list_kho.SelectedIndexChanged += new System.EventHandler(this.list_kho_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã Kho";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Quản Lý";
            this.columnHeader9.Width = 79;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "IdObject";
            this.columnHeader10.Width = 92;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Số Lượng chưa";
            this.columnHeader11.Width = 129;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(157, 68);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(386, 22);
            this.txtsearch.TabIndex = 8;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1261, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KHO";
            this.Text = "Phòng Kho";
            this.Load += new System.EventHandler(this.KHO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.ComboBox cbob;
        private System.Windows.Forms.ComboBox cbemp;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button FIX;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView list_ob;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView list_kho;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button button1;
    }
}