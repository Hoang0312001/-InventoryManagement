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
    class KhachHangC
    {
        string id;
        string name,address,phone,email;
        DateTime contractDate;
        public KhachHangC() { }
        public KhachHangC(string id,string name,string address,string phone,string email,DateTime contractDate) {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
        
            this.contractDate = contractDate;
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
                string id = rows["IdCustomer"].ToString();
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
      public void insert(KhachHangC kh)
        {
            string sql = "insert into Customer values ('"+kh.id+"','" + kh.name + "','" + kh.address + "','" + kh.phone + "','"+kh.email+"','"+kh.contractDate+"')";
            Execute(sql);
        }

      public void update(KhachHangC kh)
      {
          string sql = "Update Customer set DisplayName= '" + kh.name + "', Address = '" + kh.address + "',Phone = '" + kh.phone + "',Email = '" + kh.email + "',ContractDate='" + kh.contractDate + "' where IdCustomer = '" + kh.id + "'";
          Execute(sql);

        
      }
      public void Del(KhachHangC kh)
      {
          string sql = "Delete from Customer where IdCustomer = '" + kh.id + "' ";
          Execute(sql);
      }
     public void delall()
      {
          string sql = "DELETE FROM Customer ";
          Execute(sql);
      }
  
   
      public bool KT_key(string key)
      {
          bool kt = false;
          string sql = "select IdCustomer from Customer";
          DataTable dt = new DataTable();
          SqlCommand comSelect = new SqlCommand(sql, con);
          SqlDataAdapter da = new SqlDataAdapter();
          da.SelectCommand = comSelect;
          da.Fill(dt);
          dt.AcceptChanges();
          foreach (DataRow row in dt.Rows)
          {
              string masp = row["IdCustomer"].ToString();
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

