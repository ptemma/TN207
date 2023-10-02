using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_TinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            string strN;
            int i =3,n, sum=0;
            Console.WriteLine("chương trình nhập vào số nguyên dương n "
                +"và tính tổng các số nguyên chia hết cho 3 trong khoảng từ 1 tới n ");
            Console.Write("Nhap n = ");
            strN = Console.ReadLine();
            if(int.TryParse(strN, out n) && n>0)
            {
                while (i<=n) 
                {
                    if(i%3==0)
                        sum =sum+i;
                    i+=3;
                }
                Console.WriteLine("ket qua = " + sum);
            }
            else
                Console.WriteLine("Loi nhap gia tri n!");
            Console.ReadLine();

            
        }
    }
}
