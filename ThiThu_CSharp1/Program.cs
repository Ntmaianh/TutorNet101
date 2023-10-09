using System.Text;

namespace ThiThu_CSharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Menu();
        }
        static void Menu()
        {
            int choose;
            Services services = new Services();
            do
            {
                Console.WriteLine("------Menu-------");
                Console.WriteLine("1.Nhập thông tin");
                Console.WriteLine("2.Xuất thông tin");
                Console.WriteLine("3.Danh sách sinh viên tuổi lớn hơn 50");
                Console.WriteLine("4.Tìm kiếm theo mã sinh viên");
                Console.WriteLine("5.Kế thừa");
                Console.WriteLine("0.Thoáat");
                Console.WriteLine("Mời bạn lựa chọn: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        services.NhapThongTin();
                        break;
                    case 2:
                        services.InThongTin();
                        break;
                    case 3:
                        services.DanhSachSinhVien50();
                        break;
                    case 4:
                        services.TimSinhVienTheoMa();
                        break;
                    case 5:
                        services.KeThua();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (choose != 0);
        }
    }
}