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
    public partial class App_Cashier : Form
    {
        public App_Cashier()
        {
            InitializeComponent();
       
        }
      
        private void hideSubMenu()
        {
            if (panelsub.Visible == true)
                panelsub.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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
            openChildForm(new inhangnhap());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new InObject());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new inhangtrongkho());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new InHangXuat());
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new InKhachHang());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new InNCC());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }
        
    }
}
