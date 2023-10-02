using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TimSo
{
    class Program
    {
        static void Main(string[] args)
        {
            string strM;
            int n = 0, luythua = 1, m;
            Console.WriteLine("Chương trình tìm số nguyên n lớn nhất");
            Console.Write("Nhap m = ");
            strM = Console.ReadLine();
            while (!int.TryParse(strM, out m) || m <= 3)
            {
                Console.Write("Nhap sai m, nhap lai m = ");
                strM = Console.ReadLine();
            }
            while (luythua*3 < m)
            {
                luythua *= 3;
                n++;
            }
            Console.WriteLine("ket qua n = " + n);


            Console.ReadLine();
        }
    }
}
