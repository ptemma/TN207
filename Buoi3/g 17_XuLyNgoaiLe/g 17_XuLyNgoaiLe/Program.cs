using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g_17_XuLyNgoaiLe
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string StrA, StrB;
            Console.WriteLine("Nhap a : ");
            StrA = Console.ReadLine(); 
            Console.WriteLine("Nhap b : ");
            StrB = Console.ReadLine();

            try
            {
                a = int.Parse(StrA);
                b = int.Parse(StrB);
                Console.WriteLine("Ket qua a/b = " + a / b);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Loi chia cho b!");

            }
            catch (Exception)
            {
                Console.WriteLine("Loi thuc thi phep toan!");

            }
            finally
            {
                Console.WriteLine("Ket thuc thuc thi");
            }
            Console.ReadLine();
        }
    }
}
