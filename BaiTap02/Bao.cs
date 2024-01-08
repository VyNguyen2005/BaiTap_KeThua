using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Bao : TaiLieu
    {
        private int ngayphathanh;
        public Bao() : base()
        {

        }
        public Bao(int ngayphathanh, int matailieu, string nhaxuatban, int banphathanh) : base(matailieu, nhaxuatban, banphathanh)
        {
            this.ngayphathanh = ngayphathanh;
        }
        public int NgayPhatHanh
        {
            set { ngayphathanh = value; }
            get { return ngayphathanh; }
        }
    }
}
