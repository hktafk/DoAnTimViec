using Do_An_Tuyen_Dung.FUngVien;
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
    public partial class UCTimKiem : UserControl
    {
        TimKiem timKiem;
        public UCTimKiem()
        {
            InitializeComponent();
        }
        public UCTimKiem(TimKiem timKiem)
        {
            InitializeComponent();
            this.timKiem = timKiem;
            txtNganh1.Text = timKiem.Nganh;
            txtDiaDiem1.Text = timKiem.Diadiem;
            txtLuong1.Text = timKiem.Luong;
            txtKinhNghiem1.Text = timKiem.KinhNghiem;
        }
        public string UCTimKiem1()
        {
            return this.txtNganh1.Text;
        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            string nganhDuocChon = txtNganh1.Text; 
            FMoTa_YeuCau_QuyenLoi fMoTa_YeuCau_QuyenLoi = new FMoTa_YeuCau_QuyenLoi(nganhDuocChon);
            fMoTa_YeuCau_QuyenLoi.Show();
        }
    }
}
