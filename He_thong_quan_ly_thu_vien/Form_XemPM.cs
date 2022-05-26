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
    public partial class Form_XemPM : Form
    {
        public Form_XemPM()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        BindingSource binding = new BindingSource();
        SqlCommandBuilder cmb;
        private SqlConnection cnn;
        DataSet ds;
        private void Connection()
        {
            //dgv_DocGia_Enter.Rows.Clear();
            SqlConnection Connection = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
            cmd = new SqlCommand("Select * From PhieuMuon", Connection);
            da = new SqlDataAdapter(cmd);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Phieumuon");
            dgv_XemPM_Enter.DataSource = ds;
            dgv_XemPM_Enter.DataMember = "PhieuMuon";
        }

        private void btn_XemPM_Enter_Click(object sender, EventArgs e)
        {
            Form_PhieuMuon frm_PhieuMuon = new Form_PhieuMuon();
            frm_PhieuMuon.ShowDialog();
        }

        private void btn_XemPM_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_XemPM_Load(object sender, EventArgs e)
        {
            Connection();
        }

        private void dgv_XemPM_Enter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //các thuộc tính trong ngoặc vuông có thể thay đổi tùy theo tên biến trong database.
                txt_MaPM_Watch.Text = dgv_XemPM_Enter.CurrentRow.Cells["MaPM"].Value.ToString();
                txt_TenDG_Watch.Text = dgv_XemPM_Enter.CurrentRow.Cells["TenDG"].Value.ToString();
                txt_TenSach_Watch.Text = dgv_XemPM_Enter.CurrentRow.Cells["TenSach"].Value.ToString();
                txt_NgayMuon_Watch.Text = dgv_XemPM_Enter.CurrentRow.Cells["NgayMuon"].Value.ToString();
                txt_NgayTra_Watch.Text = dgv_XemPM_Enter.CurrentRow.Cells["NgayTra"].Value.ToString();
                txt_GhiChuPM_Watch.Text = dgv_XemPM_Enter.CurrentRow.Cells["GhiChu"].Value.ToString();
            }
        }
    }
}
