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
    public partial class UCTinhTrang : UserControl
    {
        TinhTrang tinhTrang;
        public UCTinhTrang()
        {
            InitializeComponent();
        }
        public UCTinhTrang(TinhTrang tinhTrang)
        {
            InitializeComponent();
            this.tinhTrang = tinhTrang;
            txtNganh.Text = tinhTrang.Nganh;
            txtDiaDiem.Text = tinhTrang.DiaDiem;
            txtCTy.Text = tinhTrang.Cty;
        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
