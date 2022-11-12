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
    public partial class InNCC : Form
    {
        public InNCC()
        {
            InitializeComponent();
        }

        private void InNCC_Load(object sender, EventArgs e)
        {
            Suplier kh = new Suplier();
            cbncc.DataSource = kh.Load("select * from Suplier");
            cbncc.DisplayMember = "IdSuplier";
            cbncc.ValueMember = "IdSuplier";
            cbncc.SelectedIndex = -1;
            this.report_ncc.RefreshReport();
        }

        private void innhacc_Click(object sender, EventArgs e)
        {
            if (cbncc.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select sp.IdSuplier,DisplayName,Address,Phone,Email,IdObject as HangCC,amount as SLCC ,ContractDate from Suplier sp inner join Input ip on sp.IdSuplier = ip.IdSuplier where sp.IdSuplier = '" + cbncc.SelectedValue.ToString() + "'";

                Suplier kh = new Suplier();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_ncc.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_ncc.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_NCC.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdSuplier");
                ht.Values.Add(cbncc.Text);
                report_ncc.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "NCC";
                    rds.Value = dt;
                    report_ncc.LocalReport.DataSources.Clear();
                    report_ncc.LocalReport.DataSources.Add(rds);
                    report_ncc.RefreshReport();
                }
                else
                {

                    MessageBox.Show("Không có dữ liệu!");
                }
            }
        }

        private void inds_Click(object sender, EventArgs e)
        {
            if (cbncc.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select sp.IdSuplier,DisplayName,Address,Phone,Email,IdObject as HangCC,amount as SLCC ,ContractDate from Suplier sp inner join Input ip on sp.IdSuplier = ip.IdSuplier ";

                Suplier kh = new Suplier();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_ncc.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_ncc.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_NCC.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdSuplier");
                ht.Values.Add(cbncc.Text);
                report_ncc.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "NCC";
                    rds.Value = dt;
                    report_ncc.LocalReport.DataSources.Clear();
                    report_ncc.LocalReport.DataSources.Add(rds);
                    report_ncc.RefreshReport();
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
