using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyKho
{
    public partial class InKhachHang : Form
    {
        public InKhachHang()
        {
            InitializeComponent();
        }

        private void InKhachHang_Load(object sender, EventArgs e)
        {
            KhachHangC kh = new KhachHangC();
            cbkh.DataSource = kh.Load("select * FROM Customer");
            cbkh.DisplayMember = "IdCustomer";
            cbkh.ValueMember = "IdCustomer";
            cbkh.SelectedIndex = -1;
            this.report_kh.RefreshReport();
        }

        private void In1nguoi_Click(object sender, EventArgs e)
        {
            if (cbkh.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select cs.IdCustomer,DisplayName,Address,Phone,Email,ContractDate,op.IdObject from Customer cs inner join Output op on cs.IdCustomer = op.IdCustomer where cs.IdCustomer = '" + cbkh.SelectedValue.ToString() + "'";

                KhachHangC kh = new KhachHangC();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_kh.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_kh.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_KH.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdCustomer");
                ht.Values.Add(cbkh.Text);
                report_kh.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet_KH";
                    rds.Value = dt;
                    report_kh.LocalReport.DataSources.Clear();
                    report_kh.LocalReport.DataSources.Add(rds);
                    report_kh.RefreshReport();
                }
                else
                {

                    MessageBox.Show("Không có dữ liệu!");
                }
            }
        }

        private void Inall_Click(object sender, EventArgs e)
        {
            if (cbkh.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select cs.IdCustomer,DisplayName,Address,Phone,Email,ContractDate,op.IdObject from Customer cs inner join Output op on cs.IdCustomer = op.IdCustomer";

                KhachHangC kh = new KhachHangC();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_kh.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_kh.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_KH.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdCustomer");
                ht.Values.Add(cbkh.Text);
                report_kh.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet_KH"; rds.Value = dt;
                    report_kh.LocalReport.DataSources.Clear();
                    report_kh.LocalReport.DataSources.Add(rds);
                    report_kh.RefreshReport();
                }
                else
                {

                    MessageBox.Show("Không có dữ liệu!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
