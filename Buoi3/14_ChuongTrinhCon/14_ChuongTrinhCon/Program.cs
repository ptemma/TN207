using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ChuongTrinhCon
{
    class Program
    {
        static void Swap1(int a, int b)
        {   //chi dung trong chinh ham Swap1 =>sai
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Chuong trinh con Swap1 : a = {0} & b = {1}", a, b);
        }
        static void Swap2(ref int a,ref int b)
        {   //dung
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Chuong trinh con Swap2 : a = {0} & b = {1}", a, b);
        }

        static void Main(string[] args)
        {
            int a = 5, b = 7;
            Console.WriteLine("Gia tri ban dau : a = {0} & b = {1}", a, b);
            Swap1(a, b);
            Console.WriteLine("Sau khi hoan doi (Swap1) : a = {0} & b = {1}", a, b);
            Console.WriteLine("Gia tri ban dau : a = {0} & b = {1}", a, b);
            Swap2(ref a,ref b);
            Console.WriteLine("Sau khi hoan doi (Swap2) : a = {0} & b = {1}", a, b);
            Console.ReadLine();
        }
    }
}
