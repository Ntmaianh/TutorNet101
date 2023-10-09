using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu_CSharp1
{
    internal class SinhVienUDPM : SinhVien
    {
        private double diemJaVa;
        private double diemCSharp;

        public double DiemJaVa { get => diemJaVa; set => diemJaVa = value; }
        public double DiemCSharp { get => diemCSharp; set => diemCSharp = value; }

        // có cũng được. khônog có cũng không sao
        public SinhVienUDPM()
        {
        }

        public SinhVienUDPM(string maSinhVien, string name, int namSinh, double diemJaVa, double diemCSharp) : base(maSinhVien, name, namSinh)
        {
            DiemJaVa = diemJaVa;
            DiemCSharp = diemCSharp;
        }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Điểm Java {diemJaVa} | Điểm CSharp {diemCSharp} ");
        }
    }
}
