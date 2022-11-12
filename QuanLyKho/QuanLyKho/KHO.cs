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
    public partial class KHO : Form
    {
        public KHO()
        {
            InitializeComponent();
        }

        private void KHO_Load(object sender, EventArgs e)
        {
            KHO_C k = new KHO_C();
            k.listview_hienthi(list_kho, "select * from KHO");
            ObjectC ob = new ObjectC();
            ob.listview_hienthi(list_ob, "select * from Object");

            cbemp.DataSource = ob.Load("select * from Employee");
            cbemp.DisplayMember = "IdEmployee";
            cbemp.ValueMember = "IdEmployee";

            cbob.DataSource = ob.Load("select * from Object");
            cbob.DisplayMember = "IdObject";
            cbob.ValueMember = "IdObject";

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            KHO_C k = new KHO_C();
            if (k.KT_key(txtid.Text) == true)
            {
                MessageBox.Show("Trùng khóa chính");
            }
            else
            {
                if (cbob.SelectedValue == null && cbemp.SelectedValue == null)
                {
                    MessageBox.Show("Chưa Nhập Hết");
                }
                else
                {

                    KHO_C k2 = new KHO_C();
                    string sql = "select amount from Object where IdObject = '" + cbob.SelectedValue.ToString() + "'";
                    DataTable dt = new DataTable();
                    dt = k2.Load(sql);
                    string sl1 = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        sl1 = row["amount"].ToString();
                    }




                    if (Convert.ToInt32(sl1) < Convert.ToInt32(txtsl.Text))
                    {

                        MessageBox.Show("Bạn đã nhập quá số Lượng");

                    }
                    else if (Convert.ToInt32(txtsl.Text) <= 0)
                    {
                        MessageBox.Show("Nhập sai");
                    }

                    else
                    {
                        KHO_C k3 = new KHO_C(txtid.Text, cbemp.SelectedValue.ToString(), cbob.SelectedValue.ToString(), Convert.ToInt32(txtsl.Text));
                        k3.insert(k3);
                        float sl = Convert.ToInt32(sl1) - Convert.ToInt32((txtsl.Text));
                        string sql1 = "update Object set Amount =" + sl + " where IdObject='" + cbob.SelectedValue.ToString() + "'";
                        k3.Execute(sql1);
                        KHO_Load(sender, e);
                    }


                }
            }
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (cbob.SelectedValue == null) { return; }
            else
            {
                string sql = "select amount from Object where IdObject = '" + cbob.SelectedValue.ToString() + "'";
                KHO_C ip = new KHO_C();
                DataTable dt = new DataTable();
                dt = ip.Load(sql);
                string sl1 = "";
                foreach (DataRow row in dt.Rows)
                {
                    sl1 = row["amount"].ToString();

                }
                KHO_C k3 = new KHO_C(txtid.Text, cbemp.SelectedValue.ToString(), cbob.SelectedValue.ToString(), Convert.ToInt32(txtsl.Text));

                k3.Del(k3);
                int sl = Convert.ToInt32(sl1) + Convert.ToInt32(txtsl.Text);
                string sql1 = "update Object set amount ='" + sl + "' where IdObject ='" + cbob.SelectedValue.ToString() + "'";
                k3.Execute(sql1);
                KHO_Load(sender, e);
            }
        }

        private void list_kho_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_kho.SelectedItems)
            {

                txtid.Text = item.SubItems[1].Text;
                cbemp.Text = item.SubItems[2].Text;
                cbob.Text = item.SubItems[3].Text;
                txtsl.Text = item.SubItems[4].Text;


            }
        }

      

        private void FIX_Click(object sender, EventArgs e)
        {
            if (cbob.SelectedValue == null) { return; }
            else
            {


                string sql = "select amount from Object where IdObject = '" + cbob.SelectedValue.ToString() + "'";
                KhachHangC ip = new KhachHangC();
                DataTable dt = new DataTable();
                dt = ip.Load(sql);
                int sl1 = 0, sl2 = 0;
                foreach (DataRow row in dt.Rows)
                {

                    sl1 = Convert.ToInt32(row["amount"].ToString());
                }

                string sql1 = "select SLChua from KHO where MaKho = '" + txtid.Text + "'";
                DataTable dt1 = new DataTable();
                dt1 = ip.Load(sql1);
                foreach (DataRow row in dt1.Rows)
                {
                    sl2 = Convert.ToInt32(row["SLChua"].ToString());
                }
                if (sl1 + sl2< Convert.ToInt32(txtsl.Text))
                {
                    MessageBox.Show("Nhập Quá Số Lượng ");
                }
                else
                {
                    KHO_C k3 = new KHO_C(txtid.Text, cbemp.SelectedValue.ToString(), cbob.SelectedValue.ToString(), Convert.ToInt32(txtsl.Text));

                    k3.update(k3);
                    int  sl = (sl1 +sl2 - Convert.ToInt32(txtsl.Text));
                    string sql3 = "update Object set amount =" + sl + " where IdObject='" + cbob.SelectedValue.ToString() + "'";
                    k3.Execute(sql3);
                    KHO_Load(sender, e);
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String sql = "select * from KHO where IdObject like '" + txtsearch.Text + "%'";
            KHO_C ip = new KHO_C();
            ip.listview_hienthi(list_kho, sql);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            String sql = "select * from KHO order by amount desc";
            KHO_C ip = new KHO_C();
            ip.listview_hienthi(list_kho, sql);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtsl.Text = "";
            cbemp.Text = "";
            cbob.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
