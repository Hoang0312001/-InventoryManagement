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
    class KHO_C
    {
        string id, idEmp, idob;
        int sl;
        public KHO_C() { }
        public KHO_C( string id,string idEmp,string idob,int sl) {
            this.id = id;
            this.idEmp = idEmp;
            this.idob = idob;
            this.sl = sl;
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
                string id = rows["MaKho"].ToString();
                string idEmp = rows["IdEmployee"].ToString();
                string idob = rows["IdObject"].ToString();
                string sl = rows["SLChua"].ToString();
     
          


                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(id);
                item.Items[i].SubItems.Add(idEmp);
                item.Items[i].SubItems.Add(idob);
                item.Items[i].SubItems.Add(sl);
               
                i = i + 1;
            }
        }

        public void insert(KHO_C k)
        {
            string sql = "insert into KHO values ('" + k.id + "','" + k.idEmp + "','" + k.idob + "'," + k.sl+ ")";
            Execute(sql);
        }

        public void update(KHO_C k)
        {
            string sql = "Update KHO set IdEmployee= '" + k.idEmp + "',IdObject='" + k.idob + "',SLChua=" + k.sl + " where MaKho = '" + k.id + "'";
            Execute(sql);
        }
        public void Del(KHO_C k)
        {
            string sql = "Delete from KHO where MaKho = '" + k.id + "' ";
            Execute(sql);
        }
        public void delall()
        {
            string sql = "DELETE FROM KHO ";
            Execute(sql);
        }
        public bool KT_key(string key)
        {
            bool kt = false;
            string sql = "select MaKho from KHO";
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                string masp = row["MaKho"].ToString();
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
        public void Execute(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }


    }
}
