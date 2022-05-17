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
    public partial class Form_XemPM : Form
    {
        public Form_XemPM()
        {
            InitializeComponent();
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
    }
}
