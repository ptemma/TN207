using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ChuyenDoiDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float fNum1;
            double dNum2;
            string strTemp;

            Console.Write("Nhap so nguyen: ");
            strTemp = Console.ReadLine();
            n = int.Parse(strTemp);
            Console.WriteLine("So nguyen vua nhap: " + n);

            Console.Write("Nhap so thuc: ");
            strTemp = Console.ReadLine();
            fNum1 = float.Parse(strTemp);
            Console.WriteLine("So thuc vua nhap: " + fNum1);
            Console.WriteLine("So thuc vua nhap: " + fNum1.ToString("#,##0.00"));

            Console.Write("Nhap so nguyen: ");
            strTemp = Console.ReadLine();
            if (int.TryParse(strTemp, out n))
                Console.WriteLine("So nguyen vua nhap: " + n);
            else
                Console.WriteLine("Nhap sai gia tri! ");

            Console.Write("Nhap so thuc: ");
            strTemp = Console.ReadLine();
            if (float.TryParse(strTemp, out fNum1))
                Console.WriteLine("So thuc vua nhap: " + fNum1.ToString("#,##0.00"));
            else
                Console.WriteLine("Nhap sai gia tri! ");

            Console.ReadLine();
        }
    }
}
