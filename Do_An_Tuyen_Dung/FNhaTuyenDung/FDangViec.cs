using Do_An_Tuyen_Dung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Do_An_Ung_Dung_Tim_Viec
{
    public partial class FDangViec : Form
    {
        private string connectionString = "Data Source=DESKTOP-T4EF20F\\SQLEXPRESS;Initial Catalog=DoAnNhom;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FDangViec()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }
        Modify modify = new Modify();
        private void btn_Dang_Click(object sender, EventArgs e)
        {
            string tenCongViec = txtTenCongViec.Text;
            string luong = Combobox_Luong.Text; // Set a default value if empty
            string kinhNghiem = Combobox_KinhNghiem.Text;
            string hinhThuc = Combobox_HinhThuc.Text;
            bool BHXH = checkBHXH.Checked;
            bool BHYT = checkBHYT.Checked;
            bool coHoiThangTien = checkCoHoi.Checked;
            bool luong13 = checkLuong13.Checked;
            string moTa = txtMoTa.Text;
            string yeuCau = txtYeuCau.Text;
            string tenHR = txtTenHR.Text;
            string emailHR = txtEmailHR.Text;
            string SDTHR = txtSDTHR.Text;
            DateTime thoiGianBD = dateNgayBD.Value;  // Assuming dateNgayBD is a DateTimePicker control
            DateTime thoiGianKT = dateNgayKT.Value;  // Assuming dateNgayKT is a DateTimePicker control
            string ghiChu = txtGhiChu.Text;
            string quyenLoiKhac = txtGhiChu.Text;
            try
            {
                // Use parameterized query for security and clarity
                string query = "INSERT INTO DangBaiNTD (TenCongViec, Luong, KinhNghiem, HinhThuc, BHXH, BHYT, CoHoiThangTien, Luong13, MoTa, YeuCau, TenHR, EmailHR, SDTHR, ThoiGianBD, ThoiGianKT, GhiChu, QuyenLoiKhac) VALUES (@tenCongViec, @luong,@KinhNghiem, @HinhThuc, @BHXH, @BHYT, @CoHoiThangTien, @Luong13, @MoTa, @YeuCau, @TenHR, @EmailHR, @SDTHR, @ThoiGianBD, @ThoiGianKT, @GhiChu, @QuyenLoiKhac)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters for security
                        command.Parameters.AddWithValue("@tenCongViec", tenCongViec);
                        command.Parameters.AddWithValue("@luong", luong);
                        command.Parameters.AddWithValue("@KinhNghiem", kinhNghiem);
                        command.Parameters.AddWithValue("@HinhThuc", hinhThuc);
                        command.Parameters.AddWithValue("@BHXH", BHXH);
                        command.Parameters.AddWithValue("@BHYT", BHYT);
                        command.Parameters.AddWithValue("@CoHoiThangTien", coHoiThangTien);
                        command.Parameters.AddWithValue("@Luong13", luong13);
                        command.Parameters.AddWithValue("@MoTa", moTa);
                        command.Parameters.AddWithValue("@YeuCau", yeuCau);
                        command.Parameters.AddWithValue("@TenHR", tenHR);
                        command.Parameters.AddWithValue("@EmailHR", emailHR);
                        command.Parameters.AddWithValue("@SDTHR", SDTHR);
                        command.Parameters.AddWithValue("@ThoiGianBD", thoiGianBD);
                        command.Parameters.AddWithValue("@ThoiGianKT", thoiGianKT);
                        command.Parameters.AddWithValue("@GhiChu", ghiChu);
                        command.Parameters.AddWithValue("@QuyenLoiKhac", quyenLoiKhac);
                        // ... (add parameters for other fields)

                        connection.Open();
                        command.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT

                        MessageBox.Show("Đăng việc thành công!");
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đăng việc thất bại do lỗi SQL: " + ex.Message);
            }
            catch (Exception ex) // Catch any other exceptions
            {
                MessageBox.Show("Đăng việc thất bại do lỗi không xác định: " + ex.Message);
            }

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTenCongViec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Dang_Click_1(object sender, EventArgs e)
        {

        }

        private void FDangViec_Load(object sender, EventArgs e)
        {

        }
    }
}
