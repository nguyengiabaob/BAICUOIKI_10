using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baicuoiki.Bang
{
    class Bangnhanvien :Bang
    {
        public Bangnhanvien() : base("NHANVIEN") { }
        public Bangnhanvien(string pquery) : base("NHANVIEN", pquery) { }

    }
}
