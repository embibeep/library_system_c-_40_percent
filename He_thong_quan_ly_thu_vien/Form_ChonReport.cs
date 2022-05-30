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
    public partial class Form_ChonReport : Form
    {
        public Form_ChonReport()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_InReport_Click(object sender, EventArgs e)
        {
            Global.Ma = int.Parse(txt_MaPM.Text.ToString());
            Form_Report frm_Report = new Form_Report();
            frm_Report.ShowDialog();
        }
    }
}
