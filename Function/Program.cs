using System.Text;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            // phân biệt qua parameter
            // TinhTuoi();
            //TinhTuoi(2003);
            Tong();
            Console.WriteLine(Tong(2, 3));
        }
        static void TinhTuoi()
        {
            Console.WriteLine("Mời nhập năm sinh ");
            int namSinh = Convert.ToInt32(Console.ReadLine());
            int tuoi = DateTime.Now.Year - namSinh;
            Console.WriteLine(tuoi);

        }
        static void TinhTuoi(int namSinh)
        {
            int tuoi = DateTime.Now.Year - namSinh;
            Console.WriteLine(tuoi);
        }
        // Hàm có giá trị trả về 

        // vi dụ : tính tổng giá trị của a và b 

        // note : khai báo hàm bằng kiểu dữ liệu nfào => return về đúng kiểu dữ liệu đấy 
        static int Tong()
        {
            Console.WriteLine("Nhập a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int tong = a + b;
            Console.WriteLine(tong);
            return tong;
        }
        static int Tong(int a, int b)
        {
            int tong = a + b;
            return tong;
        }
    }
}