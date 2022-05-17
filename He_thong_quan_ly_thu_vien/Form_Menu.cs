using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_thong_quan_ly_thu_vien
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Menu_Tick(object sender, EventArgs e)
        {
            label3.Text = "Init";
            String time = DateTime.Now.ToString();
            label3.Text = time;
        }

        private void btn_TheLoai_Enter_Click(object sender, EventArgs e)
        {
            Form_TheLoai frm_TheLoai = new Form_TheLoai();
            frm_TheLoai.ShowDialog();
        }

        private void btn_DSSach_Enter_Click(object sender, EventArgs e)
        {
            Form_DSSach frm_dssach = new Form_DSSach();
            frm_dssach.ShowDialog();
        }

        private void btn_DSDocGia_Enter_Click(object sender, EventArgs e)
        {
            Form_DocGia frm_DocGia = new Form_DocGia();
            frm_DocGia.ShowDialog();
        }

        private void btn_PhieuMuon_Enter_Click(object sender, EventArgs e)
        {
            Form_PhieuMuon frm_PM = new Form_PhieuMuon();
            frm_PM.ShowDialog();
        }

        private void btn_DSSach_Watch_Click(object sender, EventArgs e)
        {
            Form_XemDS frm_XemDS = new Form_XemDS();
            frm_XemDS.ShowDialog();
        }

        private void btn_PhieuMuon_Watch_Click(object sender, EventArgs e)
        {
            Form_XemPM frm_XemPM = new Form_XemPM();
            frm_XemPM.ShowDialog();
        }
    }
}
