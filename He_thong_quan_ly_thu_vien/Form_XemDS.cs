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
    public partial class Form_XemDS : Form
    {
        public Form_XemDS()
        {
            InitializeComponent();
        }

        DataSet ds;
        DataTable tb;
        DataTable Sach;
        SqlDataAdapter da;
        SqlCommandBuilder buider;
        public static SqlConnection Connection()
        {
            SqlConnection Connection = new SqlConnection(@"server=ADMIN\SQLEXPRESS;database=19CT3_42_D10;integrated security=true");
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            return Connection;
        }

        private void ketnoi()
        {
            SqlCommand cmd = new SqlCommand("select * from TheLoai", Connection());
            da = new SqlDataAdapter(cmd);

            ds = new DataSet();
            da.Fill(ds, "Theloai");
            cmd.CommandText = "select * from Sach";
            da.Fill(ds, "Sach");
            buider = new SqlCommandBuilder(da);
            DataTable Cha = ds.Tables["Theloai"];
            DataTable Con = ds.Tables["Sach"];

            DataRelation Rl = new DataRelation("Theloai_Sach", Cha.Columns["MaTL"], Con.Columns["MaTL"]);
            ds.Relations.Add(Rl);

            cbo_TheLoai_Choose.DataSource = ds;
            cbo_TheLoai_Choose.DisplayMember = "Theloai.TenTL";
            dgv_XemDS_Enter.DataSource = ds;
            dgv_XemDS_Enter.DataMember = "Theloai.Theloai_Sach";

        }

        private void btn_XemDS_Enter_Click(object sender, EventArgs e)
        {
            Form_DSSach frm_DSSach = new Form_DSSach();
            this.Hide();
            frm_DSSach.ShowDialog();
            this.Close();
        }

        private void btn_XemDS_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_XemDS_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void dgv_XemDS_Enter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //các thuộc tính trong ngoặc vuông có thể thay đổi tùy theo tên biến trong database.
                txt__MaSach_Watch.Text = dgv_XemDS_Enter.CurrentRow.Cells["IDSach"].Value.ToString();
                txt_TenSach_Watch.Text = dgv_XemDS_Enter.CurrentRow.Cells["TenSach"].Value.ToString();
                txt_MoTa_Watch.Text = dgv_XemDS_Enter.CurrentRow.Cells["MoTa"].Value.ToString();
                txt_Gia_Watch.Text = dgv_XemDS_Enter.CurrentRow.Cells["Gia"].Value.ToString();
                txt_NgayLap_Watch.Text = dgv_XemDS_Enter.CurrentRow.Cells["NgayLap"].Value.ToString();
                txt_MaTL_Watch.Text = dgv_XemDS_Enter.CurrentRow.Cells["MaTL"].Value.ToString();
            }
        }
    }
}
