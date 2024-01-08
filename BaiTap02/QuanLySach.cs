using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class QuanLySach
    {
        private TaiLieu[] ds;
        private int n;
        public QuanLySach()
        {
            ds = new TaiLieu[100];
            n = 0;
        }
        public QuanLySach(int sophantu)
        {
            ds = new TaiLieu[sophantu];
            n = 0;
        }
        private bool Kiemtratrung(int matl)
        {
            for(int i = 0; i<n; i++)
            {
                if(ds[i].MaTaiLieu == matl)
                {
                    return true;
                }
            }
            return false;
        }
        public void ThemSach(TaiLieu sach)
        {
            if(n>= ds.Length)
            {
                Console.WriteLine("Danh ");
            }
            else
            {
                if(!Kiemtratrung(sach.MaTaiLieu))
                {
                    ds[n++] = sach;
                }
                else
                {
                    Console.WriteLine("Trung tai lieu");

                }
            }
        }
        
    }
}
