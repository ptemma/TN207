using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_XuLyChuoi
{
    class Program
    {
        public static bool ContainsNumber(string name)
        {
            foreach (char c in name)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            string FName ="", MName="", LName="", FullName;
            int p1, p2;
            Console.WriteLine("xác định họ, tên lót, và tên từ chuỗi họ tên nhập trước.");
            Console.Write("Nhap ho ten : ");
            FullName = Console.ReadLine().Trim();
            
            while (FullName.Length == 0 || ContainsNumber(FullName))
            {
                Console.Write("Ho ten khong hop le, vui long nhap lai : ");
                FullName = Console.ReadLine().Trim();
            }
            p1 = FullName.IndexOf(" ");
            p2 = FullName.LastIndexOf(" ");
            if (p1 == -1)
            {
                LName = FullName;
            }
            else
            {
                FName = FullName.Substring(0, p1);
                LName = FullName.Substring(p2+1).Trim();
                if (p1 != p2)
                    MName = FullName.Substring(p1+1, p2-p1).Trim();
            }
            Console.WriteLine("Ho: " + FName);
            Console.WriteLine("Ten lot: " + MName);
            Console.WriteLine("Ten: " + LName);
            Console.WriteLine("Ho va ten: " + FullName);
            Console.ReadLine();
        }
    }
}
