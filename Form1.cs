using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    public partial class Form1 : Form
    {
        DataGridView dataGrid = new DataGridView();
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyBanHangCongTyKinhDoangMayTinhDataSet.tblNhanVien' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'DataSetNhanVien.tblNhanVien' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'DataSetNhanVien.tblNhanVien' table. You can move, or remove it, as needed.
            this.reportViewerNhanVien.RefreshReport();
        }

        private void reportViewerNhanVien_Load(object sender, EventArgs e)
        {
            try
            {

           /*     DataTable tbl = new DataTable();
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //cmd.CommandText = "SearchNhanVien";
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(table);
                    MessageBox.Show(tbl.Rows.Count + " ");
                    
                }*/
                reportViewerNhanVien.ProcessingMode = ProcessingMode.Local;
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                reportDataSource1.Name = "DataSetNhanVien";
                //reportDataSource1.Value = dataGrid;
                reportViewerNhanVien.LocalReport.DataSources.Add(reportDataSource1);
                reportViewerNhanVien.LocalReport.ReportPath = @"D:\SOFTWARE ENGINEER\Huong_Su_Kien\BTL_HSK\BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH\rdlcNhanVien.rdlc";
                reportViewerNhanVien.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void reportViewerNhanVien_Load_1(object sender, EventArgs e)
        {

        }
    }
}
