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
    public partial class Form_DSSach : Form
    {
        public Form_DSSach()
        {
            InitializeComponent();
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

    }
}
