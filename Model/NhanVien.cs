using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model
{
    public class NhanVien
    {
        private string maNhanVien;
        private string tenNhanVien;
        private string diaChi;
        private string dienThoai;
        private string ngaySinh;
        private string ngayVaolam;

        public NhanVien() { }
        public NhanVien(string maNhanVien, string tenNhanVien, string diaChi, string dienThoai, string ngaySinh, string ngayVaolam)
        {
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
            this.NgaySinh = ngaySinh;
            this.NgayVaolam = ngayVaolam;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string NgayVaolam { get => ngayVaolam; set => ngayVaolam = value; }
    }
}
