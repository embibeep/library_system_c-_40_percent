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
    public partial class Form_XemDS : Form
    {
        public Form_XemDS()
        {
            InitializeComponent();
        }

        private void btn_XemDS_Enter_Click(object sender, EventArgs e)
        {
            Form_DSSach frm_DSSach = new Form_DSSach();
            frm_DSSach.ShowDialog();
        }

        private void btn_XemDS_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
