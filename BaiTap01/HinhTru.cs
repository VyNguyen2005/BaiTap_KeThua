using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class HinhTru : HinhTron
    {
        private double chieucao;
        public HinhTru() : base()
        {

        }
        public HinhTru(double bankinh, double chieucao) : base(bankinh)
        {
            this.chieucao = chieucao;
        }
        public double ChieuCao
        {
            set { chieucao = Math.Abs(chieucao); }
            get { return chieucao; }
        }
      
        public double tinhThetich()
        {
            return base.tinhDientich() * ChieuCao;
        }
        public new double tinhDientich()
        {
            return 2 * base.tinhDientich() + base.tinhChuvi() + ChieuCao;
        }


    }
}
