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

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            Utils.getData("SELECT TOP (1000) [sMahang] ,[sTenhang],[sMausac],[fKichthuoc],[sDactinhkythuat] FROM.[dbo].[tblHangHoa]", dataGridViewKhohang);
        }
    }
}
