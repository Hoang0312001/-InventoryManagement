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
    class UnitC
    {
        string id, name;
        public UnitC() { }
        public UnitC(string id,string name) {
            this.id = id;
            this.name=name;
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
                string id = rows["IdUnit"].ToString();
                string name = rows["DisplayName"].ToString();
 

                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(id);
                item.Items[i].SubItems.Add(name);
    
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
        public void insert(UnitC kh)
        {
            string sql = "insert into Unit values ('" + kh.id + "','" + kh.name + "')";
            Execute(sql);
        }

        public void update(UnitC kh)
        {
            string sql = "Update Unit set DisplayName= '" + kh.name + "' where IdUnit = '" + kh.id + "'";
            Execute(sql);
        }
        public void Del(UnitC kh)
        {
            string sql = "Delete from Unit where IdUnit = '" + kh.id + "' ";
            Execute(sql);
        }
        public void delall()
        {
            string sql = "DELETE FROM Unit ";
            Execute(sql);
        }


        public bool KT_key(string key)
        {
            bool kt = false;
            string sql = "select IdUnit from Unit";
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                string masp = row["IdUnit"].ToString();
                if (String.Compare(masp.Trim(), key.Trim(), true) == 0)
                {
                    kt = true;
                    break;
                }


            }
            return kt;
        }

    }
}
