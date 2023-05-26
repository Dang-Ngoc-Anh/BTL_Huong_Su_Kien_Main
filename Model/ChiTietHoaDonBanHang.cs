using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model
{
    public class ChiTietHoaDonBanHang
    {
        private int id;
        private string maHoaDonBan;
        private string mahang;
        private string soLuong;
        private string giaBan;
        private string baoHanh;

        public ChiTietHoaDonBanHang(
            int id,
            string maHoaDonBan, string mahang, string soLuong, string giaBan, string baoHanh)
        {
            this.Id = id;
            this.maHoaDonBan = maHoaDonBan;
            this.mahang = mahang;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
            this.baoHanh = baoHanh;
        }


        public ChiTietHoaDonBanHang(
           string maHoaDonBan, string mahang, string soLuong, string giaBan, string baoHanh)
        {
            this.maHoaDonBan = maHoaDonBan;
            this.mahang = mahang;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
            this.baoHanh = baoHanh;
        }
        public string MaHoaDonBan { get => maHoaDonBan; set => maHoaDonBan = value; }
        public string Mahang { get => mahang; set => mahang = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string GiaBan { get => giaBan; set => giaBan = value; }
        public string BaoHanh { get => baoHanh; set => baoHanh = value; }
        public int Id { get => id; set => id = value; }
    }
}
