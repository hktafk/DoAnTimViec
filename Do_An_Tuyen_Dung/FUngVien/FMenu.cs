using Do_An_Ung_Dung_Tim_Viec;
using Guna.UI2.WinForms;
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
    public partial class FMenu : Form
    {
        Modify modify = new Modify();
        public FMenu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_TimViec_Click(object sender, EventArgs e)
        {
            modify.OpenChildForm(currentFormChild,new FTimViec(), pan_ThongTin);
        }

        private void btn_LichSu_TinhTrang_Click(object sender, EventArgs e)
        {
            modify.OpenChildForm(currentFormChild,new FTinhTrang(), pan_ThongTin);
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            modify.OpenChildForm(currentFormChild,new FThongTin_UV(), pan_ThongTin);
        }

        private void pan_ThongTin_Paint(object sender, PaintEventArgs e)
        {

        }
        public void OpenChildFMenu(Form currentForm, Form childForm)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pan_ThongTin.Controls.Clear();
            pan_ThongTin.Controls.Add(childForm);
            pan_ThongTin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
