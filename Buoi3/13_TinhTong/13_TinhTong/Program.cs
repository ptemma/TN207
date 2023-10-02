using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_TinhTong
{
    class Program
    {
        static int GiaiThua(int n)
        {
            int Ketqua = 1;
            for (int i = 1; i <= n; i++)
                Ketqua *= i;
            return Ketqua;
        }
        static void Main(string[] args)
        {
            string strTemp;
            int n;
            double x,KetQua=0.0;
            Console.Write("Nhap so nguyen duong n : ");
            strTemp = Console.ReadLine();
            while (!int.TryParse(strTemp, out n) || n <= 0)
            {
                Console.Write("Loi nhap n, nhap lai n = ");
                strTemp = Console.ReadLine();
            }
            Console.Write("Nhap so thuc x : ");
            strTemp = Console.ReadLine();
            while (!double.TryParse(strTemp, out x) || n <= 0)
            {
                Console.Write("Loi nhap x, nhap lai x = ");
                strTemp = Console.ReadLine();
            }
            for (int i = 1; i <= n; i++)
            {
                KetQua += (x + Math.Pow(-1, i) * i) / GiaiThua(n - i + 1);

            }
            Console.WriteLine("Ket qua phep tinh : " + KetQua.ToString("#,##0.00"));
            Console.ReadLine();
        }
    }
}
