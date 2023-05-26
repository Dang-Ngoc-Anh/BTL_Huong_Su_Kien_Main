using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    public partial class frmManagerment : Form
    {
        Users user = new Users();
        NhanVien nhanVien = new NhanVien();
        FormCollection fc = Application.OpenForms;

        public frmManagerment()
        {
            InitializeComponent();
        }

        public frmManagerment(Users user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lbManagerment.Text ="Quản lý nhân viên";
            frmNhanVien frmNhanVien = new frmNhanVien();
            loadForm(frmNhanVien);
        }


        public void loadForm(Form objForm)
        {
            objForm.TopLevel = false;
            panelControl.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //panelControl.Tag = objForm;
            objForm.AutoSize = true;
            objForm.BringToFront();
            objForm.Show();
        }

        private void hoaDonBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbManagerment.Text = "Quản lý hóa đơn bán hàng";
            
            loadForm(new frmHoaDonBan());
        }

        private void hoaDonNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbManagerment.Text = "Quản lý nhập hàng";
            loadForm(new frmHoaDonNhap());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbManagerment.Text ="Quản lý khách hàng";
            loadForm(new frmKhachHang());
        }

        private void chiTiếtHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbManagerment.Text = "Quản lý chi tiết hóa đơn bán hàng";
            loadForm(new frmChiTietHoaDonBan());
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbManagerment.Text = "Quản lý kho hàng";
            loadForm(new frmKho());
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            
        }

        private void frmManagerment_Load(object sender, EventArgs e)
        {
            lbName.Text = user.UserName;
        }

        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien frmThongTinNhanVien = new frmThongTinNhanVien(user);
            loadForm(frmThongTinNhanVien);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
