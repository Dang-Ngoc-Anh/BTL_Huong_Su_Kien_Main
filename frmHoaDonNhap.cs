using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Util;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Validate;
using System.Data.SqlClient;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    public partial class frmHoaDonNhap : Form
    {
        private string strMaFind;

        public frmHoaDonNhap()
        {
            InitializeComponent();
            hideMessage();
        }

        private void hideMessage()
        {
            Validates.HideMessage(lbMaErr);
            Validates.HideMessage(lbTenNCCErr);
            Validates.HideMessage(lbMaNhanVienErr);
            Validates.HideMessage(lbNgayLapErr);
            Validates.HideMessage(lbSoLuongErr);
            Validates.HideMessage(lbGiaBanErr);
            Validates.HideMessage(lbLienHeErr);
            Validates.HideMessage(lbMahangErr);
        }
        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*  Validate trước khi add vào dữ liệu
               4 paramater : info , show message , tên thông báo , độ dài )
            */
            HoaDonNhapHang hdNhap = new HoaDonNhapHang(tbMaHD.Text, tbMahang.Text, tbMaNV.Text, tbTenNhaCC.Text, mtNgayNhap.Text, tbSoLuong.Text, tbGiaBan.Text, tbLienHe.Text);

            if (
                Validates.checkMessage(hdNhap.MaHoaDon, lbMaErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.MaHang, lbMahangErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.MaNV, lbMaNhanVienErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.TenNhaCC, lbTenNCCErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.NgayLap, lbNgayLapErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.SoLuong, lbSoLuongErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.GiaNhap, lbGiaBanErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.LienHe, lbLienHeErr, Utils.MESSAGE_LENGTH, Utils.LENGTH_PHONE)
               )
            {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Utils.insertHoaDonNhapHang;
                        cmd.Parameters.AddWithValue("@sMaHDnhap", hdNhap.MaHoaDon);
                        cmd.Parameters.AddWithValue("@dNgaynhap", Convert.ToDateTime(hdNhap.NgayLap));
                        cmd.Parameters.AddWithValue("@sMaNV", hdNhap.MaNV);
                        cmd.Parameters.AddWithValue("@sMaNCC", hdNhap.TenNhaCC);
                        cmd.Parameters.AddWithValue("@sLienHe", hdNhap.LienHe);
                        cmd.Parameters.AddWithValue("@sMahang", hdNhap.MaHang);
                        cmd.Parameters.AddWithValue("@fGiaNhap", float.Parse(hdNhap.GiaNhap));
                        cmd.Parameters.AddWithValue("@iSoluong", int.Parse(hdNhap.SoLuong));
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
            Utils.getData("select * from [dbo].[tblHoaDonNhapHang]", dataGridViewHoaDonNhap);
        }

        private void dataGridViewHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewHoaDonNhap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    strMaFind = dataGridViewHoaDonNhap.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbMaHD.Text = dataGridViewHoaDonNhap.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    mtNgayNhap.Text = dataGridViewHoaDonNhap.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    tbMaNV.Text = dataGridViewHoaDonNhap.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    tbTenNhaCC.Text = dataGridViewHoaDonNhap.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    tbLienHe.Text = dataGridViewHoaDonNhap.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    tbMahang.Text = dataGridViewHoaDonNhap.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    tbGiaBan.Text = dataGridViewHoaDonNhap.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    tbSoLuong.Text = dataGridViewHoaDonNhap.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có index" + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HoaDonNhapHang hdNhap = new HoaDonNhapHang(tbMaHD.Text, tbMahang.Text, tbMaNV.Text, tbTenNhaCC.Text, mtNgayNhap.Text, tbSoLuong.Text, tbGiaBan.Text, tbLienHe.Text);

            if (
                Validates.checkMessage(hdNhap.MaHoaDon, lbMaErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.MaHang, lbMahangErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.MaNV, lbMaNhanVienErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.TenNhaCC, lbTenNCCErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.NgayLap, lbNgayLapErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.SoLuong, lbSoLuongErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.GiaNhap, lbGiaBanErr, Utils.MESSAGE_EMPTY) && Validates.checkMessage(hdNhap.LienHe, lbLienHeErr, Utils.MESSAGE_LENGTH, Utils.LENGTH_PHONE)
               )
            {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Utils.UpdateHoaDonNhapHang;
                        cmd.Parameters.AddWithValue("@sMaHDnhap", hdNhap.MaHoaDon);
                        cmd.Parameters.AddWithValue("@dNgaynhap", Convert.ToDateTime(hdNhap.NgayLap));
                        cmd.Parameters.AddWithValue("@sMaNV", hdNhap.MaNV);
                        cmd.Parameters.AddWithValue("@sMaNCC", hdNhap.TenNhaCC);
                        cmd.Parameters.AddWithValue("@sLienHe", hdNhap.LienHe);
                        cmd.Parameters.AddWithValue("@sMahang", hdNhap.MaHang);
                        cmd.Parameters.AddWithValue("@fGiaNhap", float.Parse(hdNhap.GiaNhap));
                        cmd.Parameters.AddWithValue("@iSoluong", int.Parse(hdNhap.SoLuong));
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
                    cmd.CommandText = Utils.DeleteHoaDonNhapHang;
                    cmd.Parameters.AddWithValue("@MaHDNhap", strMaFind);
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
}
