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
    public partial class creatAcount : Form
    {
        public creatAcount()
        {
            InitializeComponent();
        }

        private void creatAcount_Load(object sender, EventArgs e)
        {
            account kh = new account();
            kh.listview_hienthi(listView1, "SELECT * FROM Users");

            account ac = new account();
            ac.listview_sub(listView2, "select userName , passWords,roleId,roleType from Users us inner join role r on us.userRole = r.roleId ");

            TypeRole t = new TypeRole();
            cbrole.DataSource = t.Load("select roleId from role ");
            cbrole.DisplayMember = "roleId";
            cbrole.ValueMember = "roleId";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            account kh = new account(txtuser.Text,txtpass.Text,Convert.ToInt32(cbrole.SelectedValue.ToString()));
            if (kh.KT_key(txtuser.Text))
            {
              
                DialogResult result = MessageBox.Show("Tên tài khoản đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kh.insert(kh);
               creatAcount_Load(sender, e);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                txtuser.Text = item.SubItems[1].Text;
                txtpass.Text = item.SubItems[2].Text;
                cbrole.Text = item.SubItems[3].Text;
           


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            account kh = new account(txtuser.Text, txtpass.Text, Convert.ToInt32(cbrole.SelectedValue.ToString()));
            kh.Del(kh);
            creatAcount_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
                account kh = new account(txtuser.Text, txtpass.Text, Convert.ToInt32(cbrole.SelectedValue.ToString()));
                kh.update(kh);
                creatAcount_Load(sender, e);
            
        }

      

       
    }
}
