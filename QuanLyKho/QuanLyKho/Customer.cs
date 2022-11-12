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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            KhachHangC kh = new KhachHangC();
            kh.listview_hienthi(list_customer, "SELECT * FROM Customer");
        }

        private void list_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_customer.SelectedItems)
            {
                txtidc.Text = item.SubItems[1].Text;
                txtname.Text = item.SubItems[2].Text;
                txtaddress.Text = item.SubItems[3].Text;
                txtphone.Text = item.SubItems[4].Text;
                txtmail.Text = item.SubItems[5].Text;
                txtdate.Text = item.SubItems[6].Text;


            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            KhachHangC kh = new KhachHangC(txtidc.Text, txtname.Text, txtaddress.Text, txtphone.Text, txtmail.Text, Convert.ToDateTime(txtdate.Text));
            if (kh.KT_key(txtidc.Text))
            {
                DialogResult result = MessageBox.Show("Mã Sản Phẩm Đã Tồn Tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kh.insert(kh);
                Customer_Load(sender, e);
            }
        }

        private void FIX_Click(object sender, EventArgs e)
        {
            KhachHangC kh = new KhachHangC(txtidc.Text, txtname.Text, txtaddress.Text, txtphone.Text, txtmail.Text, Convert.ToDateTime(txtdate.Text));
            kh.update(kh);
            Customer_Load(sender, e);
        }

       

         private void DELETE_Click(object sender, EventArgs e)
         {
             KhachHangC kh = new KhachHangC(txtidc.Text, txtname.Text, txtaddress.Text, txtphone.Text, txtmail.Text, Convert.ToDateTime(txtdate.Text));
             kh.Del(kh);
             Customer_Load(sender, e);
         }

         private void RESET_Click(object sender, EventArgs e)
         {
             txtidc.Text = "";
             txtname.Text = "";
             txtaddress.Text = "";
             txtmail.Text = "";
             txtphone.Text = "";
             txtdate.Text = "";
             

         }

         private void DEL_ALL_Click_1(object sender, EventArgs e)
         {

             KhachHangC kh = new KhachHangC();
             kh.delall();
             kh.listview_hienthi(list_customer, "SELECT * FROM Customer");

         }

         private void txtsearch_TextChanged(object sender, EventArgs e)
         {
                String sql = "select * from Customer where IdCustomer like '" + txtsearch.Text + "%'";
                 KhachHangC kh = new KhachHangC(txtidc.Text, txtname.Text, txtaddress.Text, txtphone.Text, txtmail.Text, Convert.ToDateTime(txtdate.Text));
                 kh.listview_hienthi(list_customer, sql);
         }

         private void button1_Click(object sender, EventArgs e)
         {
             this.Close();
         }

   

       
       

      

       

     
    }
}