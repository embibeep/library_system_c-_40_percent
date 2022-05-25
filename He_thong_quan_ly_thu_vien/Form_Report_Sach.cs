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

namespace He_thong_quan_ly_thu_vien
{
    public partial class Form_Report_Sach : Form
    {
        public Form_Report_Sach()
        {
            InitializeComponent();
        }


        DataTable dt;
        SqlCommand cmd;
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da;
        private void KetNoi()
        {
            string connectionstring;
            //SqlConnection cnn = new SqlConnection();
            try
            {
                connectionstring = "server = ADMIN\\SQLEXPRESS";
                connectionstring += ";database='19CT3_42_D10'";
                connectionstring += ";integrated security=true";
                cnn.ConnectionString = connectionstring;
                cnn.Open();
                // MessageBox.Show("ket noi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối!" + ex.Message);
            }
        }
        private void TaoReport_Sach()
        {
            cmd = new SqlCommand("sp_rptSach", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = MaSach;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rpt_Sach rpt = new rpt_Sach();
            rpt.SetDataSource(dt);
            crystalReportViewer_Sach.ReportSource = rpt;
        }

        private void Form_Report_Sach_Load(object sender, EventArgs e)
        {
            string St;
            KetNoi();
            TaoReport_Sach();
        }

    }
}
