using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model
{
    public class HoaDonBanHang
    {
        private string maNhanVien;
        private string maKhachHang;
        private string maHoaDon;
        private string ngayBan;

        public HoaDonBanHang(string maNhanVien, string maKhachHang, string maHoaDon, string ngayBan)
        {
            this.maNhanVien = maNhanVien;
            this.maKhachHang = maKhachHang;
            this.maHoaDon = maHoaDon;
            this.ngayBan = ngayBan;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string NgayBan { get => ngayBan; set => ngayBan = value; }
    }
}
