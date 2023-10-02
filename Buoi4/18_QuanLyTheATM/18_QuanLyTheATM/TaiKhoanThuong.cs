using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_QuanLyTheATM
{
    class TaiKhoanThuong : TaiKhoanATM
    {
        private static float soDuToiThieu = 50;

        public TaiKhoanThuong()
            : base()
        {

        }
        public TaiKhoanThuong(int soTK, string tenTK, float soDuTK)
            : base(soTK, tenTK, soDuTK)
        {

        }
        override public  float soTienToiDa
        {
            get
            {
                return soDuTK - soDuToiThieu;
            }
        }
        public override void toString()
        {
            Console.WriteLine("Tai khoan thuong");
            base.toString();
        }
    }
}
