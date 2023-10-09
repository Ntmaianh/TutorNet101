using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu_CSharp1
{
    internal class SinhVien
    {
        private string maSinhVien;
        private string name;
        private int namSinh;

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string Name { get => name; set => name = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }

        public SinhVien()
        {
        }
        public SinhVien(string maSinhVien, string name, int namSinh)
        {
            MaSinhVien = maSinhVien;
            Name = name;
            this.namSinh = namSinh;
        }
        public virtual void InThongTin()
        {
            Console.WriteLine($"MaSinhVien {MaSinhVien} | Name {Name} | NamSinh {namSinh}");
        }

    }
}
