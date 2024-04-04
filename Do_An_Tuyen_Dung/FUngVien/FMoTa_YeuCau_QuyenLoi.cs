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

namespace Do_An_Tuyen_Dung.FUngVien
{
    public partial class FMoTa_YeuCau_QuyenLoi : Form
    {

        SqlConnection connStr = Connection.GetSqlConnection();
        Modify modify = new Modify();
        string tenCV;
        public FMoTa_YeuCau_QuyenLoi()
        {
            InitializeComponent();
        }
        public FMoTa_YeuCau_QuyenLoi(string nganhDuocChon)
        {
            InitializeComponent();
            tenCV = nganhDuocChon;
            LoadDuLieu(tenCV);
        }

        public void LoadDuLieu(string chuoi)
        {
            txtNganh.Text = "Ngành: " + chuoi;
            MoTaYeuCau moTaYeuCau = new MoTaYeuCau();
            try
            {
                DataTable dataTable = new DataTable();
                string query = "SELECT TenCongViec,Luong,KinhNghiem,HinhThuc,BHXH,BHYT,CoHoiThangTien,Luong13,MoTa,YeuCau,TenHR,EmailHR,SDTHR,ThoiGianBD,ThoiGianKT,GhiChu,QuyenLoiKhac FROM DangBaiNTD WHERE TenCongViec = @TenCongViec";
                modify.TaiDuLieu(dataTable, query, "@TenCongViec", chuoi);
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string TenCV = row["TenCongViec"].ToString();
                        if (TenCV == chuoi)
                        {
                            txtLuong.Text = row["Luong"].ToString();
                            txtKinhNghiem.Text = row["KinhNghiem"].ToString();
                            txtHinhThuc.Text = row["HinhThuc"].ToString();
                            string chuoiQL = string.Empty;
                            if (row["BHXH"].ToString() == "True") chuoiQL = chuoiQL + "BHXH, ";
                            if (row["BHYT"].ToString() == "True") chuoiQL = chuoiQL + "BHYT, ";
                            if (row["CoHoiThangTien"].ToString() == "True") chuoiQL = chuoiQL + "Cơ Hội Thăng Tiến, ";
                            if (row["Luong13"].ToString() == "True") chuoiQL = chuoiQL + "Lương Tháng 13, ";
                            txtQuyenLoi.Text = chuoiQL + row["QuyenLoiKhac"].ToString();
                            txtMoTa.Text = row["MoTa"].ToString();
                            txtYeuCau.Text = row["YeuCau"].ToString();
                            txtTenHR.Text = row["TenHR"].ToString();
                            txtEmailHR.Text = row["EmailHR"].ToString();
                            txtSDTHR.Text = row["SDTHR"].ToString();
                            txtNgayBD.Text = row["ThoiGianBD"].ToString();
                            txtNgayKT.Text = row["ThoiGianKT"].ToString();
                            txtGhiChu.Text = row["GhiChu"].ToString();
                        }
                    }
                }

                DataTable dataTable1 = new DataTable();
                string query1 = "SELECT TenCTy,EmailHR FROM ThongTinCTy_Chinh WHERE EmailHR =@EmailHR";
                string em1 = txtEmailHR.Text;              
                modify.TaiDuLieu(dataTable1, query1, "@EmailHR", em1);
                if (dataTable1.Rows.Count > 0)
                {
                    foreach (DataRow row1 in dataTable1.Rows)
                    {
                        string em = row1["EmailHR"].ToString();
                        if (em == em1)
                        {
                            txtCty.Text = "Công ty: " + row1["TenCTy"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                connStr.Close();
            }
        }
        public string LoadTenTK()
        {
            string eM = txtEmailHR.Text;
            DataTable dataTable = new DataTable();
            string query = "SELECT TenTaiKhoan,Email FROM TaoTaiKhoan WHERE Email = @Email";
            modify.TaiDuLieu(dataTable, query, "@Email", eM);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string em = row["Email"].ToString();
                    if (em == eM)
                    {
                        return row["TenTaiKhoan"].ToString();
                    }
                }
            }
            return ""; // Trả về chuỗi rỗng nếu không tìm thấy giá trị
        }
        private void FMoTa_YeuCau_QuyenLoi_Load(object sender, EventArgs e)
        {

        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            string tenTK1 = LoadTenTK();
            FThongTin_NTD fThongTin_NTD = new FThongTin_NTD(tenTK1);
            fThongTin_NTD.ShowDialog();
        }

        private void btn_NopDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
