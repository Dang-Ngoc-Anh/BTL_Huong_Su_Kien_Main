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
using BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Validate;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            tbUser.Text = "NguyênNgọcDũng@gmail.com";
            tbPassword.Text = "1";
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            kiemTra();
            try
            {
                if (IsValidEmail(tbUser.Text))
                {
                    string query = $"select * from tblAcount acc inner join tblNhanVien nv on acc.id = nv.sMaNV " +
                        $"where acc.userName = N'{tbUser.Text}' and acc.userPassword = N'{tbPassword.Text}'";
                    using (SqlConnection cnn = Connection.getConnection())
                    {
                        using (SqlDataAdapter adp = new SqlDataAdapter(query, cnn))
                        {
                            DataTable tblAcount = new DataTable();
                            adp.Fill(tblAcount);
                            if (tblAcount.Rows.Count > 0)
                            {
                                /*MessageBox.Show(tblAcount.Columns[0].ColumnName);
                                MessageBox.Show(tblAcount.Columns[1].ColumnName);
                                MessageBox.Show(tblAcount.Columns[2].ColumnName);
                                MessageBox.Show(tblAcount.Columns[3].ColumnName);
                                MessageBox.Show(tblAcount.Columns[4].ColumnName);
                                MessageBox.Show(tblAcount.Columns[5].ColumnName);
                                MessageBox.Show(tblAcount.Columns[6].ColumnName);
                                MessageBox.Show(tblAcount.Columns[7].ColumnName);
                                MessageBox.Show(tblAcount.Columns[8].ColumnName);
                                MessageBox.Show(tblAcount.Columns[9].ColumnName*/
                                tbRole.Text = tblAcount.Rows[0].Field<string>("userRole");
                                string id = tblAcount.Rows[0].Field<string>("id");
                                Users user = new Users(id , tbUser.Text , tbPassword.Text , tbRole.Text);
                                frmManagerment frm = new frmManagerment(user);
                                this.Hide();
                                frm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Đăng nhập thất bại");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Email chưa fomat");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                

        private void kiemTra()
        {
            if (!Validates.checkEmpty(tbUser.Text))
            {
                label3.Visible = true;
                tbUser.Focus();
            }
            else if (!Validates.checkEmpty(tbPassword.Text))
            {
                label4.Visible = true;
                label3.Visible = false;
                tbPassword.Focus();
            }
            else
            {
                label4.Visible = false;
                label3.Visible = false;
            }
        }
    }
}
