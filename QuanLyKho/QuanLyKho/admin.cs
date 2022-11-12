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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            customizeDesing();
        }
        public void customizeDesing() {
            panelsub.Visible = false;
          
        }
        private void hideSubMenu() {
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
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsub);
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new creatAcount());
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Role());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new OBJECT());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Employee());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }
    }
}
