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
    public partial class APP_Emp : Form
    {
        public APP_Emp()
        {
            InitializeComponent();

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelsub.Controls.Add(childForm);
            panelsub.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new OBJECT());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Input());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new KHO());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Output());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Unit());
        }

      

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new Supiler());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new Customer());
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }
    }
}
