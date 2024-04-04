using Do_An_Tuyen_Dung;
using Do_An_Tuyen_Dung.FNhaTuyenDung;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Do_An_Tuyen_Dung.FNhaTuyenDung
{
    public partial class FThongTin_NTD : Form
    {
        Modify modify = new Modify();
        string tenTaiKhoan ;
        public FThongTin_NTD()
        {
            InitializeComponent();
        }
        public FThongTin_NTD(string chuoi)
        {
            tenTaiKhoan = chuoi;
            InitializeComponent(); 
            ThucThi(tenTaiKhoan);
        }
        public void ThucThi(string tenTaiKhoan)
        {
            string em = "VanKien@gmail.com";

            DataTable dataTable = new DataTable();
            string sqlQuery = "SELECT TenCTy,Tinh_TP, Quan_Huyen, Xa_Phuong,SoNha, FileGiayPhep,TenHR, EmailHR,SDTHR FROM ThongTinCTy_Chinh WHERE EmailHR = @EmailHR";


            DataTable dataTable1 = new DataTable();
            string sqlQuery1 = "SELECT TenTaiKhoan,Email FROM TaoTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            modify.TaiDuLieu(dataTable1, sqlQuery1, "@TenTaiKhoan", tenTaiKhoan);            
            if (dataTable1.Rows.Count > 0)
            {
                foreach (DataRow row1 in dataTable1.Rows)
                {
                    string TenTK = row1["TenTaiKhoan"].ToString();
                    if (TenTK == tenTaiKhoan)
                    {
                        em = row1["Email"].ToString();
                    }
                }
            }

            modify.TaiDuLieu(dataTable, sqlQuery, "@EmailHR", em);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string email = row["EmailHR"].ToString();
                    if (email == em)
                    {
                        txtTenCTy.Text = row["TenCTy"].ToString();
                        txtTinh_TP.Text = row["Tinh_TP"].ToString();
                        txtQuan_Huyen.Text = row["Quan_Huyen"].ToString();
                        txtXa_Phuong.Text = row["Xa_Phuong"].ToString();
                        txtSoNha.Text = row["SoNha"].ToString();
                        txtlinkFileCV.Text = row["FileGiayPhep"].ToString();
                        txtTenHR.Text = row["TenHR"].ToString();
                        txtEmailHR.Text = em;
                        txtSDTHR.Text = row["SDTHR"].ToString();

                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FThongTin_NTD_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
