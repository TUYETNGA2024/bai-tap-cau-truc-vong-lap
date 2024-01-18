using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_cau_truc_vong_lap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                Console.Write("1. Bài 1. Chương trình nhập số nguyên và kiểm tra xem số đó có chia hết cho 3 hay không\n\n" +
               "2. Bài 2. Chương trình Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 2 đến n ra màn hình\n\n" +
               "3. Bài 3.Chương trình Nhập vào số nguyên dương n, Tính tổng giai thừa từ 1 đến n và in ra màn hình\n\n" +
               "4. Bài 4. Chương trình Nhập vào số nguyên dương n, Kiểm tra xem n có phải là số chính phương và in ra màn hình\n\n" +
               "5. Bài 5. Chương trình cho biết số ngày trong tháng\n\n" +
               "6. Bài 6. Chương trình nhập vào số nguyên dương n, tính tổng S theo công thức sau 1+2^2+3^3+...n^n và hiển thị kquả ra màn hình\n\n" +
               "7. Bài 7. Chương trình nhập vào số nguyên dương n, tính tổng số lẻ từ 1 đến n và hiển thị kết quả ra màn hình\n\n" +
               "8. Bài 8. Nhập vào số nguyên dương n, Kiểm tra đó có phải là số nguyên tố hay không?\n\n" +
               "9. Bài 9. Chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng\n\n" +
               "10. Bài 10. Chương trình Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình\n");
            
            Console.Write("\nMời bạn gõ số thứ tự bài tập: ");
            int stt = int.Parse(Console.ReadLine());
            switch (stt)
            {
                case 1:
                    bai_1();
                    break;
                case 2:
                    bai_2();
                    break;
                case 3:
                    bai_3();
                    break;
                case 4:
                    bai_4();
                    break;
                case 5:
                    bai_5();
                    break;
                case 6:
                    bai_6();
                    break;
                case 7:
                    bai_7();
                    break;
                case 8:
                    bai_8();
                    break;
                case 9:
                    bai_9();
                    break;
                case 10:
                    bai_10();
                    break;
            }
                bool stop = ThoatChuongTrinh();
                if (stop)
                break;


            Console.ReadKey();
        }

        }
        //Dừng hay đi tiếp
        public static bool ThoatChuongTrinh()
        {    
            Console.WriteLine("Nhấn 2 lần phím bất kỳ để tiếp tục :)");
            Console.WriteLine("Nhấn ESC. để thoát chương trình");
            ConsoleKeyInfo str = Console.ReadKey();
            if (str.Key == ConsoleKey.Escape)
               
            return true;
            
                return false;
        }
        //BÀI 1
        public static void bai_1()
        {
            Console.WriteLine("Bài 1. Chương trình nhập số nguyên và kiểm tra xem số đó có chia hết cho 3 hay không");
            Console.Write("Nhập số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 3 == 0)
            {
                Console.WriteLine("Số {0} chia hết cho 3", n);
                int n1 = n / 3;
                Console.WriteLine("Kết quả {0}/3 = {1}", n, n1);
            }
            else
            {
                Console.WriteLine("Số {0} không chia hết cho 3", n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        //BÀI 2
        public static void bai_2()
        {
            Console.WriteLine("Bài 2. Chương trình Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 2 đến n ra màn hình ");
            Console.Write("Nhập 1 số nguyên dương trong khoảng từ 2 đến 10: ");
            int m3 = int.Parse(Console.ReadLine());
            if (m3 >= 2 && m3 <= 10)
            {
                for (int m = 2; m <= m3; m++)
                {
                    for (int m1 = 1; m1 <= 10; m1++)
                    { Console.WriteLine("{0} x {1} = {2}", m, m1, m * m1); }
                }
            }
            else
            { Console.WriteLine("Số vừa nhập không thỏa điều kiện"); }
            Console.WriteLine();
            Console.WriteLine();
        }
        ////BÀI 3
        public static void bai_3()
        {
            Console.WriteLine("Bài 3. Chương trình Nhập vào số nguyên dương n, Tính tổng giai thừa từ 1 đến n và in ra màn hình ");
            Console.Write("Nhập số nguyên dương: ");
            int p = int.Parse(Console.ReadLine());
            int tonggiaithua = 0;
            int giaithua = 1;
            if (p > 0)
            {
                for (int dem = 1; dem <= p; dem++)
                {
                    giaithua = giaithua * dem;
                    tonggiaithua = tonggiaithua + giaithua;
                }
                Console.WriteLine("Giai thừa {0}!= {1}", p, giaithua);
                Console.WriteLine("Tổng giai thừa từ 1! đến {0}! là: {1}", p, tonggiaithua);
            }
            else
            {
                Console.WriteLine("Số vừa nhập không thỏa điều kiện");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        //BÀI 4
        public static void bai_4()
        {
            Console.WriteLine("Bài 4. Chương trình Nhập vào số nguyên dương n, Kiểm tra xem n có phải là số chính phương và in ra màn hình ");
            Console.Write("Nhập số nguyên: ");
            int q = int.Parse(Console.ReadLine());
            int sqr = (int)Math.Sqrt(q);
            if (sqr * sqr == q)
            {
                Console.WriteLine("Số {0} là số chính phương", q);
            }
            else
            { Console.WriteLine("Số {0} không phải là số CP hoặc không thỏa điều kiện nhập", q); };
            Console.WriteLine();
            Console.WriteLine();
        }
        //BÀI 5
        public static void bai_5()
        {
            Console.WriteLine("Bài 5. Chương trình cho biết số ngày trong tháng");
            Console.Write("Nhập tháng: ");
            int thang = int.Parse(Console.ReadLine());
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("Tháng {0} có 31 ngày", thang);
                    break;
                case 2:
                    Console.Write("Tháng {0} có 28 hoặc 29 ngày", thang);
                    break;
                default:
                    Console.Write("Tháng {0} có 30 ngày", thang);
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        
        //BÀI 6
        public static void bai_6()
        {
            Console.WriteLine("Bài 6. Chương trình nhập vào số nguyên dương n, tính tổng S theo công thức sau 1+2^2+3^3+...n^n và hiển thị kết quả ra màn hình");
            Console.Write("Nhập số n: ");
            int r = int.Parse(Console.ReadLine());
            int ketqua = 0;
            int luythua = 0;
            if (r > 0)
            {
                for (int i = 0; i <= r; i++)
                {
                    luythua = i * i;
                    ketqua = ketqua + luythua;
                }
                Console.WriteLine("Tổng của các lũy thừa 1^1+...+{0}^{1}= {2}", r, r, ketqua);
            }
            else
            {
                Console.WriteLine("Số nhập vào không thỏa điều kiện");
            }
        }
        //BÀI 7
        public static void bai_7()
        {
            Console.WriteLine("Bài 7. Chương trình nhập vào số nguyên dương n, tính tổng số lẻ từ 1 đến n và hiển thị kết quả ra màn hình");
            Console.Write("Nhập số n: ");
            int s = int.Parse(Console.ReadLine());
            int cong = 0;
            if (s > 0)
            {
                for (int i = 1; i <= s; i = i + 2)
                {
                    cong = cong + i;
                }
                Console.WriteLine("Tổng số lẻ từ 1 đến {0}= {1}", s, cong);
            }
            else

            {
                Console.WriteLine("Số nhập vào ko thỏa điều kiện");
            }
        }
        //BÀI 8
        public static void bai_8()
        {
            Console.WriteLine("Bài 8. Nhập vào số nguyên dương n, Kiểm tra đó có phải là số nguyên tố hay không?");
            Console.Write("Nhập số nguyên dương n > = 2: ");
            int t = int.Parse(Console.ReadLine());
            int dem = 0;
            if (t < 2)
            {
                Console.WriteLine("Số vừa nhập không thỏa điều kiện");
            }
            for (int i = 2; i <= Math.Sqrt(t); i++)
            {
                if (t % i == 0)
                {
                    dem = dem + 1;
                    Console.WriteLine("Số vừa nhập không phải là SNT");
                    break;
                }
            }
            if (dem == 0 && t != 1)
            {
                Console.WriteLine("Số vừa nhập là số nguyên tố");
            }
        }
        //BÀI 9
        public static void bai_9()
        {
            Console.WriteLine("Bài 9. Chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng");
            Console.Write("Nhập số nguyên dương: ");
            int s = int.Parse(Console.ReadLine());
            string sao = "";
            for (int i = 1; i <= s; i++)
            {
                sao += "*";
                Console.WriteLine(sao);
            }
        }

        //BÀI 10
        public static void bai_10()
        { 
        Console.WriteLine("Bài 10.Chương trình Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình");
        Console.Write("Nhập số lượng phần tử: ");
        int s2 = int.Parse(Console.ReadLine());
        double f0 = 0;
        double f1 = 1;
        double s3;
        if (s2< 0)
        {
        Console.WriteLine("Số vừa nhập không hợp lệ");
        }
        else if (s2==1)
        {
         Console.WriteLine("Dãy Fibonacci là {0}", f0);
         }
        else if (s2 == 2)
        {
        Console.WriteLine("Dãy Fibonacci là {0} {1}", f0, f1);
        }
        else
        {
        Console.Write("Dãy Fibonacci là {0} {1}", f0, f1);
            for (int i = 2; i < s2; i++)
                {
                    s3 = f1 + f0;
                    Console.Write("  {0}\n", s3);
                    f0 = f1;
                    f1 = s3;
                }
        }
        }

    }
}