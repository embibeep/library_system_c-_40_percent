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

namespace He_thong_quan_ly_thu_vien
{
    public partial class Form_Report : Form
    {
        public Form_Report()
        {
            InitializeComponent();
        }

        DataTable dt;
        SqlCommand cmd;
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da;
        
        private void Connection()
        {
            string connectionstring;

            try
            {
                connectionstring = "server=ADMIN\\SQLEXPRESS";
                connectionstring += ";database='19CT3_42_D10'";
                connectionstring += ";integrated security=true";
                cnn.ConnectionString = connectionstring;

                cnn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối! \n" + ex.Message);
            }
        }

        private void Tao_Report(int MaPM)
        {
            try
            {
                cmd = new SqlCommand("sp_rptPM", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPM", SqlDbType.Int).Value = MaPM;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rpt_PM rpt = new rpt_PM();
                rpt.SetDataSource(dt);
                rptReportViewer.ReportSource = rpt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã Phiếu Mượn không hợp lệ!");
            }
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {
            Connection();
            Tao_Report(Global.Ma);
        }
    }
}
