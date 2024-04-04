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
using static System.Net.Mime.MediaTypeNames;

namespace Do_An_Tuyen_Dung.FUngVien
{

    public partial class FTimViec : Form
    {

        SqlConnection connStr = Connection.GetSqlConnection();
        public FTimViec()
        {
            InitializeComponent();
            LoadDanhSach(null);
        }

        public void LoadDanhSach(string chuoi)
        {
            List<TimKiem> list = new List<TimKiem>();
            try
            {
                string query = "SELECT TenCongViec,Luong,KinhNghiem,Tinh_TP FROM DangBaiNTD INNER JOIN ThongTinCTy_Chinh on DangBaiNTD.EmailHR = ThongTinCTy_Chinh.EmailHR ";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();
                fpnHT.Controls.Clear();
                if (chuoi == null)
                {
                    while (reader.Read())
                    {
                        string nganh = reader["TenCongViec"].ToString();
                        string diaDiem = reader["Tinh_TP"].ToString();
                        string luong = reader["Luong"].ToString();
                        string kinhNghiem = reader["KinhNghiem"].ToString();
                        TimKiem tim = new TimKiem(nganh, diaDiem, luong, kinhNghiem);

                        list.Add(tim);
                    }
                }
                else
                {
                    while (reader.Read())
                    {
                        if (chuoi == reader["TenCongViec"].ToString())
                        {
                            string nganh = reader["TenCongViec"].ToString();
                            string diaDiem = reader["Tinh_TP"].ToString();
                            string luong = reader["Luong"].ToString();
                            string kinhNghiem = reader["KinhNghiem"].ToString();
                            TimKiem tim = new TimKiem(nganh, diaDiem, luong, kinhNghiem);

                            list.Add(tim);
                        }
                        else if (chuoi == reader["Tinh_TP"].ToString())
                        {
                            string nganh = reader["TenCongViec"].ToString();
                            string diaDiem = reader["Tinh_TP"].ToString();
                            string luong = reader["Luong"].ToString();
                            string kinhNghiem = reader["KinhNghiem"].ToString();
                            TimKiem tim = new TimKiem(nganh, diaDiem, luong, kinhNghiem);
                            list.Add(tim);
                        }
                        else if (chuoi == reader["Luong"].ToString())
                        {
                            string nganh = reader["TenCongViec"].ToString();
                            string diaDiem = reader["Tinh_TP"].ToString();
                            string luong = reader["Luong"].ToString();
                            string kinhNghiem = reader["KinhNghiem"].ToString();
                            TimKiem tim = new TimKiem(nganh, diaDiem, luong, kinhNghiem);
                            list.Add(tim);
                        }
                        else if (chuoi == reader["KinhNghiem"].ToString())
                        {
                            string nganh = reader["TenCongViec"].ToString();
                            string diaDiem = reader["Tinh_TP"].ToString();
                            string luong = reader["Luong"].ToString();
                            string kinhNghiem = reader["KinhNghiem"].ToString();
                            TimKiem tim = new TimKiem(nganh, diaDiem, luong, kinhNghiem);
                            list.Add(tim);
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
            foreach (TimKiem t in list)
            {
                UCTimKiem ucTK = new UCTimKiem(t);
                int dis = (fpnHT.Height - (6 * ucTK.Height)) / 10;
                ucTK.Margin = new Padding(0, dis, 0, 0);
                fpnHT.Controls.Add(ucTK);
            }
        }

        private void FTimViec_Load(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSach(txtTimCongViec.Text);
        }
        private void txtTimCongViec_TextChanged(object sender, EventArgs e)
        {

        }

        private void Combobox_DiaDiem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadDanhSach(Combobox_DiaDiem.Text);
        }

        private void Combobox_Luong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadDanhSach(Combobox_Luong.Text);
        }

        private void Combobox_KinhNghiem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadDanhSach(Combobox_KinhNghiem.Text);
        }
    }
}
