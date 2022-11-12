namespace QuanLyKho
{
    partial class Customer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtidc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.FIX = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.DEL_ALL = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.FUNCTION = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_customer = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ADDRESS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PHONE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMAIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contractdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.FUNCTION.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtmail);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtidc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(152, 309);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 22);
            this.txtdate.TabIndex = 13;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(152, 251);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(200, 22);
            this.txtmail.TabIndex = 11;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(152, 197);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(200, 22);
            this.txtphone.TabIndex = 10;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(152, 152);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(200, 22);
            this.txtaddress.TabIndex = 9;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(152, 103);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 22);
            this.txtname.TabIndex = 8;
            // 
            // txtidc
            // 
            this.txtidc.Location = new System.Drawing.Point(152, 63);
            this.txtidc.Name = "txtidc";
            this.txtidc.Size = new System.Drawing.Size(200, 22);
            this.txtidc.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contract Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(39, 44);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 7;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // FIX
            // 
            this.FIX.Location = new System.Drawing.Point(220, 44);
            this.FIX.Name = "FIX";
            this.FIX.Size = new System.Drawing.Size(75, 23);
            this.FIX.TabIndex = 8;
            this.FIX.Text = "FIX";
            this.FIX.UseVisualStyleBackColor = true;
            this.FIX.Click += new System.EventHandler(this.FIX_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(39, 96);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(75, 23);
            this.DELETE.TabIndex = 9;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // DEL_ALL
            // 
            this.DEL_ALL.Location = new System.Drawing.Point(220, 96);
            this.DEL_ALL.Name = "DEL_ALL";
            this.DEL_ALL.Size = new System.Drawing.Size(75, 23);
            this.DEL_ALL.TabIndex = 10;
            this.DEL_ALL.Text = "DEL_ALL";
            this.DEL_ALL.UseVisualStyleBackColor = true;
            this.DEL_ALL.Click += new System.EventHandler(this.DEL_ALL_Click_1);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(135, 146);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(75, 23);
            this.RESET.TabIndex = 11;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // FUNCTION
            // 
            this.FUNCTION.Controls.Add(this.RESET);
            this.FUNCTION.Controls.Add(this.ADD);
            this.FUNCTION.Controls.Add(this.DEL_ALL);
            this.FUNCTION.Controls.Add(this.FIX);
            this.FUNCTION.Controls.Add(this.DELETE);
            this.FUNCTION.Location = new System.Drawing.Point(574, 25);
            this.FUNCTION.Name = "FUNCTION";
            this.FUNCTION.Size = new System.Drawing.Size(343, 203);
            this.FUNCTION.TabIndex = 1;
            this.FUNCTION.TabStop = false;
            this.FUNCTION.Text = "FUNCTION";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list_customer);
            this.groupBox3.Location = new System.Drawing.Point(131, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(962, 298);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Khách Hàng";
            // 
            // list_customer
            // 
            this.list_customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.ID,
            this.NAME,
            this.ADDRESS,
            this.PHONE,
            this.EMAIL,
            this.contractdate});
            this.list_customer.FullRowSelect = true;
            this.list_customer.GridLines = true;
            this.list_customer.Location = new System.Drawing.Point(59, 35);
            this.list_customer.Name = "list_customer";
            this.list_customer.Size = new System.Drawing.Size(897, 208);
            this.list_customer.TabIndex = 0;
            this.list_customer.UseCompatibleStateImageBehavior = false;
            this.list_customer.View = System.Windows.Forms.View.Details;
            this.list_customer.SelectedIndexChanged += new System.EventHandler(this.list_customer_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NAME
            // 
            this.NAME.Text = "NAME";
            // 
            // ADDRESS
            // 
            this.ADDRESS.Text = "ADDRESS";
            // 
            // PHONE
            // 
            this.PHONE.Text = "PHONE";
            // 
            // EMAIL
            // 
            this.EMAIL.Text = "EMAIL";
            this.EMAIL.Width = 119;
            // 
            // contractdate
            // 
            this.contractdate.Text = "Contrac Date";
            this.contractdate.Width = 126;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(602, 369);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(386, 22);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "SEARCH";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1049, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FUNCTION);
            this.Controls.Add(this.groupBox1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FUNCTION.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtidc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button FIX;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button DEL_ALL;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.GroupBox FUNCTION;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView list_customer;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader ADDRESS;
        private System.Windows.Forms.ColumnHeader PHONE;
        private System.Windows.Forms.ColumnHeader EMAIL;
        private System.Windows.Forms.ColumnHeader contractdate;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}