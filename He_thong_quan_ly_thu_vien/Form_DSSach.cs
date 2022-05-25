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
    public partial class Form_DSSach : Form
    {
        public Form_DSSach()
        {
            InitializeComponent();
        }
        DataSet ds;
        DataTable tb;
        DataTable Sach;
        SqlDataAdapter da;
        public static SqlConnection Connection()
        {
            SqlConnection Connection = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
            if(Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            return Connection;
        }
        private void btn_DSSach_Watch_Click(object sender, EventArgs e)
        {
            Form_XemDS frm_XemDS = new Form_XemDS();
            frm_XemDS.ShowDialog();
        }

        private void btn_DSSach_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ketnoi() {
            SqlCommand cmd = new SqlCommand("select * from TheLoai", Connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Theloai");
            cmd.CommandText = "select * from Sach";
            da.Fill(ds, "Sach");
            DataTable Cha = ds.Tables["Theloai"];
            DataTable Con = ds.Tables["Sach"];
            DataRelation Rl = new DataRelation("Theloai_Sach", Cha.Columns["MaTL"], Con.Columns["MaTL"]);
            ds.Relations.Add(Rl);

            cbo_TheLoai_Choose.DataSource = ds;
            cbo_TheLoai_Choose.DisplayMember = "Theloai.TenTL";
            dgv_DSSach_Enter.DataSource = ds;
            dgv_DSSach_Enter.DataMember = "Theloai.Theloai_Sach";
            
        }
        private void cbo_TheLoai_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_DSSach_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void btn_DSSach_Delete_Click(object sender, EventArgs e)
        {
            int hientai = this.BindingContext[ds, "Sach"].Position;
            this.BindingContext[ds, "Sach"].RemoveAt(hientai);
        }

        private void btn_DSSach_Add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Connection1 = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
                string Scon;
                Connection1.Open();
                Scon = "insert into Sach (MaSach,TenSach,MoTa,Gia,NgayLap,MaTL) values(@MaSach,@TenSach,@MoTa,@Gia,@NgayLap,@MaTL)";
                SqlCommand cmd1 = new SqlCommand(Scon, Connection1);
                cmd1.Parameters.Add("@MaSach", txt_MaSach_Enter.Text);
                cmd1.Parameters.Add("@TenSach", txt_TenSach_Enter.Text);
                cmd1.Parameters.Add("@MoTa", txt_MoTa_Enter.Text);
                cmd1.Parameters.Add("@Gia", txt_Gia_Enter.Text);
                cmd1.Parameters.Add("@NgayLap", txt_NgayLap_Enter.Text);
                cmd1.Parameters.Add("@MaTL", txt_MaTL_Enter.Text);
                int count = cmd1.ExecuteNonQuery();
                {
                    MessageBox.Show("Thêm thành công!");

                    ketnoi();
                }
                Connection1.Close();
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Chưa thêm thành công!");
            }
        }

        private void dgv_DSSach_Enter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //các thuộc tính trong ngoặc vuông có thể thay đổi tùy theo tên biến trong database.
                txt_MaSach_Enter.Text = dgv_DSSach_Enter.CurrentRow.Cells["MaSach"].Value.ToString();
                txt_TenSach_Enter.Text = dgv_DSSach_Enter.CurrentRow.Cells["TenSach"].Value.ToString();
                txt_MoTa_Enter.Text = dgv_DSSach_Enter.CurrentRow.Cells["MoTa"].Value.ToString();
                txt_Gia_Enter.Text = dgv_DSSach_Enter.CurrentRow.Cells["Gia"].Value.ToString();
                txt_NgayLap_Enter.Text = dgv_DSSach_Enter.CurrentRow.Cells["NgayLap"].Value.ToString();
                txt_MaTL_Enter.Text = dgv_DSSach_Enter.CurrentRow.Cells["MaTL"].Value.ToString();
            }
        }

        private void btn_DSSach_Update_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = ds.Tables["Sach"].GetChanges();
            if (tbl == null)
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            else
            {
                da.Update(ds, "Sach");
                MessageBox.Show("Có" + tbl.Rows.Count + " danh sách đã được cập nhật!");
            }
        }

        private void btn_DSSach_Report_Click(object sender, EventArgs e)
        {
            Form_Report_Sach frm_Report_Sach = new Form_Report_Sach();
            frm_Report_Sach.ShowDialog();
        }
    }
}
