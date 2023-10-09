using System.Text;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // tạo menu với 3 chức năng abc . khi chọn 0 thì thoát chương trình 
            int choose;
            //  choose = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("-----Menu-------");
                Console.WriteLine("1.Chức năng 1");
                Console.WriteLine("2.Chức năng 2");
                Console.WriteLine("3.Chức năng 3");
                Console.WriteLine("0.Thoát");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Chức năng 1");
                        break;
                    case 2:
                        Console.WriteLine("Chức năng 2");
                        break;
                    case 3:
                        Console.WriteLine("Chức năng 3");
                        break;
                    case 0:
                        Console.WriteLine("Thoát");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhap lai");
                        break;
                }

            } while (choose != 0);

            //   Console.WriteLine("a");
        }
    }
}