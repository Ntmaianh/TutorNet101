using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu_CSharp1
{
    internal class Services
    {
        List<SinhVien> _lstSinhVien = new List<SinhVien>();
        SinhVien _sinhvien;

        // Phương thức nhập 

        public void NhapThongTin()
        {
            string tieptuc;
            do
            {
                _sinhvien = new SinhVien();
                Console.WriteLine("Nhập thông tin sinh viên:");
                Console.WriteLine("Nhập mã sinh viên: ");
                _sinhvien.MaSinhVien = Console.ReadLine();
                Console.WriteLine("Nhập tên sinh viên: ");
                _sinhvien.Name = Console.ReadLine();
                Console.WriteLine("Nhập năm sinh: ");
                _sinhvien.NamSinh = Convert.ToInt32(Console.ReadLine());
                _lstSinhVien.Add(_sinhvien);
                Console.WriteLine("Bạn có muốn tiếp tục không? y/n");
                tieptuc = Console.ReadLine();
            } while (tieptuc.Equals("y"));
        }
        public void InThongTin()
        {
            if (_lstSinhVien.Count == 0)
            {
                Console.WriteLine("Danh sách trống!!");
            }
            else
            {
                foreach (var item in _lstSinhVien)
                {
                    item.InThongTin();
                }
            }
        }
        // Phương thức sinh viên có tuổi lớsn hơn 50 

        // phương thức trả về : dùng hàm để tính tuổi 
        public void DanhSachSinhVien50()
        {
            bool check = false;
            foreach (var item in _lstSinhVien)
            {
                if (DateTime.Now.Year - item.NamSinh >= 50)
                {
                    item.InThongTin();
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Khoông tìm thấy !");
            }
        }
        // tìm sinh viên theo mã 

        public void TimSinhVienTheoMa()
        {
            Console.WriteLine("Nhập mã sinh viên muốn tìm: ");
            string msv = Console.ReadLine();
            foreach (var item in _lstSinhVien)
            {
                if (item.MaSinhVien.Equals(msv))
                {
                    item.InThongTin();
                }
            }
        }
        // Kế thừa 
        public void KeThua()
        {
            SinhVienUDPM sinhVienUDPM = new SinhVienUDPM("1", "A", 2004, 10, 10);
            sinhVienUDPM.InThongTin();
        }
    }
}
