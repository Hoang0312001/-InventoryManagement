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
    class EmployeeC
    {
        string id, name, position;
        public EmployeeC() { }
        public EmployeeC(string id , string name,string position) {
            this.id = id;
            this.name = name;
            this.position = position;
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
                string id = rows["IdEmployee"].ToString();
                string name = rows["DisplayName"].ToString();
                string position = rows["Position"].ToString();

                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(id);
                item.Items[i].SubItems.Add(name);
                item.Items[i].SubItems.Add(position);
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

        public void insert(EmployeeC kh)
        {
            string sql = "insert into Employee values ('" + kh.id + "','" + kh.name + "','" + kh.position + "')";
            Execute(sql);
        }

        public void update(EmployeeC kh)
        {
            string sql = "Update Employee set DisplayName= '" + kh.name + "', Position = '" + kh.position + "' where IdEmployee = '" + kh.id + "'";
            Execute(sql);
        }
        public void Del(EmployeeC kh)
        {
            string sql = "Delete from Employee where IdEmployee = '" + kh.id + "' ";
            Execute(sql); ;
        }
        public void delall()
        {
            string sql = "DELETE FROM Employee ";
            Execute(sql);
        }


        public bool KT_key(string key)
        {
            bool kt = false;
            string sql = "select IdEmployee from Employee";
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                string masp = row["IdEmployee"].ToString();
                if (String.Compare(masp.Trim(), key.Trim(), true) == 0)
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
