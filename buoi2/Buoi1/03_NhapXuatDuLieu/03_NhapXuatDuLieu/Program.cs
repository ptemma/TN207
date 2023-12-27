using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NhapXuatDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName, strTemp;
            char ch;
            bool blnDone = true;

            Console.Write("Ten cua ban la: ");
            strName = Console.ReadLine();
            Console.WriteLine("ten ban vua nhap "+ strName);
            Console.WriteLine("ten ban vua nhap {0}", strName);

            strName = "Nguyen Gia Linh";
            Console.WriteLine("ho ten cua ban: " + strName);

            Console.Write("Nhap Ky tu: ");
            strTemp = Console.ReadLine();
            ch = strTemp[0];
            Console.WriteLine("ky tu vua nhap: " + ch);
            ch = 'N';
            Console.WriteLine("ky tu vua gan: " + ch);

            Console.ReadLine();
        }
    }
}
