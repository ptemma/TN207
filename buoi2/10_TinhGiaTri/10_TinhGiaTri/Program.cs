using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_TinhGiaTri
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA, strB;
            float a,b;
            double result;

            Console.WriteLine("Nhap a: ");
            strA = Console.ReadLine();
            Console.WriteLine("Nhap b: ");
            strB = Console.ReadLine();

            if (float.TryParse(strA, out a) && float.TryParse(strB, out b))
            {
                
            }

            Console.ReadLine();
        }
    }
}
