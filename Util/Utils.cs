using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Util
{
    class Utils
    {
        public static string MESSAGE_EMPTY = "Không để trống";
        public static string MESSAGE_LENGTH = "Không để trống số điện thoại, số điện thoại có 10 chữ số";
        public static string NGAY = "không để trống , chưa nhập đúng";
        public static int LENGTH_PHONE = 10;

        //Proce
        /*Ten proc */
        //Nhân viên
        public static string insertNhanVien = "InsertNhanVien";
        public static string UpdateNhanVien = "UpdateNhanVien";
        public static string DeleteNhanVien = "DeleteNhanVien";
        public static string ReportNhanVien = "ReportNhanVien";
        public static string SearchNhanVien = "SearchNhanVien";
        public static string getAllNhanVien = "getAllNhanVien";

        //Khach hang
        public static string insertKhachHang = "insertKhachHang";
        public static string UpdateKhachHang = "UpdateKhachHang";
        public static string DeleteKhachHang = "DeleteKhachHang";
        public static string ReporKhachHang = "ReporKhachHang";
        public static string SearchKhachHang = "SearchKhachHang";
        public static string getAllKhachHang = "getAllKhachHang";

        //Nhóm hàng
        public static string insertNhomHang = "insertNhomHang";
        public static string UpdateNhomHang = "UpdateNhomHang";
        public static string DeleteNhomHang = "DeleteNhomHang";
        public static string ReportNhomHang = "ReportNhomHang";
        public static string SearchNhomHang = "SearchNhomHang";
        public static string getAlNhomHang = "getAlNhomHang";
        //Nhà cung cấp
        public static string insertNhaCC = "insertNhaCC";
        public static string UpdateNhaCC = "UpdateNhaCC";
        public static string DeleteNhaCC = "DeleteNhaCC";
        public static string ReportNhaCC = "ReportNhaCC";
        public static string SearchNhaCC = "SearchNhaCC";
        public static string getAllNhaCC = "getAllNhaCC";
        //Hoa đơn bán hàng
        public static string insertHoaDonBanHang = "insertHoaDonBanHang";
        public static string UpdateHoaDonBanHang = "UpdateHoaDonBanHang";
        public static string DeleteHoaDonBanHang = "DeleteHoaDonBanHang";
        public static string ReportHoaDonBanHang = "ReportHoaDonBanHang";
        public static string SearchHoaDonBanHang = "SearchHoaDonBanHang";
        public static string getAllHoaDonBanHang = "getAllHoaDonBanHang";
        //Chi tiết Hoa đơn bán hàng
        public static string insertChiTietHoaDonBanHang = "insertChiTietHoaDonBanHang";
        public static string UpdateChiTietHoaDonBanHang = "UpdateChiTietHoaDonBanHang";
        public static string DeleteChiTietHoaDonBanHang = "DeleteChiTietHoaDonBanHang";
        public static string ReportChiTietHoaDonBanHang = "ReportChiTietHoaDonBanHang";
        public static string SearchChiTietHoaDonBanHang = "SearchChiTietHoaDonBanHang";
        public static string getAllChiTietHoaDonBanHang = "getAllChiTietHoaDonBanHang";
        //Hoa don ban nhap hang
        public static string insertHoaDonNhapHang = "insertHoaDonNhapHang";
        public static string UpdateHoaDonNhapHang = "UpdateHoaDonNhapHang";
        public static string DeleteHoaDonNhapHang = "DeleteHoaDonNhapHang";
        public static string ReportHoaDonNhapHang = "ReportHoaDonNhapHang";
        public static string SearchHoaDonNhapHang = "SearchHoaDonNhapHang";
        public static string getAllHoaDonNhapHang = "getAllHoaDonNhapHang";

        /*acount*/
        public static string updatePassword = "updatePassword";
        /*Path connect data base*/
        public static string strConnect = "Data Source=.;Initial Catalog=dbQuanLyBanHang_TBMayTinh;Integrated Security=True";
        public static string strRegex = "^(0?[1-9]|[12][0-9]|3[01])[\\/\\-](0?[1-9]|1[012])[\\/\\-]\\d{4}$";
        public static void getData(string query , DataGridView dataGridView)
        {
            try {
                using (SqlConnection connect = Connection.getConnection())
                {
                    SqlCommand cm = new SqlCommand(query, connect);
                    cm.CommandType = CommandType.Text;
                    SqlDataAdapter adp = new SqlDataAdapter(cm);
                    DataTable tbl = new DataTable();
                    tbl.Clear();
                    adp.Fill(tbl);
                    dataGridView.DataSource = tbl;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
