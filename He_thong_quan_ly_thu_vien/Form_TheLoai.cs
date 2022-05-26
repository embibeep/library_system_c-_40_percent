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
        DataSet ds;
        private void Connection()
        {
            //dgv_TheLoai_Enter.Rows.Clear();
            SqlConnection Connection = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
            cmd = new SqlCommand("Select * From TheLoai", Connection);
            da = new SqlDataAdapter(cmd);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Theloai");
            dgv_TheLoai_Enter.DataSource = ds;
            dgv_TheLoai_Enter.DataMember = "TheLoai";
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
            //try
            {
                SqlConnection Connection1 = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
                string Scon;
                Connection1.Open();
                Scon = "insert into TheLoai (TenTL,MoTa,GhiChu) values(@TenTL,@MoTa,@GhiChu)";
                SqlCommand cmd1 = new SqlCommand(Scon, Connection1);
                cmd1.Parameters.Add("@TenTL", txt_TenTL_Enter.Text);
                cmd1.Parameters.Add("@MoTa",  txt_MoTa_Enter.Text);
                cmd1.Parameters.Add("@GhiChu", txt_GhiChu_Enter.Text);
                int count = cmd1.ExecuteNonQuery();
                {
                    MessageBox.Show("Thêm thành công!");
                    
                    Connection();
                }
                Connection1.Close();
            }
            //catch (Exception Exception)
            //{
            //    MessageBox.Show("Chưa thêm thành công!");
            //}
        }

        private void btn_TheLoai_Update_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = ds.Tables["Theloai"].GetChanges();
            if (tbl == null)
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            else
            {         
                da.Update(ds,"TheLoai");
                MessageBox.Show("Có" + tbl.Rows.Count + " danh sách đã được cập nhật!");
            }
        }

        private void btn_theLoai_Delete_Click(object sender, EventArgs e)
        {
            int hientai = this.BindingContext[ds, "Theloai"].Position;
            this.BindingContext[ds, "Theloai"].RemoveAt(hientai);
        }

        private void btn_TheLoai_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
