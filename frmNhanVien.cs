
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Validate;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Util;
using System.Text.RegularExpressions;
using Microsoft.Reporting.WinForms;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{

    public partial class frmNhanVien : Form
    {
        static string maNhanVien;
        static string tenNhanVien;
        static string dienThoai;
        static string diaChi;
        static string ngaySinh;
        static string ngayVaoLam;
        static DataTable tableNhanVien = new DataTable();
        private static string strMafind;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            Utils.getData("SELECT [sMaNV], [sTenNV], [bGioiTinh], [sDienthoai], [dNgayvaolam], [dNgaysinh], [sDiachi],[userRole] , sGhiChu FROM [dbo].[tblNhanVien]", dataGridViewNhanVien);
        }


        /*Validate Info , and add info */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            maNhanVien = tbMaNhanVien.Text;
            tenNhanVien = tbTenNhanVien.Text;
            diaChi = tbDiaChi.Text;
            dienThoai = tbDienThoai.Text;
            ngayVaoLam = mtNgayVaoLam.Text;
            ngaySinh = mtNgaySinh.Text;
            bool checkGioiTinh = true;
            if (rbNu.Checked)
            {
                checkGioiTinh = false;
            }

            /*  Validate trước khi add vào dữ liệu
                4 paramater : info , show message , tên thông báo , độ dài )
             */

       
            if (
                Validates.checkMessage(maNhanVien, lbMaErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(tenNhanVien, lbTenErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(diaChi, lbDiaChiErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(dienThoai, lbDienThoaiErr, Utils.MESSAGE_LENGTH, Utils.LENGTH_PHONE) &&
                Validates.checkMessage(ngaySinh, lbNgaySinhErr, Utils.NGAY) &&
                Validates.checkMessage(ngayVaoLam, lbNgayLamErr, Utils.NGAY))
            {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "UpdateNhanVien";
                        cmd.Parameters.AddWithValue("@sMaNhanVien", maNhanVien);
                        cmd.Parameters.AddWithValue("@sTenNhanVien", tenNhanVien);
                        cmd.Parameters.AddWithValue("@bGioiTinh", checkGioiTinh);
                        cmd.Parameters.AddWithValue("@sDiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@sDienThoai", dienThoai);
                        cmd.Parameters.AddWithValue("@dNgaySinh", Convert.ToDateTime(ngaySinh));
                        cmd.Parameters.AddWithValue("@dNgayVaoLam", Convert.ToDateTime(ngayVaoLam));
                        cmd.Parameters.AddWithValue("@userRole", tbQuyen.Text);
                        cmd.Parameters.AddWithValue("@sGhiChu", richTextBox1.Text.ToString());
                        cmd.ExecuteNonQuery();
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
            DataTable table = new DataTable();
            using (SqlCommand cmd = Connection.getConnection().CreateCommand())
            {
                try
                {
                    if(MessageBox.Show( "Xác nhận","Bạn chắc chắn muốn xóa", MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "deleteNhanVien";
                        cmd.Parameters.AddWithValue("@sMaNhanVien", strMafind);
                        table.Load(cmd.ExecuteReader());
                        cmd.ExecuteNonQuery();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridViewNhanVien.DataSource = table;
            }
        }
        /*
         * Get Value datagripview where user click row
         */
        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*  Fomatvalue : final index get value
                Value : change index get value
             */
            try
            {
                if (dataGridViewNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    strMafind = dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbMaNhanVien.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbTenNhanVien.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    string check =  dataGridViewNhanVien.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    if (check.Equals("True"))
                        rbNam.Checked = true;
                    else if (check.Equals("False"))
                        rbNu.Checked = true;
                    tbDienThoai.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    mtNgayVaoLam.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    mtNgaySinh.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    tbDiaChi.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    tbQuyen.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                    tbMota.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có index" + ex.Message);
            }

        }

        private void frmNhanVien_EnabledChanged(object sender, EventArgs e)
        {
            MessageBox.Show("aa: " + sender.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            maNhanVien = tbMaNhanVien.Text;
            tenNhanVien = tbTenNhanVien.Text;
            diaChi = tbDiaChi.Text;
            dienThoai = tbDienThoai.Text;
            ngayVaoLam = mtNgayVaoLam.Text;
            ngaySinh = mtNgaySinh.Text;
            bool checkGioiTinh = true;
            if (rbNu.Checked)
            {
                checkGioiTinh = false;
            }
            using (SqlCommand cmd = Connection.getConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = Utils.UpdateNhanVien;
                    cmd.Parameters.AddWithValue("@sMaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@sTenNhanVien", tenNhanVien);
                    cmd.Parameters.AddWithValue("@bGioiTinh", checkGioiTinh);
                    cmd.Parameters.AddWithValue("@sDiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@sDienThoai", dienThoai);
                    cmd.Parameters.AddWithValue("@dNgaySinh", Convert.ToDateTime(ngaySinh));
                    cmd.Parameters.AddWithValue("@dNgayVaoLam", Convert.ToDateTime(ngayVaoLam));
                    cmd.Parameters.AddWithValue("@userRole", tbQuyen.Text);
                    cmd.Parameters.AddWithValue("@sGhiChu", "");
                    cmd.ExecuteNonQuery();
                    btnGetAll_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                btnAdd.Enabled = false;
            }
            else btnAdd.Enabled = true;

            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Utils.getData("SELECT [sMaNV], [sTenNV], [bGioiTinh], [sDienthoai], [dNgayvaolam], [dNgaysinh], [sDiachi] , [userRole] , [sGhiChu] FROM [dbo].[tblNhanVien]", dataGridViewNhanVien);

            Utils.getData("select * from tblThongTin", dataGridViewGhiChu);



            /*using (SqlCommand cmd = Connection.getConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from tblThongTin";
                    tableNhanVien.Clear();
                    tableNhanVien.Load(cmd.ExecuteReader());
                    cmd.ExecuteNonQuery();
                    dataGridViewNhanVien.DataSource = tableNhanVien;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
            /*if(richTextBox1.Text.Equals(""))
            {
                btnAdd.Enabled = false;
            }*/
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            maNhanVien = tbMaNhanVien.Text;
            tenNhanVien = tbTenNhanVien.Text;
            diaChi = tbDiaChi.Text;
            dienThoai = tbDienThoai.Text;
            ngayVaoLam = mtNgayVaoLam.Text;
            ngaySinh = mtNgaySinh.Text;
            
            /**/
            string[] splitNgayVaoLam = ngayVaoLam.Split('/');
            string dayVaoLam = splitNgayVaoLam[0].Trim();
            string monthVaoLam = splitNgayVaoLam[1].Trim();
            string yearVaoLam = splitNgayVaoLam[2];

            string[] splitNgaySinh = ngaySinh.Split('/');
            string dayNgaySinh = splitNgaySinh[0].Trim();
            string monthNgaySinh = splitNgaySinh[1].Trim();
            string yearNgaySinh = splitNgaySinh[2];

            if (dayNgaySinh.Contains("0") || monthNgaySinh.Contains("0") || dayVaoLam.Contains("0") || monthNgaySinh.Contains("0"))
            {
                dayNgaySinh = dayNgaySinh.Replace("0" , string.Empty);
                monthNgaySinh = monthNgaySinh.Replace("0" , string.Empty);
                dayVaoLam = dayVaoLam.Replace("0", string.Empty);
                monthVaoLam = monthVaoLam.Replace("0", string.Empty);
            }
            /*MessageBox.Show(dayVaoLam);*/

            bool checkGioiTinh = true;
            if (rbNu.Checked)
            {
                checkGioiTinh = false;
            }

            using (SqlCommand cmd = Connection.getConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SearchNhanVien";
                    cmd.Parameters.AddWithValue("@sMaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@sTenNhanVien", tenNhanVien);
                    if(checkGioiTinh == true)
                        cmd.Parameters.AddWithValue("@bGioiTinh", "1");
                    else
                        cmd.Parameters.AddWithValue("@bGioiTinh", "0");
                    cmd.Parameters.AddWithValue("@sDiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@sDienThoai", dienThoai);
                    cmd.Parameters.AddWithValue("@dNgaySinh", dayNgaySinh);
                    cmd.Parameters.AddWithValue("@dThangSinh", monthNgaySinh);
                    cmd.Parameters.AddWithValue("@dNamSinh", yearNgaySinh);
                    cmd.Parameters.AddWithValue("@dNgayVaoLam", dayVaoLam);
                    cmd.Parameters.AddWithValue("@dThangVaoLam", monthVaoLam);
                    cmd.Parameters.AddWithValue("@dNamVaoLam", yearVaoLam);
                    cmd.Parameters.AddWithValue("@userRole", tbQuyen.Text);
                    tableNhanVien.Clear();
                    tableNhanVien.Load(cmd.ExecuteReader());
                    cmd.ExecuteNonQuery();
                    dataGridViewNhanVien.DataSource = tableNhanVien;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                    cmd.CommandText = "select * from [dbo].[tblNhanVien]";
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
                f.reportViewer1.LocalReport.ReportPath = @"D:\SOFTWARE ENGINEER\Huong_Su_Kien\BTL_HSK\BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH\rdlcNhanVien.rdlc";
                f.reportViewer1.RefreshReport();
                f.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show("Không có index" + ex.Message);
            }

       }

        private string getStr(String s1)
        {
                string sMoTa = "";
            sMoTa += s1;

            return sMoTa;
        }


        private void dataGridViewGhiChu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewGhiChu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    richTextBox1.Text += dataGridViewGhiChu.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() + "\n";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có index" + ex.Message);
            }
        }
    }
}
