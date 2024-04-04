using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    public class LichSuNTD
    {
        string nganh;
        string diaDiem;
        //string soNguoi;

        public LichSuNTD()
        {
        }

        public LichSuNTD(string nganh, string diaDiem)
        {
            this.nganh = nganh;
            this.diaDiem = diaDiem;
            //this.soNguoi = soNguoi;
        }

        public string Nganh { get => nganh; set => nganh = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        //public string SoNguoi { get => soNguoi; set => soNguoi = value; }
    }
}
