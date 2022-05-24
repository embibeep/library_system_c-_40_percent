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
            String connectionstring;
            SqlConnection cnn;
            connectionstring = "Server=.;Database=19CT3_42_D10;Uid=trongngoc;PWD=06122001";
            cnn = new SqlConnection(connectionstring);
            {
                try
                {
                    connectionstring = "Server=.";
                    connectionstring += ";database=19CT3_42_D10";
                    connectionstring += ";uid=" + txt_Login_Account.Text;
                    connectionstring += ";pwd=" + txt_Login_Password.Text;
                    cnn.ConnectionString = connectionstring;

                    cnn.Open();
                    MessageBox.Show("Kết nối thành công");
                    cnn.Close();
                    Form_Menu frm_Menu = new Form_Menu();
                    frm_Menu.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối\n" + ex.Message);
                }
            }

        }

        private void btn_Login_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
