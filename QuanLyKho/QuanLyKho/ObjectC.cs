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
    class ObjectC
    {
        string id, name, idUnit,idSup, qrCode;
        int amount;
        public ObjectC() { }
        public ObjectC(string id, string name, string idUnit,string idSup,int amount, string qrCode) {
            this.id = id;
            this.name = name;
            this.idUnit = idUnit;
            this.idSup = idSup;
            this.amount = amount;
            this.qrCode = qrCode;
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
                string id = rows["IdObject"].ToString();
                string name = rows["DisplayName"].ToString();
                string idUnit = rows["IdUnit"].ToString();
                string idSup = rows["IdSuplier"].ToString();
                string amount = rows["amount"].ToString();
                string qrCode = rows["QRCode"].ToString();

                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(id);
                item.Items[i].SubItems.Add(name);
                item.Items[i].SubItems.Add(idUnit);
                item.Items[i].SubItems.Add(idSup);
                item.Items[i].SubItems.Add(amount);
                item.Items[i].SubItems.Add(qrCode);

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
        public void insert(ObjectC ob)
        {
            string sql = "insert into Object values ('" + ob.id + "','" + ob.name + "','" + ob.idUnit + "','" + ob.idSup + "'," + ob.amount + ",'" + ob.qrCode + "')";
            Execute(sql);
        }

        public void update(ObjectC ob)
        {
            string sql = "Update Object set DisplayName= '" + ob.name + "', IdUnit = '" + ob.idUnit + "',IdSuplier = '" + ob.idSup + "',amount = '" + ob.amount + "',QRCode='" +ob.qrCode + "' where IdObject = '" + ob.id + "'";
            Execute(sql);
        }
        public void Del(ObjectC ob)
        {
            string sql = "Delete from Object where IdObject = '" + ob.id + "' ";
            Execute(sql);
        }
        public void delall()
        {
            string sql = "DELETE FROM Object ";
            Execute(sql);
        }


        public bool KT_key(string key)
        {
            bool kt = false;
            string sql = "select IdObject from Object";
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                string masp = row["IdObject"].ToString();
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
