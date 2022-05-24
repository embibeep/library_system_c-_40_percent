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
    public partial class Form_TheLoai : Form
    {
        public Form_TheLoai()
        {
            InitializeComponent();
        }

        private void Form_TheLoai_Load(object sender, EventArgs e)
        {
            try
            {
                Connection();
            }
            catch(Exception exx)
            {
                MessageBox.Show("Kết nối thất bại!");
            }
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
            cmd = new SqlCommand("Select * From TheLoai", Connection);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            binding.DataSource = dt;
            dgv_TheLoai_Enter.DataSource = binding;
        }

        private void dgv_TheLoai_Enter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //các thuộc tính trong ngoặc vuông có thể thay đổi tùy theo tên biến trong database.
                txt_MaTL_Enter.Text = dgv_TheLoai_Enter.CurrentRow.Cells["MaTL"].Value.ToString();
                txt_TenTL_Enter.Text = dgv_TheLoai_Enter.CurrentRow.Cells["TenTL"].Value.ToString();
                txt_MoTa_Enter.Text = dgv_TheLoai_Enter.CurrentRow.Cells["MoTa"].Value.ToString();
                txt_GhiChu_Enter.Text = dgv_TheLoai_Enter.CurrentRow.Cells["GhiChu"].Value.ToString();
            }
        }

        private void btn_TheLoai_Add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Connection = new SqlConnection("server=.;database=19CT3_42_D10;integrated security=true");
                string Scon;
                Connection.Open();
                Scon = "insert into TheLoai values(@MaTL.@TenTL,@MoTa,@GhiChu)";
                SqlCommand cmd1 = new SqlCommand(Scon, Connection);
                cmd.Parameters.Add("@MaTL", SqlDbType.Int).Value = int.Parse(txt_MaTL_Enter.Text);
                cmd.Parameters.Add("@TenTL", SqlDbType.Int).Value = int.Parse(txt_TenTL_Enter.Text);
                cmd.Parameters.Add("@MoTa", SqlDbType.Int).Value = int.Parse(txt_MoTa_Enter.Text);
                cmd.Parameters.Add("@GhiChu", SqlDbType.Float).Value = float.Parse(txt_GhiChu_Enter.Text);
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

        private void btn_TheLoai_Update_Click(object sender, EventArgs e)
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

        private void btn_theLoai_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("server=.;database=19CT3_42_D10;integrated security=true");
            string SCon;
            SCon = "Delete From TheLoai Where MaTL = @MaTL";
            SqlCommand cmd1 = new SqlCommand(SCon, Connection);
            Connection.Open();
            cmd1.Parameters.Add("@MaTL", SqlDbType.NVarChar).Value = txt_MaTL_Enter.Text;
            int count = cmd1.ExecuteNonQuery();
            if (count > 0)
            {
                DataRowView row = (DataRowView)binding.Current;
                row.Delete();
                MessageBox.Show("Xóa thành công!");
            }
            Connection.Close();
        }

        private void btn_TheLoai_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
