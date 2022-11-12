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
    class TypeRole
    {
        string typeRole;
        int id;
        public TypeRole() { }
        public TypeRole(int id,string typeRole) {
            this.typeRole = typeRole;
            this.id = id;
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
                string id = rows["roleId"].ToString();
                string typeRole = rows["roleType"].ToString();
           

                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(typeRole);
        

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
        public void insert(TypeRole t)
        {
            string sql = "insert into role(roleType) values ('" + t.typeRole + "')";
            Execute(sql);
        }

        public void update(TypeRole t)
        {
            string sql = "Update role set typeRole= '" + t.typeRole + "' where roleId = "+t.id+"";
            Execute(sql);
        }
        public void Del(TypeRole t)
        {
            string sql = "Delete from role where roleId = " + t.id + " ";
            Execute(sql);
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
