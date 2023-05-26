using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model
{
     public class NhomHang
    {
        private string maNhom;
        private string tenNhom;

        public NhomHang(string maNhom, string tenNhom)
        {
            this.MaNhom = maNhom;
            this.TenNhom = tenNhom;
        }

        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }
    }
}
