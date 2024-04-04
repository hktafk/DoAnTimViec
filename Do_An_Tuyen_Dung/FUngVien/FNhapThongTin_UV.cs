using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Tuyen_Dung.FUngVien
{
    public partial class FNhapThongTin_UV : Form
    {
        public FNhapThongTin_UV()
        {
            InitializeComponent();
        }

        private void FNhapThongTin_UV_Load(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            Hide();
            FMenu fMenu = new FMenu();
            fMenu.ShowDialog();
        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            Hide();
            FCreateAccount frm = new FCreateAccount();
            frm.ShowDialog();
        }
    }
}
