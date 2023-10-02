using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_QuanLyTheATM
{
    class TaiKhoanATM
    {
        private int intSoTK;
        private string stringTenTK;
        private float floatSoDuTK;

        
        public TaiKhoanATM()
        {
            intSoTK = 0;
            stringTenTK = "";
            floatSoDuTK = 0;
        }
        public TaiKhoanATM(int soTK, string tenTK, float soDuTK)
        {
            intSoTK = soTK;
            stringTenTK = tenTK;
            floatSoDuTK = soDuTK;
        }

        public int SoTK
        {
            get { return intSoTK; }
            set { intSoTK = value; }
        }
        public string TenTK
        {
            get { return stringTenTK; }
            set { stringTenTK = value; }
        }
        public float soDuTK
        {
            get { return floatSoDuTK; }
            set { floatSoDuTK = value; }
        }

        virtual public float soTienToiDa
        {
            get
            {
                return soDuTK;
            }
        }

        public void guiTien(float st)
        {
            Console.WriteLine("tai khoan " + SoTK + " muon gui so tien " + st.ToString("$ #,##0.00"));
            if (st > 0)
            {
                floatSoDuTK += st;
            }
            else
            {
                Console.WriteLine("so tien khong hop le !");
            }
            Console.WriteLine("----- Sau khi thuc hien giao dich----- ");
            this.toString();
        }
        public void rutTien(float st)
        {
            Console.WriteLine("tai khoan " + SoTK + " muon rut so tien " + st.ToString("$ #,##0.00"));
            if ((st > 0) && (soTienToiDa >= st))
            {
                soDuTK -= st;
            }
            else
            {
                Console.WriteLine("so tien rut nhieu hon so tien trong tai khoan !\n");
            }
            Console.WriteLine("----- Sau khi thuc hien giao dich----- ");
            this.toString();
        }
        public void chuyenKhoan(TaiKhoanATM TK, float st)
        {
            Console.WriteLine("Tai khoan " + this.SoTK + " chuyen cho tai khoan " + TK.SoTK + " so tien " + st.ToString("$ #,##0.00"));
            if (this.SoTK != TK.SoTK)
            {
                if (st > 0 && soTienToiDa >= st)
                {
                    TK.soDuTK += st;
                    soDuTK -= st;
                }
                else
                {
                    Console.WriteLine("loi nhap so tien khong hop le hoac so du khong du !");
                }
            }
            else
            {
                Console.WriteLine("tai khoan nhan tien khong hop le !");
            }
            Console.WriteLine("----- Sau khi thuc hien giao dich----- ");
            this.toString();
            
        }
        virtual public void toString()
        {
            Console.WriteLine("----- Thong tin tai khoan----- ");
            Console.WriteLine("Ma tai khoan : " + SoTK);
            Console.WriteLine("Ten tai khoan : " + TenTK);
            Console.WriteLine("So du tai khoan : " + soDuTK.ToString("$ #,##0.00") + "\n");
                
        }
    }
}
