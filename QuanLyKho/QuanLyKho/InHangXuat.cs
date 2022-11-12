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
    public partial class InHangXuat : Form
    {
        public InHangXuat()
        {
            InitializeComponent();
        }

        private void InHangXuat_Load(object sender, EventArgs e)
        {
            OutPutC kh = new OutPutC();
            cbout.DataSource = kh.Load("select * from Output");
            cbout.DisplayMember = "IdObject";
            cbout.ValueMember = "IdObject";
            cbout.SelectedIndex = -1;
            this.report_out.RefreshReport();
        }

        private void intheoma_Click(object sender, EventArgs e)
        {
            if (cbout.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select IdOutput,IdCustomer,op.IdInput,op.IdObject,op.IdSuplier,op.amount,ip.OutputPrice as giatien,op.Status,MaKho,op.amount*ip.OutputPrice as thanhtien from Output op inner join Input ip on op.IdObject = ip.IdObject where ob.IdObject = '" + cbout.SelectedValue.ToString() + "'";
                OutPutC kh = new OutPutC();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_out.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_out.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_out.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdOutput");
                ht.Values.Add(cbout.Text);
                report_out.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = dt;
                    report_out.LocalReport.DataSources.Clear();
                    report_out.LocalReport.DataSources.Add(rds);
                    report_out.RefreshReport();
                }
                else
                {

                    MessageBox.Show("Không có dữ liệu!");
                }
            }
        }

        private void inds_Click(object sender, EventArgs e)
        {
            if (cbout.SelectedValue == null)
            {
                return;
            }
            else {
                string sql = "select IdOutput,IdCustomer,op.IdInput,op.IdObject,op.IdSuplier,op.amount,ip.OutputPrice as giatien,op.Status,MaKho,op.amount*ip.OutputPrice as thanhtien from Output op inner join Input ip on op.IdObject = ip.IdObject";
                OutPutC kh = new OutPutC();
                DataTable dt = new DataTable();
                dt = kh.Load(sql);
                report_out.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                report_out.LocalReport.ReportPath = @"E:\WINMFORM_C#\QuanLyKho\QuanLyKho\QuanLyKho\Report_out.rdlc";
                //truyen bien
                ReportParameter ht = new ReportParameter("IdOutput");
                ht.Values.Add(cbout.Text);
                report_out.LocalReport.SetParameters(ht);
                if (dt.Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = dt;
                    report_out.LocalReport.DataSources.Clear();
                    report_out.LocalReport.DataSources.Add(rds);
                    report_out.RefreshReport();
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
