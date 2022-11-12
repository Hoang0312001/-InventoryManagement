using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyKho
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9V6MI6K;Initial Catalog=QUANLYKHO1;Integrated Security=True");

        private void roleEmployee() {
            Customer c = new Customer();  
            Employee e = new Employee();     
            Input i = new Input();
            KHO k = new KHO();
           
            OBJECT o = new OBJECT();
            Output op = new Output();
            Supiler s = new Supiler();
            Unit u = new Unit();

            EmployeeC ec = new EmployeeC();
              
            
        }
        private void displayMain() {
            Main m = new Main();
            m.ShowDialog();
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (txtuser.Text != "" && txtpass.Text != "")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("	select * from Users inner join role  on Users.userRole = roleId where userName = @userName and passWords = @passWords", con);
                cmd.Parameters.AddWithValue("@userName", txtuser.Text);
                cmd.Parameters.AddWithValue("@passWords", txtpass.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    string userType = dt.Rows[0][5].ToString();
                    if (userType == "manager")
                    {
                        displayMain();
                       
                    }
                    else if (userType == "employee") {
                        APP_Emp m = new APP_Emp();
                        m.ShowDialog();
                        this.Hide();
                    }
                    else if (userType == "cashier")
                    {
                        App_Cashier m = new App_Cashier();
                        m.ShowDialog();
                        this.Hide();
                    }
                    else if (userType == "admin")
                    {
                        admin  m = new admin();
                        m.ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai tài khoản hoặc mật khẩu");
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
