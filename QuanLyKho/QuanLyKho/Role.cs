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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void Role_Load(object sender, EventArgs e)
        {
            TypeRole  sp = new TypeRole();
            sp.listview_hienthi(listView1, "SELECT * FROM role");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                txtid.Text = item.SubItems[1].Text;
                texttype.Text = item.SubItems[2].Text;

            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            TypeRole sp = new TypeRole(Convert.ToInt32(txtid.Text),texttype.Text);
            sp.insert(sp);
            Role_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TypeRole sp = new TypeRole(Convert.ToInt32(txtid.Text), texttype.Text);
            sp.Del(sp);
            Role_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TypeRole sp = new TypeRole(Convert.ToInt32(txtid.Text), texttype.Text);
            sp.update(sp);
            Role_Load(sender, e);
        }
    }
}
