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
namespace Do_An_Tuyen_Dung.FUngVien
{
    public partial class FTinhTrang : Form
    {
        SqlConnection connStr = Connection.GetSqlConnection();
        public FTinhTrang()
        {
            InitializeComponent();
            LoadDanhSach(null);
        }

        public void LoadDanhSach(string chuoi)
        {
            List<TinhTrang> list = new List<TinhTrang>();
            try
            {
                string query = "SELECT TenCongViec,Tinh_TP,TenCTy FROM DangBaiNTD INNER JOIN ThongTinCTy_Chinh on DangBaiNTD.EmailHR = ThongTinCTy_Chinh.EmailHR ";
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
                        string cty = reader["TenCTy"].ToString();
                        TinhTrang tinh = new TinhTrang(nganh, diaDiem, cty);

                        list.Add(tinh);
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
                            string cty = reader["TenCTy"].ToString();
                            TinhTrang tinh = new TinhTrang(nganh, diaDiem, cty);

                            list.Add(tinh);
                        }
                        else if (chuoi == reader["Tinh_TP"].ToString())
                        {
                            string nganh = reader["TenCongViec"].ToString();
                            string diaDiem = reader["Tinh_TP"].ToString();
                            string cty = reader["TenCTy"].ToString();
                            TinhTrang tinh = new TinhTrang(nganh, diaDiem, cty);

                            list.Add(tinh);
                        }
                        else if (chuoi == reader["TenCTy"].ToString())
                        {
                            string nganh = reader["TenCongViec"].ToString();
                            string diaDiem = reader["Tinh_TP"].ToString();
                            string cty = reader["TenCTy"].ToString();
                            TinhTrang tinh = new TinhTrang(nganh, diaDiem, cty);

                            list.Add(tinh);
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
            foreach (TinhTrang t in list)
            {
                UCTinhTrang ucTT = new UCTinhTrang(t);
                int dis = (fpnHT.Height - (6 * ucTT.Height)) / 10;
                ucTT.Margin = new Padding(0, dis, 0, 0);
                fpnHT.Controls.Add(ucTT);
            }

        }
        private void FTinhTrang_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Combobox_Nganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSach(Combobox_Nganh.Text);
        }

        private void pan_HTTT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void Combobox_DiaDiem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadDanhSach(Combobox_DiaDiem.Text);
        }

        private void Combobox_CTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSach(Combobox_CTy.Text);
        }
    }
}
