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
    public partial class Supiler : Form
    {
        public Supiler()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_suplier.SelectedItems)
            {
                txtidc.Text = item.SubItems[1].Text;
                txtname.Text = item.SubItems[2].Text;
                txtaddress.Text = item.SubItems[3].Text;
                txtphone.Text = item.SubItems[4].Text;
                txtemail.Text = item.SubItems[5].Text;
                txtdate.Text = item.SubItems[6].Text;


            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            Suplier sp = new Suplier(txtidc.Text,txtname.Text, txtaddress.Text,txtphone.Text,txtemail.Text,Convert.ToDateTime(txtdate.Text));
            if (sp.KT_key(txtidc.Text))
            {
                DialogResult result = MessageBox.Show("Mã Sản Phẩm Đã Tồn Tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sp.insert(sp);
                Supiler_Load(sender, e);
            }

        }

        private void Supiler_Load(object sender, EventArgs e)
        {
          Suplier sp = new Suplier();
            sp.listview_hienthi(list_suplier, "SELECT * FROM Suplier");
        }

        private void FIX_Click(object sender, EventArgs e)
        {
            Suplier sp = new Suplier(txtidc.Text, txtname.Text, txtaddress.Text, txtphone.Text, txtemail.Text, Convert.ToDateTime(txtdate.Text));
            sp.update(sp);
            Supiler_Load(sender, e);
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            Suplier sp = new Suplier(txtidc.Text, txtname.Text, txtaddress.Text, txtphone.Text, txtemail.Text, Convert.ToDateTime(txtdate.Text));
            sp.Del(sp);
            Supiler_Load(sender, e);
        }

        private void DELALL_Click(object sender, EventArgs e)
        {
            Suplier sp = new Suplier();
            sp.delall();
            sp.listview_hienthi(list_suplier, "SELECT * FROM Suplier");
            
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            txtidc.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtdate.Text = "";
             
        }

        private void SORT_Click(object sender, EventArgs e)
        {
            String sql = "select * from Suplier order by ContractDate desc ";
            Suplier sp = new Suplier(txtidc.Text, txtname.Text, txtaddress.Text, txtphone.Text, txtemail.Text, Convert.ToDateTime(txtdate.Text));
            sp.listview_hienthi(list_suplier, sql);     
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String sql = "select * from Suplier where IdSuplier like '" + txtsearch.Text + "%'";
            Suplier sp = new Suplier(txtidc.Text, txtname.Text, txtaddress.Text, txtphone.Text, txtemail.Text, Convert.ToDateTime(txtdate.Text));
            sp.listview_hienthi(list_suplier, sql);                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
