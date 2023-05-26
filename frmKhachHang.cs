using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Validate;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    public partial class frmKhachHang : Form
    {
        private static string strMafind;
        public frmKhachHang()
        {
            InitializeComponent();
            hideMessage();
        }

        private void hideMessage()
        {
            Validates.HideMessage(lbMaErr);
            Validates.HideMessage(lbDiaChiErr);
            Validates.HideMessage(lbDienThoaiErr);
            Validates.HideMessage(lbTenErr);
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Utils.getData("select * from [dbo].[tblKhachHang]", dataGridViewKhachHang);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang(tbMaKhachHang.Text , tbTenKhachHang.Text, tbDiaChi.Text , tbDienThoai.Text);

            if (
                Validates.checkMessage(kh.MaKhachHang, lbMaErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(kh.TenKhachHang, lbTenErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(kh.DiaChi, lbDiaChiErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(kh.DienThoai, lbDienThoaiErr, Utils.MESSAGE_LENGTH, Utils.LENGTH_PHONE))
            {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Utils.insertKhachHang;
                        cmd.Parameters.AddWithValue("@sMaKh", kh.MaKhachHang);
                        cmd.Parameters.AddWithValue("@sTenKh", kh.TenKhachHang);
                        cmd.Parameters.AddWithValue("@sDiaChi", kh.DiaChi);
                        cmd.Parameters.AddWithValue("@sDienThoai", kh.DienThoai);
                        cmd.ExecuteNonQuery();
                        btnGetAll_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = Connection.getConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = Utils.DeleteKhachHang;
                    cmd.Parameters.AddWithValue("@sMaKh", strMafind);
                    cmd.ExecuteNonQuery();
                    btnGetAll_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang(tbMaKhachHang.Text, tbTenKhachHang.Text, tbDiaChi.Text, tbDienThoai.Text);
            if (
                Validates.checkMessage(kh.MaKhachHang, lbMaErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(kh.TenKhachHang, lbTenErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(kh.DiaChi, lbDiaChiErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(kh.DienThoai, lbDienThoaiErr, Utils.MESSAGE_LENGTH, Utils.LENGTH_PHONE))
            {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Utils.UpdateKhachHang;
                        cmd.Parameters.AddWithValue("@sMaKh", kh.MaKhachHang);
                        cmd.Parameters.AddWithValue("@sTenKh", kh.TenKhachHang);
                        cmd.Parameters.AddWithValue("@sDiaChi", kh.DiaChi);
                        cmd.Parameters.AddWithValue("@sDienThoai", kh.DienThoai);
                        cmd.ExecuteNonQuery();
                        btnGetAll_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            Utils.getData("select * from [dbo].[tblKhachHang]", dataGridViewKhachHang);
        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*  Fomatvalue : final index get value
                Value : change index get value
             */
            try
            {
                if (dataGridViewKhachHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    strMafind = dataGridViewKhachHang.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbMaKhachHang.Text = dataGridViewKhachHang.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbTenKhachHang.Text = dataGridViewKhachHang.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    tbDiaChi.Text = dataGridViewKhachHang.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    tbDienThoai.Text = dataGridViewKhachHang.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có index" + ex.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable tbl = new DataTable();
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "select * from tblKhachHang";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(tbl);
                    MessageBox.Show(tbl.Rows.Count + " ");

                }
                frmReportKhachHang f = new frmReportKhachHang();
                f.reportViewer1.ProcessingMode = ProcessingMode.Local;
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                reportDataSource1.Name = "DataSet1";
                reportDataSource1.Value = tbl;
                f.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                f.reportViewer1.LocalReport.ReportPath = @"D:\SOFTWARE ENGINEER\Huong_Su_Kien\BTL_HSK\BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH\rdlcKhachHang.rdlc";
                f.reportViewer1.RefreshReport();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
