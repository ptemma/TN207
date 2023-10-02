using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TinhGiaTri
{
    class Program
    {
        static void Main(string[] args)
        {
            string strX, strY;
            float x, y;
            double result;
            Console.Write("Nhap x = ");
            strX = Console.ReadLine();
            Console.Write("Nhap y = ");
            strY = Console.ReadLine();
            if (float.TryParse(strX, out x) && float.TryParse(strY, out y))
            {
                if (y != -1 && x <= 12 && x >= -2)
                {
                    result = Math.Abs(x / (y + 1)) + Math.Sqrt((12 - x) * (x + 2));
                    Console.WriteLine("Ket qua : " + result.ToString("#,##0.00"));
                }
                else
                    Console.WriteLine("gia tri x,y khong thoa dieu kien!");
            }
            else
                Console.WriteLine("Loi nhap gia tri x,y!");

            Console.ReadLine();
        }
    }
}
