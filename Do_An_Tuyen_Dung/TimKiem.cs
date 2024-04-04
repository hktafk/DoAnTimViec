using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    public class TimKiem
    {
        string nganh;
        string diadiem;
        string luong;
        string kinhNghiem;
        public TimKiem() { }

        public TimKiem(string nganh, string diadiem, string luong, string kinhNghiem)
        {
            this.nganh = nganh;
            this.diadiem = diadiem;
            this.luong = luong;
            this.kinhNghiem = kinhNghiem;
        }

        public string Nganh { get => nganh; set => nganh = value; }
        public string Diadiem { get => diadiem; set => diadiem = value; }
        public string Luong { get => luong; set => luong = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }
    }
}
