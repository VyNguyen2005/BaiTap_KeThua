using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class TapChi : TaiLieu
    {
        private int sophathanh;
        private int thangphathanh;
        public TapChi() : base()
        {

        }
        public TapChi(int sophathanh, int thangphathanh, int matailieu, string nhaxuatban, int banphathanh) : base(matailieu, nhaxuatban, banphathanh)
        {
            this.sophathanh = sophathanh;
            this.thangphathanh = thangphathanh;
        }
        public int SoPhatHanh
        {
            set { sophathanh = value; }
            get { return sophathanh; }
        }
        public int ThangPhatHanh
        {
            set { thangphathanh = value; }
            get { return thangphathanh; }
        }

    }
}
