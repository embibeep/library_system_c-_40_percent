using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_thong_quan_ly_thu_vien
{
    class ChuoiKetNoi
    {
        static public SqlConnection Connection;
        //Hàm lấy tên server, database từ file txt trong Debug
        public static string LayChuoi()
        {
            string tentaptin = "Chuoi.txt";
            string s;
            StreamReader rd = new StreamReader(tentaptin);
            s = rd.ReadToEnd();
            rd.Close();
            return s;
        }
        //Hàm toàn cục kết nối server, nếu không sử dụng được file txt thì hủy hàm LayChuoi và thay ChuoiKetNoi.LayChuoi() bằng cách điền tên server và database trực tiếp vào.
        public static SqlConnection Connect()
        {
            try
            {
                Connection = new SqlConnection(ChuoiKetNoi.LayChuoi());
                Connection.Open();
                return Connection;
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Lỗi kết nối!");
                return null;
            }
        }        
    }
}
