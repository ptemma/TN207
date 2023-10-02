using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ThaoTacTrenMang
{
    class Program
    {
        static void NhapMang(int[] A)
        {
            string StrTemp;
            Console.WriteLine("Nhap Mang A : ");
            for (int i=0; i<A.Length; i++)
            {
                Console.Write("nhap phan tu thu {0} : " ,(i+1));
                StrTemp= Console.ReadLine();
                while( !int.TryParse(StrTemp, out A[i]))
                {
                    Console.Write("nhap sai !nhap lai phan tu thu " + (i + 1)+ ": ");
                    StrTemp = Console.ReadLine();
                }
            }
        }

        static void InMang(int[] A)
        {
            Console.Write("Mang gom cac phan tu : ");
            foreach (int item in A)
            {
                Console.Write(item +"\t");
            }

        }
        static void Main(string[] args)
        {
            int n;
            string StrN;
            int[] arrayA;

            Console.Write("nhap so phan tu cua mang : ");
            StrN = Console.ReadLine();
            while(!int.TryParse(StrN, out n) || n<=0)
            {
                Console.Write("nhap sai! nhap lai so phan tu cua mang :");
                StrN = Console.ReadLine();
            }
            arrayA = new int[n];
            NhapMang(arrayA);
            InMang(arrayA);
            Console.ReadLine();

        }
    }
}
