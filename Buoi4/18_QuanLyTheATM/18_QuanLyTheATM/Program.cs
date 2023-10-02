using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_QuanLyTheATM
{
    class Program
    {

        static void Main(string[] args)
        {
            TaiKhoanATM TK1 = new TaiKhoanATM();
            TaiKhoanATM TK2 = new TaiKhoanATM(2, "TK2",0);
            TaiKhoanATM TK3 = new TaiKhoanATM(3, "TK3", 500);
            TaiKhoanThuong TK4 = new TaiKhoanThuong();
            TaiKhoanThuong TK5 = new TaiKhoanThuong(5,"Nguyen van A", 1000);
            TaiKhoanVip TK7 = new TaiKhoanVip();
            TaiKhoanVip TK8 = new TaiKhoanVip(8, "Nguyen van C", 1000);

            TK7.toString();
            TK8.toString();
            TK8.guiTien(300);
            TK8.chuyenKhoan(TK5, 200);
            TK5.toString();
            TK8.rutTien(1200);
            TK8.rutTien(100);

            TaiKhoanATM TK9 = new TaiKhoanThuong(9, "Nguyen Van D", 1254);
            TK9.toString();
            TK9.chuyenKhoan(TK5, 1000);
            TK5.toString();
            TK9.rutTien(500);



            TK4.toString();
            TK5.toString();
            TK5.guiTien(300);
            TK5.chuyenKhoan(TK3, 200);
            TK5.rutTien(1000);

            TaiKhoanATM TK6 = new TaiKhoanThuong(6, "Nguyen Van C" , 1100);
            TK6.toString();
            TK6.chuyenKhoan(TK2, 1000);
            TK2.toString();
            TK6.rutTien(500);

            TK1.SoTK = 1;
            TK1.TenTK = "Nguyen Phuoc Trong";
            TK1.soDuTK = 300;

            int iSoTK = TK1.SoTK;
            string sTenTK = TK1.TenTK;
            float fSoDuTK = TK1.soDuTK;
            float fSoDuToiDa = TK1.soTienToiDa;

            TK1.toString();
            TK2.toString();
            TK3.toString();

            TK1.guiTien(500);
            TK1.rutTien(200);
            TK1.rutTien(300);

            TK3.chuyenKhoan(TK3, 400);
            TK3.chuyenKhoan(TK2, -400);
            TK3.chuyenKhoan(TK2, 400);

            TK3.chuyenKhoan(TK1, 200);

            Console.ReadLine();
        }
    }
}
