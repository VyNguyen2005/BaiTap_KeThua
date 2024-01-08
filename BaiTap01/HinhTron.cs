using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class HinhTron
    {
        private double bankinh;
        public HinhTron()
        {
            bankinh = 1.0;
        }
        public HinhTron(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public double BanKinh
        {
            set { bankinh = Math.Abs(bankinh); }
            get { return bankinh; }
        }
        public double tinhDientich()
        {
            return Math.PI * bankinh * bankinh;
        }
        public double tinhChuvi()
        {
            return 2 * Math.PI * bankinh;
        }

    }
}
