using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_QuanLyTheATM
{
    class TaiKhoanVip :TaiKhoanATM
    {
        private float soDuToiThieu= -100;
        public TaiKhoanVip()
            : base()
        {
        }
        public TaiKhoanVip(int soTK, string tenTK, float soDuTK)
            : base(soTK, tenTK, soDuTK)
        {
        }
        override public float soTienToiDa
        {
            get
            {
                return soDuTK - soDuToiThieu;
            }
        }
        public override void toString()
        {
            Console.WriteLine("Tai khoan VIP");
            base.toString();
        } 
    }
}
