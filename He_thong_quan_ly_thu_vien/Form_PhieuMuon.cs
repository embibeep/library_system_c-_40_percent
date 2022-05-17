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
    public partial class Form_PhieuMuon : Form
    {
        public Form_PhieuMuon()
        {
            InitializeComponent();
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

    }
}
