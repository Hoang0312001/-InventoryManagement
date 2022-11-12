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
    public partial class OBJECT : Form
    {
        public OBJECT()
        {
            InitializeComponent();
        }

        private  void add_Click(object sender, EventArgs e)
        {
            ObjectC kh = new ObjectC(txtid.Text, txtname.Text, cbunit.Text, cbsup.Text, Convert.ToInt32(txtamount.Text), txtqr.Text);
            if (kh.KT_key(txtid.Text))
            {
                DialogResult result = MessageBox.Show("Mã Sản Phẩm Đã Tồn Tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kh.insert(kh);
                OBJECT_Load(sender, e);
            }
        }

        private void OBJECT_Load(object sender, EventArgs e)
        {
            ObjectC ob1 = new ObjectC();
            ob1.listview_hienthi(list_object, "select * from Object");
            cbunit.DataSource = ob1.Load("select * from Unit");
            cbunit.DisplayMember = "IdUnit";
            cbunit.ValueMember = "IdUnit";
            cbsup.DataSource = ob1.Load("select * from Suplier");
            cbsup.DisplayMember = "IdSuplier";
            cbsup.ValueMember = "IdSuplier";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_object.SelectedItems)
            {
                txtid.Text = item.SubItems[1].Text;
                txtname.Text = item.SubItems[2].Text;
                cbunit.Text = item.SubItems[3].Text;
                cbsup.Text = item.SubItems[4].Text;
                txtamount.Text = item.SubItems[5].Text;
                txtqr.Text = item.SubItems[6].Text;
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ObjectC kh = new ObjectC(txtid.Text, txtname.Text, cbunit.Text, cbsup.Text, Convert.ToInt32(txtamount.Text), txtqr.Text);
            kh.update(kh);
            OBJECT_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ObjectC kh = new ObjectC(txtid.Text, txtname.Text, cbunit.ToString(), cbsup.ToString(), Convert.ToInt32(txtamount.Text), txtqr.Text);
            kh.Del(kh);
            OBJECT_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ObjectC kh = new ObjectC();
            kh.delall();
            OBJECT_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String sql = "select * from Object order by amount desc ";
            ObjectC kh = new ObjectC(txtid.Text, txtname.Text, cbunit.ToString(), cbsup.ToString(), Convert.ToInt32(txtamount.Text), txtqr.Text);       
            kh.listview_hienthi(list_object, sql);     
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            cbunit.Text = "";
            cbsup.Text = "";
            txtamount.Text = "";
            txtqr.Text = "";

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String sql = "select * from Object where IdObject like '" + txtsearch.Text + "%'";
            KHO_C kh = new KHO_C();       
            kh.listview_hienthi(list_object, sql);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


       
    }
}
