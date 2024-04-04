using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    public class MoTaYeuCau
    {
        string nganh;
        string cty;
        string hinhThuc;
        string moTa;
        string quyenLoi;
        string tenHR;
        string emailHR;
        string sdtHR;
        string ngayBD;
        string ngayKT;
        string ghiChu;

        public MoTaYeuCau()
        {
        }

        public MoTaYeuCau(string nganh, string cty, string hinhThuc, string moTa, string quyenLoi, string tenHR, string emailHR, string sdtHR, string ngayBD, string ngayKT, string ghiChu)
        {
            this.nganh = nganh;
            this.cty = cty;
            this.hinhThuc = hinhThuc;
            this.moTa = moTa;
            this.quyenLoi = quyenLoi;
            this.tenHR = tenHR;
            this.emailHR = emailHR;
            this.sdtHR = sdtHR;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.ghiChu = ghiChu;
        }

        public string Nganh { get => nganh; set => nganh = value; }
        public string Cty { get => cty; set => cty = value; }
        public string HinhThuc { get => hinhThuc; set => hinhThuc = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string QuyenLoi { get => quyenLoi; set => quyenLoi = value; }
        public string TenHR { get => tenHR; set => tenHR = value; }
        public string EmailHR { get => emailHR; set => emailHR = value; }
        public string SdtHR { get => sdtHR; set => sdtHR = value; }
        public string NgayBD { get => ngayBD; set => ngayBD = value; }
        public string NgayKT { get => ngayKT; set => ngayKT = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
