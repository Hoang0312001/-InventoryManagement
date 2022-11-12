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
    class Suplier
    {
        string id, name, address, phone, email;
        DateTime ContractDate;
        public Suplier(){
        }
         public Suplier(string id, string name,string  address,string  phone,string  email,DateTime ContractDate){
             this.id = id;
             this.name = name;
             this.address = address;
             this.phone = phone;
             this.email = email;
             this.ContractDate = ContractDate;
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
                 string id = rows["IdSuplier"].ToString();
                 string name = rows["DisplayName"].ToString();
                 string address = rows["Address"].ToString();
                 string phone = rows["Phone"].ToString();
                 string email = rows["Email"].ToString();
                 string contractDate = rows["ContractDate"].ToString();

                 item.Items.Add((i + 1).ToString());
                 item.Items[i].SubItems.Add(id);
                 item.Items[i].SubItems.Add(name);
                 item.Items[i].SubItems.Add(address);
                 item.Items[i].SubItems.Add(phone);
                 item.Items[i].SubItems.Add(email);
                 item.Items[i].SubItems.Add(contractDate);

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

         public void insert(Suplier sp)
         {
             string sql = "insert into Suplier values ('" + sp.id + "','" + sp.name + "','" + sp.address + "','" + sp.phone + "','" + sp.email + "','" + sp.ContractDate + "')";
             Execute(sql);
         }
         public void update(Suplier sp)
         {
             string sql = "Update Suplier set DisplayName= '" + sp.name + "', Address = '" + sp.address + "',Phone = '" + sp.phone + "',Email = '" + sp.email + "',ContractDate='" + sp.ContractDate + "' where IdSuplier = '" + sp.id + "'";
             Execute(sql);
         }
         public void Del(Suplier sp)
         {
             string sql = "Delete from Suplier where IdSuplier = '" + sp.id + "' ";
             Execute(sql);
         }
         public void delall()
         {
             string sql = "DELETE FROM Suplier ";
             Execute(sql);
         }
         public bool KT_key(string key)
         {
             bool kt = false;
             string sql = "select IdSuplier from Suplier";
             DataTable dt = new DataTable();
             SqlCommand comSelect = new SqlCommand(sql, con);
             SqlDataAdapter da = new SqlDataAdapter();
             da.SelectCommand = comSelect;
             da.Fill(dt);
             dt.AcceptChanges();
             foreach (DataRow row in dt.Rows)
             {
                 string masp = row["IdSuplier"].ToString();
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
