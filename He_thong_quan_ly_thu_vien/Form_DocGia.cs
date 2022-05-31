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
    public partial class Form_DocGia : Form
    {
        public Form_DocGia()
        {
            InitializeComponent();
        }

        private void Form_DocGia_Load(object sender, EventArgs e)
        {
            Connection();
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
            cmd = new SqlCommand("Select * From DocGia", ChuoiKetNoi.Connect());
            da = new SqlDataAdapter(cmd);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Docgia");
            dgv_DocGia_Enter.DataSource = ds;
            dgv_DocGia_Enter.DataMember = "DocGia";
        }

        private void dgv_DocGia_Enter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //các thuộc tính trong ngoặc vuông có thể thay đổi tùy theo tên biến trong database.
                txt_MaDG_Enter.Text = dgv_DocGia_Enter.CurrentRow.Cells["MaDG"].Value.ToString();
                txt_TenDG_Enter.Text = dgv_DocGia_Enter.CurrentRow.Cells["TenDG"].Value.ToString();
                txt_EmailDG_Enter.Text = dgv_DocGia_Enter.CurrentRow.Cells["EmailDG"].Value.ToString();
                txt_DiaChiDG_Enter.Text = dgv_DocGia_Enter.CurrentRow.Cells["DiaChiDG"].Value.ToString();
                txt_SdtDG_Enter.Text = dgv_DocGia_Enter.CurrentRow.Cells["SdtDG"].Value.ToString();
                txt_NgayLapDG_Enter.Text = dgv_DocGia_Enter.CurrentRow.Cells["NgayLap"].Value.ToString();
            }
        }

        private void btn_DocGia_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection Connection1 = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
                //Connection1.Open();
                string Scon;
                Scon = "insert into DocGia (MaDG,TenDG,EmailDG,DiaChiDG,SdtDG,NgayLap) values(@MaDG,@TenDG,@EmailDG,@DiaChiDG,@SdtDG,@NgayLap)";
                SqlCommand cmd1 = new SqlCommand(Scon, ChuoiKetNoi.Connect());
                cmd1.Parameters.Add("@MaDG", txt_MaDG_Enter.Text);
                cmd1.Parameters.Add("@TenDG", txt_TenDG_Enter.Text);
                cmd1.Parameters.Add("@EmailDG", txt_EmailDG_Enter.Text);
                cmd1.Parameters.Add("@DiaChiDG", txt_DiaChiDG_Enter.Text);
                cmd1.Parameters.Add("@SdtDG", txt_SdtDG_Enter.Text);
                cmd1.Parameters.Add("@NgayLap", txt_NgayLapDG_Enter.Text);
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

        private void btn_DocGia_Update_Click(object sender, EventArgs e)
        {

            DataTable tbl = new DataTable();
            tbl = ds.Tables["Docgia"].GetChanges();
            if (tbl == null)
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            else
            {
                da.Update(ds, "DocGia");
                MessageBox.Show("Có " + tbl.Rows.Count + " danh sách đã được cập nhật!");
            }
        }

        private void btn_DocGia_Delete_Click(object sender, EventArgs e)
        {
            int hientai = this.BindingContext[ds, "Docgia"].Position;
            this.BindingContext[ds, "Docgia"].RemoveAt(hientai);
        }

        private void btn_DocGia_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
