using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Sach : TaiLieu
    {
        private string tacgia;
        private int sotrang;
        public Sach() : base()
        {

        }
        public Sach(string tacgia, int sotrang, int matailieu, string nhaxuatban, int banphathanh) : base(matailieu, nhaxuatban, banphathanh)
        {
            this.tacgia = tacgia;
            this.sotrang = sotrang;
        }
        public string TacGia
        {
            set { tacgia = value; }
            get { return tacgia; }
        }
        public int SoTrang
        {
            set { sotrang = value; }
            get { return sotrang; }
        }
    }
}
