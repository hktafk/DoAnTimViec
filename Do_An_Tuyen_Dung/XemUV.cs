using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    public class XemUV
    {
        string ten;

        public XemUV()
        {
        }

        public XemUV(string ten)
        {
            this.ten = ten;
        }

        public string Ten { get => ten; set => ten = value; }
    }
}
