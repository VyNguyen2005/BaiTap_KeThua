using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kinh: ");
            double bankinh = double.Parse(Console.ReadLine());
            HinhTron htron = new HinhTron(bankinh);
            Console.WriteLine("*****Thong tin hinh tron*****");
            Console.WriteLine($"Ban kinh: {htron.BanKinh} - Dien tich: {htron.tinhDientich()} - Chu vi: {htron.tinhChuvi()}");

            Console.Write("Nhap chieu cao: ");
            double chieucao = double.Parse(Console.ReadLine());
            HinhTru htru = new HinhTru(bankinh, chieucao);
            Console.WriteLine("*****Thong tin hinh tru*****");
            Console.WriteLine($"Ban kinh: {htru.BanKinh} - Chieu cao: {htru.ChieuCao} - Dien tich: {htru.tinhDientich()} - The tich: {htru.tinhThetich()}");

            Console.ReadLine();
        }
    }
}
