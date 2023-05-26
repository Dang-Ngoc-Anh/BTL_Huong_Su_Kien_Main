using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model;
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Util;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    public partial class frmThongTinNhanVien : Form
    {
        Users user = new Users(); 
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }

        public frmThongTinNhanVien(Users user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            string query = $"select * from tblAcount acc inner join tblNhanVien nv on acc.id = nv.sMaNV " +
                        $"where acc.userName = N'{user.UserName}' and acc.userPassword = N'{user.UserPassword}'";
            try {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tbMaNhanVien.Text = (string)reader["sMaNV"];
                        tbTenNhanVien.Text = (string)reader["sTenNV"];
                        tbDiaChi.Text = (string)reader["sDiachi"];
                        tbDienThoai.Text = (string)reader["sDienthoai"];
                        if ((bool)reader["bGioiTinh"].ToString().Equals("True"))
                        {
                            rbNam.Checked = true;
                        }
                        else
                            rbNu.Checked = true;
                        tbQuyen.Text = reader["userRole"].ToString();
                        mtNgaySinh.Text = reader["dNgaysinh"].ToString();
                        mtNgayVaoLam.Text =(string)reader["dNgayvaolam"].ToString();
                        tbMatKhauCu.Text = (string)(reader["userPassword"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            try {
                using (SqlCommand cmd = Connection.getConnection().CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = Utils.updatePassword;
                    cmd.Parameters.AddWithValue("@id", tbMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@userPassword", tbMatKhauCu.Text);
                    if (tbMatKhauMoi.Text.Equals(tbXacNhanMatKhau.Text))
                    {
                        cmd.Parameters.AddWithValue("@userNewPassword", tbMatKhauMoi.Text);
                    }
                    else
                    {
                        MessageBox.Show("Nhập chưa đúng mật khẩu mới");
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đổi pass thành công");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
