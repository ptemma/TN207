using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_SuDungCauTruc
{
    class Program
    {
        struct SinhVien
        {
            public String MSSV;
            public String FullName;
            public int Age;
        }
        static void Main(string[] args)
        {
            SinhVien Student;
            string StrTuoi;

            Console.Write("Nhap MSSV : ");
            Student.MSSV = Console.ReadLine();
            Console.Write("Nhap ten sinh vien : ");
            Student.FullName = Console.ReadLine();
            Console.Write("Nhap tuoi sinh vien : ");
            StrTuoi = Console.ReadLine();
            while (!int.TryParse(StrTuoi, out Student.Age) || Student.Age <16 )
            {
                Console.Write("Tuoi khong hop le! Vui long nhap lai : ");
                StrTuoi = Console.ReadLine();
            }
            Console.WriteLine("Thong tin sinh vien vua nhap");
            Console.WriteLine("Ho ten sinh vien : " + Student.FullName + "\t");
            Console.Write("MSSV nhap tu ban phim : " + Student.MSSV + "\t");
            Student.MSSV = "B1234567";
            Console.WriteLine("MSSV sau khi gan : " + Student.MSSV + "\t");
            Console.Write("Tuoi sinh vien : " + Student.Age + "\t");

            Console.ReadLine();
        }
    }
}
