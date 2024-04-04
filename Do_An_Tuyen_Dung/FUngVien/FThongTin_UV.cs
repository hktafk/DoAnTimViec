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
    public partial class FThongTin_UV : Form
    {
        Modify modify = new Modify();
        string ten = FLogin.TenTaiKhoan;
        public FThongTin_UV()
        {
            InitializeComponent();
            if (ten != null)
            {
                ThucThi();
                btnTroLai.Visible = false;
            }
        }

        public void ThucThi()
        {
            FLogin fLogin = new FLogin();
            string em = "VanKien@gmail.com";
            DataTable dataTable = new DataTable();
            string sqlQuery = "SELECT HoTenUV, NgayThangNamSinh, NoiSinh, FileCV, Tinh_TP, Quan_Huyen, Xa_Phuong, GioiTinh, SoNha,Email FROM NhapThongTinUV WHERE Email = @Email";


            DataTable dataTable1 = new DataTable();
            string sqlQuery1 = "SELECT TenTaiKhoan,Email FROM TaoTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            modify.TaiDuLieu(dataTable1, sqlQuery1, "@TenTaiKhoan", ten);
            if (dataTable1.Rows.Count > 0)
            {
                foreach (DataRow row1 in dataTable1.Rows)
                {
                    string TenTK = row1["TenTaiKhoan"].ToString();
                    if (TenTK == ten)
                    {
                        em = row1["Email"].ToString();
                    }
                }
            }

            modify.TaiDuLieu(dataTable, sqlQuery, "@Email", em);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string email = row["Email"].ToString();
                    if (email == em)
                    {
                        txtHoTen.Text = row["HoTenUV"].ToString();
                        txtNgayThangNamSinh.Text = row["NgayThangNamSinh"].ToString();
                        txtNoiSinh.Text = row["NoiSinh"].ToString();
                        txtTinh_TP.Text = row["Tinh_TP"].ToString();
                        txtQuan_Huyen.Text = row["Quan_Huyen"].ToString();
                        txtXa_Phuong.Text = row["Xa_Phuong"].ToString();
                        txtSoNha.Text = row["SoNha"].ToString();
                        txtlinkFileCV.Text = row["FileCV"].ToString();
                    }
                }
            }
        }

        private void FThongTin_UV_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
