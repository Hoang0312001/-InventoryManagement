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
    public partial class Main : Form
    {
        bool isThoat = true;
        public Main()
        {
            InitializeComponent();
            customizeDesing();
        }
        public void customizeDesing() {
            panelmenuttsub.Visible = false;
            panelmenuinoutsub.Visible = false;
            panelmenuobsub.Visible = false;
            panelinhang.Visible = false;
            panelintt.Visible = false;
        }
        private void hideSubMenu() {
            if (panelmenuttsub.Visible == true)
                panelmenuttsub.Visible = false;
            if (panelmenuinoutsub.Visible == true)
                panelmenuinoutsub.Visible = false;
            if (panelmenuobsub.Visible == true)
                panelmenuobsub.Visible = false;
            if (panelinhang.Visible == true)
                panelinhang.Visible = false;
            if (panelintt.Visible == true)
                panelintt.Visible = false;

        }
        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            showSubMenu(panelmenuttsub);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Employee());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Supiler());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Customer());
            hideSubMenu();
        }

        private void btninout_Click(object sender, EventArgs e)
        {
            showSubMenu(panelmenuinoutsub);
        }

        private void btnob_Click(object sender, EventArgs e)
        {
            showSubMenu(panelmenuobsub);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Input());
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Output());
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new KHO());
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new OBJECT());
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new Unit());
            hideSubMenu();
        }
      
        private void btninhang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelinhang);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new inhangnhap());
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new InHangXuat());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new inhangtrongkho());
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new InObject());
            hideSubMenu();
        }

        private void btnintt_Click(object sender, EventArgs e)
        {
            showSubMenu(panelintt);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm) {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(childForm);
            panelchildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openChildForm(new InNhanVien());
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new InNCC());
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new InKhachHang());
            hideSubMenu();
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            Login l = new Login();
            l.Show();
        

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat) {
                Application.Exit();
            }

        }
       
    }
}
