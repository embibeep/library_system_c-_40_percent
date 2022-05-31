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
    public partial class Form_PhieuMuon : Form
    {
        public Form_PhieuMuon()
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
            //SqlConnection Connection = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
            cmd = new SqlCommand("Select * From PhieuMuon", ChuoiKetNoi.Connect());
            da = new SqlDataAdapter(cmd);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Phieumuon");
            dgv_PM_Enter.DataSource = ds;
            dgv_PM_Enter.DataMember = "PhieuMuon";
        }

        private void btn_PM_Watch_Click(object sender, EventArgs e)
        {
            Form_XemPM frm_XemPM = new Form_XemPM();
            frm_XemPM.ShowDialog();
        }

        private void btn_Exit_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_PM_Enter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //các thuộc tính trong ngoặc vuông có thể thay đổi tùy theo tên biến trong database.
                txt_MaPM_Enter.Text = dgv_PM_Enter.CurrentRow.Cells["MaPM"].Value.ToString();
                txt_TenDG_Enter.Text = dgv_PM_Enter.CurrentRow.Cells["MaDG"].Value.ToString();
                txt_TenSach_Enter.Text = dgv_PM_Enter.CurrentRow.Cells["IDSach"].Value.ToString();
                txt_NgayMuon_Enter.Text = dgv_PM_Enter.CurrentRow.Cells["NgayMuon"].Value.ToString();
                txt_NgayTra_Enter.Text = dgv_PM_Enter.CurrentRow.Cells["NgayTra"].Value.ToString();
                txt_GhiChuPM_Enter.Text = dgv_PM_Enter.CurrentRow.Cells["GhiChu"].Value.ToString();
            }
        }

        private void Form_PhieuMuon_Load(object sender, EventArgs e)
        {
            Connection();
        }

        private void btn_PM_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection Connection1 = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
                //Connection1.Open();
                string Scon;
                Scon = "insert into PhieuMuon (MaPM,MaDG,IDSach,NgayMuon,NgayTra,GhiChu) values(@MaPM,@MaDG,@IDSach,@NgayMuon,@NgayTra,@GhiChu)";
                SqlCommand cmd1 = new SqlCommand(Scon, ChuoiKetNoi.Connect());
                cmd1.Parameters.Add("@MaPM", txt_MaPM_Enter.Text);
                cmd1.Parameters.Add("@MaDG", txt_TenDG_Enter.Text);
                cmd1.Parameters.Add("@IDSach", txt_TenSach_Enter.Text);
                cmd1.Parameters.Add("@NgayMuon", txt_NgayMuon_Enter.Text);
                cmd1.Parameters.Add("@NgayTra", txt_NgayTra_Enter.Text);
                cmd1.Parameters.Add("@GhiChu", txt_GhiChuPM_Enter.Text);
                int count = cmd1.ExecuteNonQuery();
                {
                    MessageBox.Show("Thêm thành công!");
                    Connection();
                }
                //Connection1.Close();
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Chưa thêm thành công!");
            }
        }

        private void btn_PM_Update_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = ds.Tables["Phieumuon"].GetChanges();
            if (tbl == null)
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            else
            {
                da.Update(ds, "PhieuMuon");
                MessageBox.Show("Có " + tbl.Rows.Count + " danh sách đã được cập nhật!");
            }
        }

        private void btn_PM_Delete_Click(object sender, EventArgs e)
        {
            int hientai = this.BindingContext[ds, "Phieumuon"].Position;
            this.BindingContext[ds, "Phieumuon"].RemoveAt(hientai);
        }

        private void btn_PM_Report_Click(object sender, EventArgs e)
        {
            Form_ChonReport frm_ChonReport = new Form_ChonReport();
            frm_ChonReport.ShowDialog();
        }
    }
}
