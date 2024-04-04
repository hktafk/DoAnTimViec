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

namespace Do_An_Ung_Dung_Tim_Viec
{
    public partial class FXemUV : Form
    {
        SqlConnection connStr = Connection.GetSqlConnection();
        Modify modify = new Modify();
        public FXemUV()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        public void LoadDanhSach()
        {
            List<XemUV> list = new List<XemUV>();
            try
            {
                string query = "SELECT HoTenUV FROM NhapThongTinUV ";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string hoten = reader["HoTenUV"].ToString();
                    XemUV xem = new XemUV(hoten);

                    list.Add(xem);
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
            foreach (XemUV x in list)
            {
                UCXemUV ucXem = new UCXemUV(x);
                int dis = (fpn_HienThi.Height - (6 * ucXem.Height)) / 10;
                ucXem.Margin = new Padding(0, dis, 0, 0);
                fpn_HienThi.Controls.Add(ucXem);
            }

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        Form curentForm;
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Combobox_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FXemUV_Load(object sender, EventArgs e)
        {

        }

        private void fpn_HienThi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
