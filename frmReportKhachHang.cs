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
    public partial class frmReportKhachHang : Form
    {
        public frmReportKhachHang()
        {
            InitializeComponent();
        }

        private void frmReportKhachHang_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void DataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
