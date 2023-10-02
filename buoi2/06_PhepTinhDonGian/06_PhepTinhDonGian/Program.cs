using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PhepTinhDonGian
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA, strB;
            float a, b;
            char PhepToans;

            Console.Write("Nhap a = ");
            strA = Console.ReadLine();
            Console.Write("Nhap b = ");
            strB = Console.ReadLine();

            if (float.TryParse(strA, out a) && float.TryParse(strB, out b))
            {
                Console.Write("Nhap phep toan ");
                PhepToans = Console.ReadLine()[0];
                switch (PhepToans)
                {
                    case '+': Console.WriteLine("Ket qua = " + (a + b).ToString("#,##0.00"));
                        break;
                    case '-': Console.WriteLine("Ket qua = " + (a - b).ToString("#,##0.00"));
                        break;
                    case '*': Console.WriteLine("Ket qua = " + (a * b).ToString("#,##0.00"));
                        break;
                    case '/': if (b != 0)
                            Console.WriteLine("Ket qua = " + (a / b).ToString("#,##0.00"));
                        else Console.WriteLine("Loi chia cho b !");
                        break;
                    case '%': if (b != 0)
                            Console.WriteLine("Ket qua = " + (a % b).ToString("#,##0.00"));
                        else Console.WriteLine("Loi chia cho b !");
                        break;
                    default: Console.WriteLine("Loi nhap phep toan");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Gia tri a,b khong hop le! ");
            }

            Console.ReadLine();
        }
    }
}
