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

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    public partial class frmChiTietHoaDonBan : Form
    {
        private string strMaFind;

        public frmChiTietHoaDonBan()
        {
            InitializeComponent();
            hideMessage();
        }

        private void hideMessage()
        {
            Validates.HideMessage(lbBaoHanhErr);
            Validates.HideMessage(lbMaHoaDonErr);
            Validates.HideMessage(lbTenMatHangErr);
            Validates.HideMessage(lbSoLuongErr);
            Validates.HideMessage(lbGiaBanErr);
            Validates.HideMessage(lbIdErr);
        }
        private void frmChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            tbId.Enabled = false;
            Utils.getData("select * from tblCTHoaDonBanHang", dataGridVievHoaDonBan);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ChiTietHoaDonBanHang cthd = new ChiTietHoaDonBanHang(tbMaHoaDon.Text , tbMaHang.Text , tbSoLuong.Text, tbGiaBan.Text, tbBaoHanh.Text);

            if (
                Validates.checkMessage(cthd.MaHoaDonBan, lbMaHoaDonErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(cthd.Mahang, lbTenMatHangErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(cthd.SoLuong, lbSoLuongErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(cthd.GiaBan, lbGiaBanErr, Utils.MESSAGE_EMPTY)&&
                Validates.checkMessage(cthd.BaoHanh, lbBaoHanhErr, Utils.MESSAGE_EMPTY)
                )
            {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Utils.insertChiTietHoaDonBanHang;
                        cmd.Parameters.AddWithValue("@sMaHDban", cthd.MaHoaDonBan);
                        cmd.Parameters.AddWithValue("@sMahang", cthd.Mahang);
                        cmd.Parameters.AddWithValue("@fSoluong", float.Parse(cthd.SoLuong));
                        cmd.Parameters.AddWithValue("@fGiaban", float.Parse(cthd.GiaBan));
                        cmd.Parameters.AddWithValue("@fBaohanh", float.Parse(cthd.BaoHanh));
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
            Utils.getData("select * from tblCTHoaDonBanHang", dataGridVievHoaDonBan);
        }

        private void dataGridVievHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridVievHoaDonBan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    strMaFind = dataGridVievHoaDonBan.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbId.Text = dataGridVievHoaDonBan.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbMaHoaDon.Text = dataGridVievHoaDonBan.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    tbMaHang.Text = dataGridVievHoaDonBan.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    tbSoLuong.Text = dataGridVievHoaDonBan.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    tbGiaBan.Text = dataGridVievHoaDonBan.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    tbBaoHanh.Text = dataGridVievHoaDonBan.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có index" + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonBanHang cthd = new ChiTietHoaDonBanHang(tbMaHoaDon.Text, tbMaHang.Text, tbSoLuong.Text, tbGiaBan.Text, tbBaoHanh.Text);

            if (
                Validates.checkMessage(cthd.MaHoaDonBan, lbMaHoaDonErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(cthd.Mahang, lbTenMatHangErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(cthd.SoLuong, lbSoLuongErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(cthd.GiaBan, lbGiaBanErr, Utils.MESSAGE_EMPTY) &&
                Validates.checkMessage(cthd.BaoHanh, lbBaoHanhErr, Utils.MESSAGE_EMPTY)
                )
            {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Utils.UpdateChiTietHoaDonBanHang;
                        cmd.Parameters.AddWithValue("@id", strMaFind);
                        cmd.Parameters.AddWithValue("@sMaHDban", cthd.MaHoaDonBan);
                        cmd.Parameters.AddWithValue("@sMahang", cthd.Mahang);
                        cmd.Parameters.AddWithValue("@fSoluong", float.Parse(cthd.SoLuong));
                        cmd.Parameters.AddWithValue("@fGiaban", float.Parse(cthd.GiaBan));
                        cmd.Parameters.AddWithValue("@fBaohanh", float.Parse(cthd.BaoHanh));
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
                    cmd.CommandText = Utils.DeleteChiTietHoaDonBanHang;
                    cmd.Parameters.AddWithValue("@id", strMaFind);
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
