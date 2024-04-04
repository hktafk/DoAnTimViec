using Do_An_Tuyen_Dung;
using Do_An_Tuyen_Dung.FNhaTuyenDung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Ung_Dung_Tim_Viec.FORM_NTD
{
    public partial class FLichSu : Form
    {
        SqlConnection connStr = Connection.GetSqlConnection();
        string ss = FLogin.TenTaiKhoan;

        public FLichSu()
        {
            InitializeComponent();
            LoadDanhSach(null);
        }

        public bool KTTenCTy(string chuoi)
        {
            if(chuoi == ss)
            {
                return true;
            }
            return false;
        }

        public void LoadDanhSach(string chuoi)
        {
            List<LichSuNTD> list = new List<LichSuNTD>();
            try
            {
                string query = "SELECT TenCongViec,Tinh_TP,TenTaiKhoan FROM DangBaiNTD " +
                    "JOIN ThongTinCTy_Chinh on DangBaiNTD.EmailHR = ThongTinCTy_Chinh.EmailHR " +
                    "JOIN TaoTaiKhoan on TaoTaiKhoan.Email = ThongTinCTy_Chinh.EmailHR";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();
                fpn_HienThi.Controls.Clear();

                

                if (chuoi == null)
                {
                    while (reader.Read())
                    {
                        if(KTTenCTy(reader["TenTaiKhoan"].ToString()) == true)
                        {
                            string nganh = reader["TenCongViec"].ToString();
                            string diaDiem = reader["Tinh_TP"].ToString();
                            LichSuNTD lich = new LichSuNTD(nganh, diaDiem);

                            list.Add(lich);
                        }
                        
                    }
                }
                else
                {
                    while (reader.Read())
                    {
                        if (KTTenCTy(reader["TenTaiKhoan"].ToString()) == true)
                        {
                            if (chuoi == reader["TenCongViec"].ToString())
                            {
                                string nganh = reader["TenCongViec"].ToString();
                                string diaDiem = reader["Tinh_TP"].ToString();
                                LichSuNTD lich = new LichSuNTD(nganh, diaDiem);

                                list.Add(lich);
                            }
                            else if (chuoi == reader["Tinh_TP"].ToString())
                            {
                                string nganh = reader["TenCongViec"].ToString();
                                string diaDiem = reader["Tinh_TP"].ToString();
                                LichSuNTD lich = new LichSuNTD(nganh, diaDiem);

                                list.Add(lich);
                            }
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
            foreach (LichSuNTD l in list)
            {
                UCLichSuNTD ucLS = new UCLichSuNTD(l);
                int dis = (fpn_HienThi.Height - (6 * ucLS.Height)) / 10;
                ucLS.Margin = new Padding(0, dis, 0, 0);
                fpn_HienThi.Controls.Add(ucLS);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FLichSu_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Combobox_Nganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSach(Combobox_Nganh.Text);
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_HienThi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fpn_HienThi_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Combobox_DiaDiem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadDanhSach(Combobox_DiaDiem.Text);
        }
    }
}
