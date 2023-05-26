using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model
{
    public class HoaDonNhapHang
    {
        private string maHoaDon;
        private string maHang;
        private string maNV;
        private string tenNhaCC;
        private string ngayLap;
        private string soLuong;
        private string giaNhap;
        private string lienHe;

        public HoaDonNhapHang(string maHoaDon, string maHang, string maNV, string tenNhaCC, string ngayLap, string soLuong, string giaNhap, string lienHe)
        {
            this.MaHoaDon = maHoaDon;
            this.MaHang = maHang;
            this.MaNV = maNV;
            this.TenNhaCC = tenNhaCC;
            this.NgayLap = ngayLap;
            this.SoLuong = soLuong;
            this.GiaNhap = giaNhap;
            this.LienHe = lienHe;
        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaHang { get => maHang; set => maHang = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNhaCC { get => tenNhaCC; set => tenNhaCC = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string GiaNhap { get => giaNhap; set => giaNhap = value; }
        public string LienHe { get => lienHe; set => lienHe = value; }
    }
}
