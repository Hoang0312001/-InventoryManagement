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
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {
            InputC ip = new InputC();
            ObjectC ob = new ObjectC();
            ob.listview_hienthi(list_Object, "select * from Object");
            ip.listview_hienthi(list_Input,"select * from Input");

            cbob.DataSource = ob.Load("select * from Object");
            cbob.DisplayMember = "IdObject";
            cbob.ValueMember = "IdObject";
            cbob.SelectedIndex = -1;

      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            InputC ip2 = new InputC();
            if (ip2.KT_key(txtid.Text) == true)
            {
                MessageBox.Show("Trùng khóa chính");
            }
            else {
                if (cbob.SelectedValue == null) {
                    MessageBox.Show("Chua nhap IdObject");
                }
                else
                {

                    InputC ip = new InputC();
                    string sql = "select amount from Object where IdObject = '" + cbob.SelectedValue.ToString() + "'";
                    DataTable dt = new DataTable();
                    dt = ip.Load(sql);
                    string sl1 = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        sl1 = row["amount"].ToString();
                    }

                    InputC ip1 = new InputC(txtid.Text, cbob.SelectedValue.ToString(), txtsup.Text, Convert.ToInt32((txtamount.Text)), Convert.ToInt32((txtinprice.Text)), Convert.ToInt32((txtoutprice.Text)), txtstatus.Text, Convert.ToDateTime(txtdatein.Text));
                    ip1.insert(ip1);
                    float sl = Convert.ToInt32(sl1) + Convert.ToInt32((txtamount.Text));
                    string sql1 = "update Object set Amount =" + sl + " where IdObject='" + cbob.SelectedValue.ToString() + "'";
                    ip1.Execute(sql1);
                    Input_Load(sender, e);

                }
            }
        }

        private void cbob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbob.SelectedValue == null)
            {
                return;
            }
            else
            {

                ObjectC ob = new ObjectC();
                DataTable dt = new DataTable();
                dt = ob.Load("select IdSuplier from Object where IdObject = '" + cbob.SelectedValue.ToString() + "'");
                foreach (DataRow row in dt.Rows)
                {

                    txtsup.Text = row["IdSuplier"].ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbob.SelectedValue == null) { return; }
            else
            {


                string sql = "select amount from Object where IdObject = '" + cbob.SelectedValue.ToString() + "'";
                InputC ip = new InputC();
                DataTable dt = new DataTable();
                dt = ip.Load(sql);
                float sl1 = 0, sl2 = 0;
                foreach (DataRow row in dt.Rows)
                {

                    sl1 = float.Parse(row["amount"].ToString());
                }

                string sql1 = "select amount from Input where IdInput = '" + txtid.Text + "'";
                DataTable dt1 = new DataTable();
                dt1 = ip.Load(sql1);
                foreach (DataRow row in dt1.Rows)
                {
                    sl2 = float.Parse(row["amount"].ToString());
                }
                if (sl2 > sl1 + Convert.ToInt32(txtamount.Text))
                {
                    MessageBox.Show("Qúa Số Lượng Trong Kho");
                }
                else {
                    InputC ip1 = new InputC(txtid.Text, cbob.SelectedValue.ToString(), txtsup.Text, Convert.ToInt32((txtamount.Text)), Convert.ToInt32((txtinprice.Text)), Convert.ToInt32((txtoutprice.Text)), txtstatus.Text, Convert.ToDateTime(txtdatein.Text));
                  
                    ip1.update(ip1);
                    float sl = (sl1 + Convert.ToInt32(txtamount.Text)) - sl2;
                    string sql3 = "update Object set amount =" + sl + " where IdObject='" + cbob.SelectedValue.ToString() + "'";
                    ip1.Execute(sql3);
                    Input_Load(sender, e);
                }
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbob.SelectedValue == null) { return; }
            else {
                string sql = "select amount from Object where IdObject = '" + cbob.SelectedValue.ToString() + "'";
                InputC ip = new InputC();
                DataTable dt = new DataTable();
                dt = ip.Load(sql);
                float sl1 = 0;
                foreach (DataRow row in dt.Rows)
                {

                    sl1 = float.Parse(row["amount"].ToString());
                }
                InputC ip1 = new InputC(txtid.Text, cbob.SelectedValue.ToString(), txtsup.Text, Convert.ToInt32((txtamount.Text)), Convert.ToInt32((txtinprice.Text)), Convert.ToInt32((txtoutprice.Text)), txtstatus.Text, Convert.ToDateTime(txtdatein.Text));

                ip1.Del(ip1);
                float sl = sl1 - Convert.ToInt32(txtamount.Text);
                string sql1 = "update Object set amount ='" + sl + "' where IdObject ='" + cbob.SelectedValue.ToString() + "'";
                ip1.Execute(sql1);
                Input_Load(sender, e);
            }

        }

        private void RESET_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            cbob.Text = "";
            txtsup.Text = "";
            txtamount.Text = "";
            txtinprice.Text = "";
            txtoutprice.Text = "";
            txtstatus.Text = "";
            txtdatein.Text = "";
      

        }

        private void list_Input_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_Input.SelectedItems)
            {

                txtid.Text = item.SubItems[1].Text;
                cbob.Text = item.SubItems[2].Text;
                txtsup.Text = item.SubItems[3].Text;
                txtamount.Text = item.SubItems[4].Text;
                txtinprice.Text = item.SubItems[5].Text;
                txtoutprice.Text = item.SubItems[6].Text;
                txtstatus.Text = item.SubItems[7].Text;
                txtdatein.Text = item.SubItems[8].Text;

            }
        }

      

        private void SORT_Click(object sender, EventArgs e)
        {
            string sql = "select * from Input order by YEAR(DateInput) desc";
            InputC ip1 = new InputC();
            ip1.listview_hienthi(list_Input, sql);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String sql = "select * from Input where IdInput like '" + txtsearch.Text + "%'";
            InputC ip = new InputC();
            ip.listview_hienthi(list_Input, sql);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_Object_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_Object.SelectedItems)
            {

           

            }
        }


    }
}
