using Do_An_Ung_Dung_Tim_Viec.FORM_NTD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Tuyen_Dung
{
    public partial class F_DangKiTaiKhoanNTD : Form
    {
        public F_DangKiTaiKhoanNTD()
        {
            InitializeComponent();
        }

        private void F_DangKiTaiKhoanNTD_Load(object sender, EventArgs e)
        {

        }

        private void btXong_DKTK_Click(object sender, EventArgs e)
        {
            Hide();
            FNhapThongTinNTD fNhapThongTinNTD = new FNhapThongTinNTD();
            fNhapThongTinNTD.ShowDialog();
        }
    }
}
