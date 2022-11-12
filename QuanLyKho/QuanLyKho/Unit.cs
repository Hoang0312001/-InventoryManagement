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
    public partial class Unit : Form
    {
        public Unit()
        {
            InitializeComponent();
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            UnitC ob = new UnitC();
            ob.listview_hienthi(list_Unit, "Select * From Unit");
        }

        private void list_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_Unit.SelectedItems)
            {
                txtid.Text = item.SubItems[1].Text;
                txtname.Text = item.SubItems[2].Text;
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnitC sp = new UnitC(txtid.Text, txtname.Text);
            if (sp.KT_key(txtid.Text))
            {
                DialogResult result = MessageBox.Show("Mã Sản Phẩm Đã Tồn Tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sp.insert(sp);
                Unit_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnitC sp = new UnitC(txtid.Text, txtname.Text);
            sp.update(sp);
            Unit_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UnitC sp = new UnitC(txtid.Text, txtname.Text);
            sp.Del(sp);
            Unit_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UnitC sp = new UnitC();
            sp.delall();
            Unit_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
