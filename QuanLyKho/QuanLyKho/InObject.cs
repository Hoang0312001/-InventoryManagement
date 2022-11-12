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
    public partial class InObject : Form
    {
        public InObject()
        {
            InitializeComponent();
        }

        private void InObject_Load(object sender, EventArgs e)
        {
            ObjectC kh = new ObjectC();
            cbmh.DataSource = kh.Load("select * from Object");
            cbmh.DisplayMember = "IdObject";
            cbmh.ValueMember = "IdObject";
            cbmh.SelectedIndex = -1;
            this.report_ob.RefreshReport();
        }

        private void intt_Click(object sender, EventArgs e)
        {
            if (cbmh.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select  DISTINCT ob.IdObject,DisplayName,IdUnit,ob.IdSuplier,ob.amount,ip.InputPrice,ip.OutputPrice,ob.amount*ip.InputPrice as tongtienmuavao ,ip.Status,QRCode from  Object ob inner join Input ip on ob.IdObject = ip.IdObject inner join KHO k on k.IdObject = ob.IdObject where ob.IdObject = '" + cbmh.SelectedValue.ToString() + "' ";

                ObjectC kh = new ObjectC();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_ob.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_ob.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_ob.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdObject");
                ht.Values.Add(cbmh.Text);
                report_ob.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = dt;
                    report_ob.LocalReport.DataSources.Clear();
                    report_ob.LocalReport.DataSources.Add(rds);
                    report_ob.RefreshReport();
                }
                else
                {

                    MessageBox.Show("Không có dữ liệu!");
                }
            }
        }

        private void indstt_Click(object sender, EventArgs e)
        {
            if (cbmh.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select  DISTINCT ob.IdObject,DisplayName,IdUnit,ob.IdSuplier,ob.amount,ip.InputPrice,ip.OutputPrice,ob.amount*ip.InputPrice as tongtienmuavao ,ip.Status,QRCode from  Object ob inner join Input ip on ob.IdObject = ip.IdObject inner join KHO k on k.IdObject = ob.IdObject";

                ObjectC kh = new ObjectC();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_ob.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_ob.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_ob.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdObject");
                ht.Values.Add(cbmh.Text);
                report_ob.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = dt;
                    report_ob.LocalReport.DataSources.Clear();
                    report_ob.LocalReport.DataSources.Add(rds);
                    report_ob.RefreshReport();
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
