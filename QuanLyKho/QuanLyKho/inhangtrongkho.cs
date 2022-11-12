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
    public partial class inhangtrongkho : Form
    {
        public inhangtrongkho()
        {
            InitializeComponent();
        }

        private void inhangtrongkho_Load(object sender, EventArgs e)
        {
            KHO_C kh = new KHO_C();
            cbkho.DataSource = kh.Load("select * from KHO");
            cbkho.DisplayMember = "IdObject";
            cbkho.ValueMember = "IdObject";
            cbkho.SelectedIndex = -1;
            this.report_kho.RefreshReport();
            this.report_kho.RefreshReport();
        }

        private void in1_Click(object sender, EventArgs e)
        {
            if (cbkho.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "SELECT k.MaKho,k.IdEmployee,k.IdObject,o.DisplayName,SLChua,op.Status,op.amount as sldachuyen FROM KHO k inner join Output op on k.MaKho = op.MaKho inner join Object o on o.IdObject = k.IdObject  where k.IdObject = '" + cbkho.SelectedValue.ToString() + "'";
                KHO_C k = new KHO_C();
                DataTable dt = new DataTable();
                dt = k.Load(sql);
                report_kho.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_kho.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_kho.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("MaKho");
                ht.Values.Add(cbkho.Text);
                report_kho.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = dt;
                    report_kho.LocalReport.DataSources.Clear();
                    report_kho.LocalReport.DataSources.Add(rds);
                    report_kho.RefreshReport();
                }
                else
                {

                    MessageBox.Show("Không có dữ liệu!");
                }
            }

        }

        private void inds_Click(object sender, EventArgs e)
        {
            if (cbkho.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "SELECT k.MaKho,k.IdEmployee,k.IdObject,o.DisplayName,SLChua,op.Status,op.amount as sldachuyen FROM KHO k inner join Output op on k.MaKho = op.MaKho inner join Object o on o.IdObject = k.IdObject";
                KHO_C k = new KHO_C();
                DataTable dt = new DataTable(); 
                dt = k.Load(sql);
                report_kho.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_kho.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_kho.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("MaKho");
                ht.Values.Add(cbkho.Text);
                report_kho.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = dt;
                    report_kho.LocalReport.DataSources.Clear();
                    report_kho.LocalReport.DataSources.Add(rds);
                    report_kho.RefreshReport();
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
