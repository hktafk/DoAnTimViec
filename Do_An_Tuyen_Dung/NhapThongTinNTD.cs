using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    internal class NhapThongTinNTD
    {
        private string tenCty;
        private string tinh_TP;
        private string quan_Huyen;
        private string xa_Phuong;
        private string sonha;
        private string fileGiayPhep;
        private string tenHR;
        private string emailHR;
        private string sDTHR;

        public NhapThongTinNTD()
        {
        }

        public NhapThongTinNTD(string tenCty, string tinh_TP, string quan_Huyen, string xa_Phuong, string sonha, string fileGiayPhep, string tenHR, string emailHR, string sDTHR)
        {
            this.tenCty = tenCty;
            this.tinh_TP = tinh_TP;
            this.quan_Huyen = quan_Huyen;
            this.xa_Phuong = xa_Phuong;
            this.sonha = sonha;
            this.fileGiayPhep = fileGiayPhep;
            this.tenHR = tenHR;
            this.emailHR = emailHR;
            this.sDTHR = sDTHR;
        }

        public string TenCty { get => tenCty; set => tenCty = value; }
        public string Tinh_TP { get => tinh_TP; set => tinh_TP = value; }
        public string Quan_Huyen { get => quan_Huyen; set => quan_Huyen = value; }
        public string Xa_Phuong { get => xa_Phuong; set => xa_Phuong = value; }
        public string Sonha { get => sonha; set => sonha = value; }
        public string FileGiayPhep { get => fileGiayPhep; set => fileGiayPhep = value; }
        public string TenHR { get => tenHR; set => tenHR = value; }
        public string EmailHR { get => emailHR; set => emailHR = value; }
        public string SDTHR { get => sDTHR; set => sDTHR = value; }
    }
}
