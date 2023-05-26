using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Model
{
    public class Connection
    {

        static string strConnection = "Data Source=.;Initial Catalog=QuanLyBanHangCongTyKinhDoangMayTinh;Integrated Security=True";

        public Connection() { }
        public static SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection(strConnection);
            try
            {
                connection.Open();
            }catch(SqlException e) {
                MessageBox.Show($"===> SqlConnection {e.Message}");
            }
            return connection;
        }


    }
}
