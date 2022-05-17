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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Access_Click(object sender, EventArgs e)
        {
            Form_Menu frm_Menu = new Form_Menu();
            frm_Menu.ShowDialog();
        }

        private void btn_Login_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
