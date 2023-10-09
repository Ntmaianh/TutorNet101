using System.Text;

namespace TutorCSharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // cmt ctrl + K + c 
            // mở ctrl + K + u

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            #region if - else
            // if (điều kiện) { t / m điều kiện rồi thì làm gì}
            //else if (điều kiện) { t / m đk rồi làm gì}
            // + else if luôn đứng trước else và sau if
            //else nếu không t / m tất cả điều kiện ở trên thì => nó sẽ rơi vào else { thực hiện gì } => else có thể có hoặc không
            //phân biệt khi tất cả điều kiện dùng if hết và dùng if else if else
            //if

            int a = 1;
            if (a > 0)
            {
                Console.WriteLine(" a ");
            }
            // if _ else 
            //  c1
            if (a < 1)
            {
                Console.WriteLine("a");
            }
            else if (a == 0)
            {
                Console.WriteLine("abc");
            }
            else
            {
                Console.WriteLine("Ngược lại của if");
            }
            /// Phân biệt c1 và c2 ?
            /// tình huống : giả sử biến a thỏa mãn vsới tất cả điều kiện 
            /// c1: Sẽ ktra if đầu tiên nếu if đó thỏa mãn =>
            /// thực thi code trong câu dk if đó rồi dừng luôn => sẽ không kiểm tra phía dưới nưã 
            /// c2 : sẽ kiểm tra hết tất cả cho đến khi thấy điều kiện không thỏa mãn 
            if (a < 1)
            {
                Console.WriteLine("a");
            }
            if (a == 0)
            {
                Console.WriteLine("abc");
            }
            if (a == 2)
            {
                Console.WriteLine("Ngược lại của if");
            }

            #endregion

            #region Switch - case

            // lệnh switch cho phép chúng ta so sánh 1 biến với 1 danh sách các giá trị. Mỗi giá trị tương ứng với 1 case 
            //cái truyền trong switch là gì => gtri ở case cũng là kiểu đó
            //+lệnh break : dừng lại => sẽ không so sánh tiếp với các case sau
            //+ sau mỗi 1 case phải có break => không có sẽ báo lỗi
            //+ default : trường hợp khác các trường hợp còn lại

            Console.WriteLine("Moi nhap a: ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 1:                                  //  if(a==1)
                    Console.WriteLine("a");
                    break;
                case 2:
                    Console.WriteLine("b");
                    break;
                default:
                    Console.WriteLine("a = 3");        // if (a != 1 && a! = 2) 
                    break;
            }

            // capa 1 , cap 2 , cap 3 
            Console.WriteLine("Nhap lop");
            int lop = Convert.ToInt32(Console.ReadLine());

            switch (lop)
            {
                // c1 : 
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Cap 1");
                    break;
                // c2 :   case int a when (dk )
                case int n when (n > 5 && n < 10):
                    Console.WriteLine("cap 2");
                    break;
                case int n when (n > 9 && n < 13):
                    Console.WriteLine("cap 3");
                    break;

                default:
                    break;
            }
            #endregion

            #region for 
            // for + tab 
            // for(vị trí bắt đầu , đk vòng lặp ; bước nhảy )
            // Vòng lặp vô hạn khi và chỉ khi : 1 bỏ bước nhảy ; 2 bỏ đk hoặc điều kiện luôn đúng 
            Console.WriteLine("Nhập c: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            int c = 10;

            //tính tổng các số chắn; in ra các số chẵn
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);


            #endregion

            #region While
            // while : vòng lặp 
            // while chạy khi điều kiện đúng 
            // không có bước nhảy => cũng trở thành vòng lặp vô hạn 
            // in ra các sô từ 1 - 10 
            int x = 0;
            while (x < 11)
            {
                Console.WriteLine(x);
                x++;
            }
            #endregion

            #region Do - while 
            // Do - while : chạy 1 lượt rồi nó mới check đk ;
            // do + tab 
            int m = 0;
            do
            {
                Console.WriteLine(a);
            } while (m > 1);


            #endregion
        }
    }
}