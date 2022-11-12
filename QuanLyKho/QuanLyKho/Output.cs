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
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        private void Output_Load(object sender, EventArgs e)
        {
            OutPutC op = new OutPutC();
            op.listview_hienthi(list_out, "SELECT * FROM Output");
           KHO_C k1 = new KHO_C();
            k1.listview_hienthi(list_kho, "SELECT * FROM KHO");
            cbCus.DataSource = op.Load("select * from Customer");
            cbCus.DisplayMember = "IdCustomer";
            cbCus.ValueMember = "IdCustomer";

            cbEmp.DataSource = op.Load("select * from Employee");
            cbEmp.DisplayMember = "IdEmployee";
            cbEmp.ValueMember = "IdEmployee";

           
            KHO_C k = new KHO_C();
            cbmakho.DataSource = k.Load("select MaKho from KHO");
            cbmakho.DisplayMember = ("MaKho");
            cbmakho.ValueMember = "MaKho";

        
        }

        

        private void ADD_Click(object sender, EventArgs e)
        {
            OutPutC ob = new OutPutC();
            if (ob.KT_key(txtid.Text) == true)
            {
                MessageBox.Show("Trùng khóa chính");
            }
            else
            {
                if (cbCus.SelectedValue == null && cbEmp.SelectedValue == null && cbmakho.SelectedValue == null)
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                }
                else
                {

                    KHO_C ob1 = new KHO_C();
                    string sql = "select SLChua from KHO where MaKho = '" + cbmakho.SelectedValue.ToString() + "'";
                    DataTable dt = new DataTable();
                    dt = ob1.Load(sql);
                    string sl1 = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        sl1 = row["SLChua"].ToString();
                    }
                    if (Convert.ToInt32(txtamount.Text) > Convert.ToInt32(sl1))
                    {
                        MessageBox.Show("Hàng Trong Kho Không Đủ");
                    }

                    else {
                        OutPutC op1 = new OutPutC(txtid.Text, cbCus.SelectedValue.ToString(), cbEmp.SelectedValue.ToString(), txtin.Text, txtob.Text, txtsup.Text, Convert.ToInt32(txtprice.Text), Convert.ToInt32(txtamount.Text), txtstatus.Text, Convert.ToDateTime(txtdateout.Text), cbmakho.SelectedValue.ToString());
                        op1.insert(op1);
                        float sl = Convert.ToInt32(sl1) - Convert.ToInt32((txtamount.Text));
                        string sql1 = "update KHO set SLChua =" + sl + " where MaKho='" + cbmakho.SelectedValue.ToString() + "'";
                        op1.Execute(sql1);
                        Output_Load(sender, e);
                    }

                }
            }
            
        }

        private void txtob_TextChanged(object sender, EventArgs e)
        {
            OutPutC op = new OutPutC();
            DataTable dt = new DataTable();
            dt = op.Load("select OutputPrice,IdSuplier,IdInput,Status from Input where IdObject='" + txtob.Text + "'");
            foreach (DataRow row in dt.Rows)
            {

                txtprice.Text = row["OutputPrice"].ToString();
                txtsup.Text = row["IdSuplier"].ToString();
                txtin.Text = row["IdInput"].ToString();
                txtstatus.Text = row["Status"].ToString();

            }
        }

        private void cbmakho_SelectedIndexChanged(object sender, EventArgs e)
        {
            KHO_C k = new KHO_C();
            DataTable dt = new DataTable();
            dt = k.Load("select IdObject from KHO where MaKho='" + cbmakho.SelectedValue.ToString() + "'");
            foreach (DataRow row in dt.Rows)
            {

                txtob.Text = row["IdObject"].ToString();
                

            }
        }
 

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
           String sql = "select * from Output where IdOutput like '" + txtsearch.Text + "%'";
            OutPutC ip = new OutPutC();
            ip.listview_hienthi(list_kho, sql);
        }

       

        private void FIX_Click(object sender, EventArgs e)
        {
            if (cbmakho.SelectedValue == null) { return; }
            else
            {


                string sql = "select SLChua from KHO where MaKho = '" + cbmakho.SelectedValue.ToString() + "'";
               KHO_C ip = new KHO_C();
                DataTable dt = new DataTable();
                dt = ip.Load(sql);
                int sl1 = 0, sl2 = 0;
                foreach (DataRow row in dt.Rows)
                {

                    sl1 = Convert.ToInt32(row["SLChua"].ToString());
                }
                KHO_C k = new KHO_C();
                string sql1 = "select amount from Output where IdOutput = '" + txtid.Text + "'";
                DataTable dt1 = new DataTable();
                dt1 = k.Load(sql1);
                foreach (DataRow row in dt1.Rows)
                {
                    sl2 = Convert.ToInt32(row["amount"].ToString());
                }
                if (sl1 + sl2 < Convert.ToInt32(txtamount.Text))
                {
                    MessageBox.Show("Quá Số Lượng ");
                }
                else
                {
                    OutPutC op1 = new OutPutC(txtid.Text, cbCus.SelectedValue.ToString(), cbEmp.SelectedValue.ToString(), txtin.Text, txtob.Text, txtsup.Text, Convert.ToInt32(txtprice.Text), Convert.ToInt32(txtamount.Text), txtstatus.Text, Convert.ToDateTime(txtdateout.Text), cbmakho.SelectedValue.ToString());
                    op1.update(op1);
                    int sl = (sl1 + sl2 - Convert.ToInt32(txtamount.Text));
                    string sql3 = "update KHO set SLChua =" + sl + " where MaKho='" + cbmakho.SelectedValue.ToString() + "'";
                    op1.Execute(sql3);
                    Output_Load(sender, e);
                }
            }
        }

        private void list_out_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_out.SelectedItems)
            {

                txtid.Text = item.SubItems[1].Text;
                cbCus.Text = item.SubItems[2].Text;
                cbEmp.Text = item.SubItems[3].Text;
                txtin.Text = item.SubItems[4].Text;
                txtob.Text = item.SubItems[5].Text;
                txtsup.Text = item.SubItems[6].Text;
                txtprice.Text = item.SubItems[7].Text;
                txtamount.Text = item.SubItems[8].Text;
                txtstatus.Text = item.SubItems[9].Text;
                txtdateout.Text = item.SubItems[10].Text;
                cbmakho.Text = item.SubItems[11].Text;
           



            }
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (cbmakho.SelectedValue == null) { return; }
            else
            {


                string sql = "select SLChua from KHO where MaKho = '" + cbmakho.SelectedValue.ToString() + "'";
                KHO_C ip = new KHO_C();
                DataTable dt = new DataTable();
                dt = ip.Load(sql);
                int sl1 = 0;
                foreach (DataRow row in dt.Rows)
                {

                    sl1 = Convert.ToInt32(row["SLChua"].ToString());
                }
                OutPutC op1 = new OutPutC(txtid.Text,cbCus.SelectedValue.ToString(),cbEmp.SelectedValue.ToString(),txtin.Text,txtob.Text,txtsup.Text,Convert.ToInt32(txtprice.Text),Convert.ToInt32(txtamount.Text),txtstatus.Text,Convert.ToDateTime(txtdateout.Text),cbmakho.SelectedValue.ToString());
                op1.Del(op1);
                int sl = Convert.ToInt32(sl1) + Convert.ToInt32(txtamount.Text);
                string sql1 = "update KHO set SLChua =" + sl + " where MaKho='" + cbmakho.SelectedValue.ToString() + "'";
                op1.Execute(sql1);
                Output_Load(sender, e);
            }
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            cbCus.Text="";
            cbEmp.Text="";
            txtin.Text="";
            txtob.Text="";
            txtsup.Text="";
            txtprice.Text="";
            txtamount.Text="";
            txtstatus.Text="";
            txtdateout.Text = ""; 
            cbmakho.Text = "";
        }

        private void SORT_Click(object sender, EventArgs e)
        {
            string sql = "select * from Output order by YEAR(DateOutput) desc";
            OutPutC ip1 = new OutPutC();
            ip1.listview_hienthi(list_out, sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void cb_search_TextChanged(object sender, EventArgs e)
        {
            String sql = "select * from KHO where IdObject like '" + cb_search.Text + "%'";
            KHO_C ip = new KHO_C();
            ip.listview_hienthi(list_kho, sql);
        }

      
    }
}
