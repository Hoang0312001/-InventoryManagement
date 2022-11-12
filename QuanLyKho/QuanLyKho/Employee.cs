using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            EmployeeC ob = new EmployeeC();
            ob.listview_hienthi(listView1, "SELECT * FROM Employee");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeC sp = new EmployeeC(txtid.Text, txtname.Text, txtposition.Text);
            if (sp.KT_key(txtid.Text))
            {
                DialogResult result = MessageBox.Show("Mã Sản Phẩm Đã Tồn Tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sp.insert(sp);
                Employee_Load(sender, e);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                txtid.Text = item.SubItems[1].Text;
                txtname.Text = item.SubItems[2].Text;
                txtposition.Text = item.SubItems[3].Text;
            


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeC sp = new EmployeeC(txtid.Text, txtname.Text, txtposition.Text);
            sp.update(sp);
            Employee_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeC sp = new EmployeeC(txtid.Text, txtname.Text, txtposition.Text);
            sp.Del(sp);
            Employee_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeC sp = new EmployeeC();
            sp.delall();
            Employee_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtposition.Text = "";
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            String sql = "select * from Employee where IdEmployee like '" + txtsearh.Text + "%'";
            EmployeeC sp = new EmployeeC(txtid.Text, txtname.Text, txtposition.Text);        
            sp.listview_hienthi(listView1, sql);    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
