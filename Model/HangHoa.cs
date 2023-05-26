using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model
{
    public class HangHoa
    {
        private string maHang;
        private string tenHang;
        private string mauSac;
        private string kichThuoc;
        private string dacTinhKyThuat;
        private string maNhom;


        public HangHoa(string maHang, string tenHang, string mauSac, string kichThuoc, string dacTinhKyThuat, string maNhom)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.MauSac = mauSac;
            this.KichThuoc = kichThuoc;
            this.DacTinhKyThuat = dacTinhKyThuat;
            this.MaNhom = maNhom;
        }

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }
        public string KichThuoc { get => kichThuoc; set => kichThuoc = value; }
        public string DacTinhKyThuat { get => dacTinhKyThuat; set => dacTinhKyThuat = value; }
        public string MaNhom { get => maNhom; set => maNhom = value; }
    }
}
