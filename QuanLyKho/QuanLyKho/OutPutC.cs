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
    class OutPutC
    {
        string id, idcus, idemp, idin, idob, idsup;
        int price, amount;
        string status;
        DateTime dateout;
        string makho;
        public OutPutC() { }       
        public OutPutC(string id, string idcus, string idemp,string idin, string idob, string idsup,int price, int amount,string status,DateTime dateout,string makho) {
            this.id = id;
            this.idcus = idcus;
            this.idemp = idemp;
            this.idin = idin;
            this.idob = idob;
            this.idsup = idsup;
            this.price = price;
            this.amount = amount;
            this.status = status;
            this.dateout = dateout;
            this.makho = makho;
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
                string id = rows["IdOutput"].ToString();
                string idcus = rows["IdCustomer"].ToString();
                string idemp = rows["IdEmployee"].ToString();
                string idin = rows["IdInput"].ToString();
                string idob = rows["IdObject"].ToString();
                string idsup = rows["IdSuplier"].ToString();
                string price = rows["price"].ToString();
                string amount = rows["amount"].ToString();
                string status = rows["Status"].ToString();
                string dateout = rows["DateOutput"].ToString();
                string makho = rows["MaKho"].ToString();
              
                

                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(id);
                item.Items[i].SubItems.Add(idcus);
                item.Items[i].SubItems.Add(idemp);
                item.Items[i].SubItems.Add(idin);
                item.Items[i].SubItems.Add(idob);
                item.Items[i].SubItems.Add(idsup);
                item.Items[i].SubItems.Add(price);
                item.Items[i].SubItems.Add(amount);
                item.Items[i].SubItems.Add(status);
                item.Items[i].SubItems.Add(dateout);
                item.Items[i].SubItems.Add(makho);

                i = i + 1;
            }
        }

        public void insert(OutPutC op)
        {
            string sql = "insert into Output values ('" + op.id + "','" + op.idcus + "','" + op.idemp + "','"+op.idin+"','"+op.idob+"','"+op.idsup+"',"+op.price+","+op.amount+",'"+op.status+"','"+op.dateout+"','"+op.makho+"')";
            Execute(sql);
        }
        public void update(OutPutC op)
        {
            string sql = "Update Output set IdCustomer= '" + op.idcus + "', IdEmployee = '" + op.idemp + "',IdInput='" + op.idin + "',IdObject='" + op.idob + "',IdSuplier='" + op.idsup + "',price=" + op.price + ",amount=" + op.amount + ",Status='" + op.status + "',DateOutput='" + op.dateout + "',MaKho ='"+op.makho+"' where IdOutput = '" + op.id + "'";
            Execute(sql);
        }
        public void Del(OutPutC op)
        {
            string sql = "Delete from Output where IdOutput = '" + op.id + "' ";
            Execute(sql);
        }
        public void delall()
        {
            string sql = "DELETE FROM Output";
            Execute(sql);
        }

        public bool KT_key(string key)
        {
            bool kt = false;
            string sql = "select IdOutput from Output";
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                string masp = row["IdOutput"].ToString();
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
