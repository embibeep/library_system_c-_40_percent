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
        private void Connection()
        {
            SqlConnection Connection = new SqlConnection("server=.;database=19CT3_42_D10;integrated security=true");
            cmd = new SqlCommand("Select * From DocGia", Connection);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            binding.DataSource = dt;
            dgv_DocGia_Enter.DataSource = binding;
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
                SqlConnection Connection = new SqlConnection("server=.;database=19CT3_42_D10;integrated security=true");
                string Scon;
                Connection.Open();
                Scon = "insert into DocGia values(@MaDG.@TenDG,@EmailDG,@DiaChiDG,@SdtDG,@NgayLap)";
                SqlCommand cmd1 = new SqlCommand(Scon, Connection);
                cmd.Parameters.Add("@MaDG", SqlDbType.Int).Value = int.Parse(txt_MaDG_Enter.Text);
                cmd.Parameters.Add("@TenDG", SqlDbType.Int).Value = int.Parse(txt_TenDG_Enter.Text);
                cmd.Parameters.Add("@EmailDG", SqlDbType.Int).Value = int.Parse(txt_EmailDG_Enter.Text);
                cmd.Parameters.Add("@DiaChiDG", SqlDbType.Float).Value = float.Parse(txt_DiaChiDG_Enter.Text);
                cmd.Parameters.Add("@SdtDG", SqlDbType.Float).Value = float.Parse(txt_SdtDG_Enter.Text);
                cmd.Parameters.Add("@NgayLap", SqlDbType.Float).Value = float.Parse(txt_NgayLapDG_Enter.Text);
                int count = cmd1.ExecuteNonQuery();
                {
                    MessageBox.Show("Thêm thành công!");
                }
                Connection.Close();
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Chưa thêm thành công!");
            }
        }

        private void btn_DocGia_Update_Click(object sender, EventArgs e)
        {

            DataTable tbl = new DataTable();
            tbl = dt.GetChanges();
            if (tbl == null)
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            else
            {
                cmb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Có" + tbl.Rows.Count + " danh sách đã được cập nhật!");
            }
        }

        private void btn_DocGia_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("server=.;database=19CT3_42_D10;integrated security=true");
            string SCon;
            SCon = "Delete From DocGia Where MaDG = @MaDG";
            SqlCommand cmd1 = new SqlCommand(SCon, Connection);
            Connection.Open();
            cmd1.Parameters.Add("@MaDG", SqlDbType.NVarChar).Value = txt_MaDG_Enter.Text;
            int count = cmd1.ExecuteNonQuery();
            if (count > 0)
            {
                DataRowView row = (DataRowView)binding.Current;
                row.Delete();
                MessageBox.Show("Xóa thành công!");
            }
            Connection.Close();
        }

        private void btn_DocGia_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
