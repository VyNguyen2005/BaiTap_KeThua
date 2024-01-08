using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class TaiLieu
    {
        private int matailieu;
        private string nhaxuatban;
        private int banphathanh;

        public TaiLieu()
        {

        }
        public TaiLieu(int matailieu, string nhaxuatban, int banphathanh)
        {
            this.matailieu = matailieu;
            this.nhaxuatban = nhaxuatban;
            this.banphathanh = banphathanh;
        }
        public int MaTaiLieu
        {
            set { matailieu = value; }
            get { return matailieu; }
        }
        public string NhaXuatBan
        {
            set { nhaxuatban = value; }
            get { return nhaxuatban; }
        }
        public int BanPhatHanh
        {
            set { banphathanh = value; }
            get { return banphathanh; }
        }
    }
}
