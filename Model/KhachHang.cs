using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model
{
    public class KhachHang
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string diaChi;
        private string dienThoai;

        public KhachHang(string maKhachHang, string tenKhachHang, string diaChi, string dienThoai)
        {
            this.maKhachHang = maKhachHang;
            this.tenKhachHang = tenKhachHang;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
        }

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
    }
}
