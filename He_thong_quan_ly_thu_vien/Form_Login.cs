using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace He_thong_quan_ly_thu_vien
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Access_Click(object sender, EventArgs e)
        { 

            try
            {
                string tk = txt_Login_Account.Text;
                string mk = txt_Login_Password.Text;
                string sql = "select * from Account where Username = '" + tk + "'and Password ='" + mk + "'";
                //SqlConnection cnn = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
                //cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, ChuoiKetNoi.Connection);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Form_Menu frm_Menu = new Form_Menu();
                    this.Hide();
                    frm_Menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void btn_Login_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
