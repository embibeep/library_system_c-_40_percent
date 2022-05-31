using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_thong_quan_ly_thu_vien
{
    class ChuoiKetNoi
    {
        static public SqlConnection Connection;
        public static SqlConnection Connect()
        {
            try
            {
                Connection = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
                Connection.Open();
                return Connection;
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Chưa thêm thành công!");
                return null;
            }
        }
    }
}
