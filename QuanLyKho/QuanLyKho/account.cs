using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKho
{
    class account
    {
        string user, pass;
        int role;

        public account() { }
        public account(string user,string pass , int role) {
            this.user = user;
            this.pass = pass;
            this.role = role;
       
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9V6MI6K;Initial Catalog=QUANLYKHO1;Integrated Security=True");
        public void listview_hienthi(ListView item, String sql)
        {
            item.Items.Clear();
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            int i = 0;
            foreach (DataRow rows in dt.Rows)
            {
             
                string user = rows["userName"].ToString();
                string pass = rows["passWords"].ToString();
                string role = rows["userRole"].ToString();

                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(user);
                item.Items[i].SubItems.Add(pass);
                item.Items[i].SubItems.Add(role);
                i = i + 1;
            }
        }
        public void listview_sub(ListView item, String sql)
        {
            item.Items.Clear();
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            int i = 0;
            foreach (DataRow rows in dt.Rows)
            {
              
                string user = rows["userName"].ToString();
                string pass = rows["passWords"].ToString();
                string roleId = rows["roleId"].ToString();
                string roleType = rows["roleType"].ToString();
             

                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(user);
                item.Items[i].SubItems.Add(pass);
                item.Items[i].SubItems.Add(roleId);
                item.Items[i].SubItems.Add(roleType);
                i = i + 1;
            }
        }
        public void Execute(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }

        public void insert(account ac)
        {
            string sql = "insert into Users(userName,passWords,userRole) values ('" + ac.user + "','" + ac.pass + "'," + ac.role + ")";
            Execute(sql);
        }

        public void update(account ac)
        {
            string sql = "Update Users set passWords= '" + ac.pass + "',  userRole= " + ac.role + " where userName = '" + ac.user + "'";
            Execute(sql);
        }
        public void Del(account ac)
        {
            string sql = "Delete from Users where userName = '" +ac.user + "' ";
            Execute(sql); ;
        }
      


        public bool KT_key(string key)
        {
            bool kt = false;
            string sql = "select UserName from Users";
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                string user = row["userName"].ToString();
                if (String.Compare(user.Trim(), key.Trim(), true) == 0)
                {
                    kt = true;
                    break;
                }


            }
            return kt;
        }
        public DataTable Load(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            return dt;
        }

    }
}
