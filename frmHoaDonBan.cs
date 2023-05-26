using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Validate;
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
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Util;
using System.Data.SqlClient;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    public partial class frmHoaDonBan : Form
    {
        private static string strMaFind;
        public frmHoaDonBan()
        {
            InitializeComponent();
            hideMessage();
        }

        private void hideMessage()
        {
            Validates.HideMessage(lbMaErr);
            Validates.HideMessage(lbNgayLapErr);
            Validates.HideMessage(lbMaHangErr);
            Validates.HideMessage(lbMaNhanVienErr);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            /*  Validate trước khi add vào dữ liệu
                4 paramater : info , show message , tên thông báo , độ dài )
             */
            HoaDonBanHang hd = new HoaDonBanHang(tbMaNV.Text, tbMaKH.Text, tbMaHD.Text, mtNgayBan.Text); 

            if (
                Validates.checkMessage(hd.MaHoaDon, lbMaErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(hd.MaNhanVien, lbMaNhanVienErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(hd.MaKhachHang, lbMaHangErr, Utils.MESSAGE_EMPTY)&&
                Validates.checkMessage(hd.NgayBan, lbNgayLapErr, Utils.NGAY))
            {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Utils.insertHoaDonBanHang;
                        cmd.Parameters.AddWithValue("@sMaHDban", hd.MaHoaDon);
                        cmd.Parameters.AddWithValue("@sMaNV", hd.MaNhanVien);
                        cmd.Parameters.AddWithValue("@sMaKH", hd.MaKhachHang);
                        cmd.Parameters.AddWithValue("@dNgayban", Convert.ToDateTime(hd.NgayBan));
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

        private void dataGridViewHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*  Fomatvalue : final index get value
                Value : change index get value
             */
            try
            {
                if (dataGridViewHoaDonBan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    strMaFind = dataGridViewHoaDonBan.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbMaHD.Text = dataGridViewHoaDonBan.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbMaNV.Text = dataGridViewHoaDonBan.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    tbMaKH.Text = dataGridViewHoaDonBan.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    mtNgayBan.Text = dataGridViewHoaDonBan.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có index" + ex.Message);
            }
        }

        private void dataGridViewHoaDonBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HoaDonBanHang hd = new HoaDonBanHang(tbMaNV.Text, tbMaKH.Text, tbMaHD.Text, mtNgayBan.Text);

            if (
                Validates.checkMessage(hd.MaHoaDon, lbMaErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(hd.MaNhanVien, lbMaNhanVienErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(hd.MaKhachHang, lbMaHangErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(hd.NgayBan, lbNgayLapErr, Utils.NGAY))
            {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Utils.UpdateHoaDonBanHang;
                        cmd.Parameters.AddWithValue("@sMaHDban", strMaFind);
                        cmd.Parameters.AddWithValue("@sMaNV", hd.MaNhanVien);
                        cmd.Parameters.AddWithValue("@sMaKH", hd.MaKhachHang);
                        cmd.Parameters.AddWithValue("@dNgayban", Convert.ToDateTime(hd.NgayBan));
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
            Utils.getData("Select * from [dbo].[tblHoaDonBanHang]", dataGridViewHoaDonBan);
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            Utils.getData("Select * from [dbo].[tblHoaDonBanHang]", dataGridViewHoaDonBan);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = Connection.getConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = Utils.DeleteHoaDonBanHang;
                    cmd.Parameters.AddWithValue("@MaHD", strMaFind);
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
