using Do_An_Tuyen_Dung.FUngVien;
using Do_An_Ung_Dung_Tim_Viec;
using Do_An_Ung_Dung_Tim_Viec.FORM_NTD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Do_An_Tuyen_Dung
{
    public partial class UCLichSuNTD : UserControl
    {
        LichSuNTD lichSuNTD;
        SqlConnection connStr = Connection.GetSqlConnection();
        public UCLichSuNTD()
        {
            InitializeComponent();
        }
        public UCLichSuNTD(LichSuNTD lichSuNTD)
        {
            InitializeComponent();
            this.lichSuNTD = lichSuNTD;
            txtNganh1.Text = lichSuNTD.Nganh;
            txtDiaDiem1.Text = lichSuNTD.DiaDiem;

        }

        public void Xoa()
        {
            try
            {
                string query = string.Format("DELETE FROM DangBaiNTD WHERE TenCongViec = '{0}'", txtNganh1.Text);
                SqlCommand command = new SqlCommand(query, connStr);

                connStr.Open();
                if (command.ExecuteNonQuery() > 0)
                    MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi : " + ex.Message);
            }
            finally
            {
                connStr.Close();
            }
        }


        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Xoa();
            FDangViec fDangViec = new FDangViec();
            fDangViec.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FXemUV fXemUV = new FXemUV();
            fXemUV.ShowDialog();
        }
    }
}
