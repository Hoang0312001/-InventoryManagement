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
    public partial class InNhanVien : Form
    {
        public InNhanVien()
        {
            InitializeComponent();
        }

        private void InNhanVien_Load(object sender, EventArgs e)
        {
            EmployeeC kh = new EmployeeC();
            cbnv.DataSource = kh.Load("select * from Employee");
            cbnv.DisplayMember = "IdEmployee";
            cbnv.ValueMember = "IdEmployee";
            cbnv.SelectedIndex = -1;
            this.report_nv.RefreshReport();
        }

        private void innv_Click(object sender, EventArgs e)
        {
            if (cbnv.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select DisplayName, Position from Employee where IdEmployee = '" + cbnv.SelectedValue.ToString() + "'";

                EmployeeC kh = new EmployeeC();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_nv.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_nv.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_NV.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdEmployee");
                ht.Values.Add(cbnv.Text);
                report_nv.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "NV";
                    rds.Value = dt;
                    report_nv.LocalReport.DataSources.Clear();
                    report_nv.LocalReport.DataSources.Add(rds);
                    report_nv.RefreshReport();
                }
                else
                {

                    MessageBox.Show("Không có dữ liệu!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbnv.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select * from Employee ";

                EmployeeC kh = new EmployeeC();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_nv.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_nv.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_NV.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdEmployee");
                ht.Values.Add(cbnv.Text);
                report_nv.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "NV";
                    rds.Value = dt;
                    report_nv.LocalReport.DataSources.Clear();
                    report_nv.LocalReport.DataSources.Add(rds);
                    report_nv.RefreshReport();
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
