using Do_An_Tuyen_Dung.FNhaTuyenDung;
using Do_An_Ung_Dung_Tim_Viec;
using Do_An_Ung_Dung_Tim_Viec.FORM_NTD;

namespace Do_An_Tuyen_Dung
{
    public partial class FDangBai_NTD : Form
    {
        Modify modify = new Modify();
        public FDangBai_NTD()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_DangBai_Click(object sender, EventArgs e)
        {
            modify.OpenChildForm(currentFormChild, new FDangViec(), panel2);
        }

        private void btn_UV_Click(object sender, EventArgs e)
        {
            modify.OpenChildForm(currentFormChild, new FXemUV(), panel2);
        }

        private void btn_LichSu_Click(object sender, EventArgs e)
        {
            modify.OpenChildForm(currentFormChild,new FLichSu(),panel2);
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            string ttk = FLogin.TenTaiKhoan;
            modify.OpenChildForm(currentFormChild,new FThongTin_NTD(ttk),panel2);
        }

        private void pan_ThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
