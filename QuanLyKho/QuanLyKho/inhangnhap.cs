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
    public partial class inhangnhap : Form
    {
        public inhangnhap()
        {
            InitializeComponent();
        }

        private void inhangnhap_Load(object sender, EventArgs e)
        {
            InputC kh = new InputC();
            cbin.DataSource = kh.Load("select * from Input");
            cbin.DisplayMember = "IdObject";
            cbin.ValueMember = "IdObject";
            cbin.SelectedIndex = -1;
            this.report_in.RefreshReport();
        }

        private void inone_Click(object sender, EventArgs e)
        {
            if (cbin.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select IdInput,IdObject,amount,InputPrice,Status,IdSuplier,InputPrice*amount as Thanhtien,DateInput from Input where IdObject= '" + cbin.SelectedValue.ToString() + "' ";
                InputC kh = new InputC();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_in.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_in.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_in.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdInput");
                ht.Values.Add(cbin.Text);
                report_in.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = dt;
                    report_in.LocalReport.DataSources.Clear();
                    report_in.LocalReport.DataSources.Add(rds);
                    report_in.RefreshReport();
                }
                else
                {

                    MessageBox.Show("Không có dữ liệu!");
                }
            }
        }

        private void inds_Click(object sender, EventArgs e)

        {
            if (cbin.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select IdInput,IdObject,amount,InputPrice,Status,IdSuplier,InputPrice*amount as Thanhtien from Input ";
                InputC kh = new InputC();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_in.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_in.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_in.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdInput");
                ht.Values.Add(cbin.Text);
                report_in.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = dt;
                    report_in.LocalReport.DataSources.Clear();
                    report_in.LocalReport.DataSources.Add(rds);
                    report_in.RefreshReport();
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
