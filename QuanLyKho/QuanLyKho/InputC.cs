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
    class InputC
    {
        string id, idObject,idSuplier;
        int amount, inprice, outprice;
        string status;
        DateTime datein;
        public InputC() { }
        public InputC(string id, string idObject,string idSuplier,int amount, int inprice, int outprice,string status,DateTime datein) {
            this.id = id;
            this.idObject = idObject;
            this.idSuplier = idSuplier;
            this.amount = amount;
            this.inprice = inprice;
            this.outprice = outprice;
            this.status = status;
            this.datein = datein;
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
                string id = rows["IdInput"].ToString();
                string idObject = rows["IdObject"].ToString();
                string idSuplier = rows["IdSuplier"].ToString();
                string amount = rows["amount"].ToString();
                string inprice = rows["InputPrice"].ToString();
                string outprice = rows["OutputPrice"].ToString();
                string status = rows["Status"].ToString();
                string datein = rows["DateInput"].ToString();


                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(id);
                item.Items[i].SubItems.Add(idObject);
                item.Items[i].SubItems.Add(idSuplier);
                item.Items[i].SubItems.Add(amount);
                item.Items[i].SubItems.Add(inprice);
                item.Items[i].SubItems.Add(outprice);
                item.Items[i].SubItems.Add(status);
                item.Items[i].SubItems.Add(datein);


                i = i + 1;
            }
        }

        public void insert(InputC ob)
        {
            string sql = "insert into Input values ('" + ob.id + "','" + ob.idObject + "'," + ob.amount + "," + ob.inprice + "," + ob.outprice + ",'" + ob.status + "','"+ob.datein+"','"+ob.idSuplier+"')";
            Execute(sql);
        }

        public void update(InputC ob)
        {
            string sql = "Update Input set IdObject= '" + ob.idObject + "', amount = " + ob.amount + ",InputPrice = " + ob.inprice + ",OutputPrice = " + ob.outprice + ",Status='" + ob.status + "',DateInput='"+ob.datein+"',IdSuplier='"+ob.idSuplier+"' where IdInput = '" + ob.id + "'";
            Execute(sql);
        }
        public void Del(InputC ob)
        {
            string sql = "Delete from Input where IdInput = '" + ob.id + "' ";
            Execute(sql);
        }
        public void delall()
        {
            string sql = "DELETE FROM Input ";
            Execute(sql);
        }


        public bool KT_key(string key)
        {
            bool kt = false;
            string sql = "select IdInput from Input";
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                string masp = row["IdInput"].ToString();
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
