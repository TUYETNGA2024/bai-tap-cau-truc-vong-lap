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

        public static void bai9()
        {
            Console.WriteLine("*");
        }
        static void Main(string[] args)
        

        {
            Console.OutputEncoding = Encoding.UTF8;
            { //BÀI 1
            //Console.WriteLine("Bài 1. Chương trình nhập số nguyên và kiểm tra xem số đó có chia hết cho 3 hay không");
            //Console.Write("Nhập số nguyên: ");
            //int n = int.Parse(Console.ReadLine());
            //if (n % 3 == 0) 
            //{ 
            //    Console.WriteLine("Số {0} chia hết cho 3", n); 
            //    int n1 = n/3;
            //    Console.WriteLine("Kết quả {0}/3 = {1}", n, n1);
            //}
            //else
            //{ Console.WriteLine("Số {0} không chia hết cho 3", n);
            //};
            //Console.WriteLine();
            //Console.WriteLine();

            ////BÀI 2
            //Console.WriteLine("Bài 2. Chương trình Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 2 đến n ra màn hình ");
            //Console.Write("Nhập 1 số nguyên dương trong khoảng từ 2 đến 10: ");
            //int m3 = int.Parse(Console.ReadLine());
            //if (m3 >= 2 && m3 <=10)
            //{
            //    for (int m = 2; m <= m3; m++)
            //    {
            //        for (int m1 = 1; m1 <= 10; m1++)
            //        {Console.WriteLine("{0} x {1} = {2}", m, m1, m * m1);}
            //    }
            //}
            //else
            //{ Console.WriteLine("Số vừa nhập không thỏa điều kiện"); }
            //Console.WriteLine();
            //Console.WriteLine();

            ////BÀI 3
            //Console.WriteLine("Bài 3. Chương trình Nhập vào số nguyên dương n, Tính tổng giai thừa từ 1 đến n và in ra màn hình ");
            //Console.Write("Nhập số nguyên dương: ");
            //int p = int.Parse(Console.ReadLine());
            //int tonggiaithua = 0;
            //int giaithua = 1;
            //if (p > 0)
            //{
            //    for (int dem = 1; dem <= p; dem++)
            //    {
            //       giaithua = giaithua * dem;
            //       tonggiaithua = tonggiaithua + giaithua;
            //    }
            //    Console.WriteLine("Giai thừa {0}!= {1}", p, giaithua);
            //    Console.WriteLine("Tổng giai thừa từ 1! đến {0}! là: {1}", p, tonggiaithua);
            //}
            //else
            //{
            //    Console.WriteLine("Số vừa nhập không thỏa điều kiện");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //BÀI 4
            //Console.WriteLine("Bài 4. Chương trình Nhập vào số nguyên dương n, Kiểm tra xem n có phải là số chính phương và in ra màn hình ");
            //Console.Write("Nhập số nguyên: ");
            //int q = int.Parse(Console.ReadLine());
            //int sqr = (int)Math.Sqrt(q);
            //if (sqr * sqr ==q)
            //{
            //    Console.WriteLine("Số {0} là số chính phương", q);
            //}
            //else
            //{ Console.WriteLine("Số {0} không phải là số CP hoặc không thỏa điều kiện nhập", q); };
            //Console.WriteLine();
            //Console.WriteLine();

            //BÀI 5
            //Console.WriteLine("Bài 5. Chương trình cho biết số ngày trong tháng");
            //Console.Write("Nhập tháng: ");
            //int thang = int.Parse(Console.ReadLine());
            //switch (thang)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.Write("Tháng {0} có 31 ngày", thang);
            //        break;
            //    case 2:
            //        Console.Write("Tháng {0} có 28 hoặc 29 ngày", thang);
            //        break;
            //    default:
            //        Console.Write("Tháng {0} có 30 ngày", thang);
            //        break;
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //BÀI 6
            //Console.WriteLine("Bài 6. Chương trình nhập vào số nguyên dương n, tính tổng S theo công thức sau 1+2^2+3^3+...n^n và hiển thị kết quả ra màn hình");
            //Console.Write("Nhập số n: ");
            //int r = int.Parse(Console.ReadLine());
            //int ketqua = 0;
            //int luythua = 0;
            //if (r > 0)
            //{
            //    for (int i = 0; i <= r; i++)
            //    {
            //        luythua = i * i;
            //        ketqua = ketqua + luythua;
            //    }
            //    Console.WriteLine("Tổng của các lũy thừa 1^1+...+{0}^{1}= {2}", r, r, ketqua);
            //}
            //else
            //{
            //    Console.WriteLine("Số nhập vào không thỏa điều kiện");
            //}
            
            }
            //BÀI 7
            //Console.WriteLine("Bài 7. Chương trình nhập vào số nguyên dương n, tính tổng số lẻ từ 1 đến n và hiển thị kết quả ra màn hình");
            //Console.Write("Nhập số n: ");
            //int s = int.Parse(Console.ReadLine());
            //int cong = 0;
            //if (s > 0)
            //{
            //        for (int i = 1; i <= s; i = i + 2)
            //        {
            //            cong = cong + i;
            //        }
            //    Console.WriteLine("Tổng số lẻ từ 1 đến {0}= {1}", s, cong);
            //}
            //else

            //{
            //    Console.WriteLine("Số nhập vào ko thỏa điều kiện");
            //}

            //BÀI 8
            //Console.WriteLine("Bài 8. Nhập vào số nguyên dương n, Kiểm tra đó có phải là số nguyên tố hay không?");
            //Console.Write("Nhập số nguyên dương n > = 2: ");
            //int t = int.Parse(Console.ReadLine());
            //int dem = 0;
            //if (t < 2)
            //{
            //    Console.WriteLine("Số vừa nhập không thỏa điều kiện");
            //}
            //for (int i = 2; i <= Math.Sqrt(t); i++)
            //{
            //    if (t % i == 0)
            //    {
            //        dem = dem + 1;
            //        Console.WriteLine("Số vừa nhập không phải là SNT");
            //        break;
            //    }
            //}
            //if(dem==0 && t!= 1)
            //{
            //Console.WriteLine("Số vừa nhập là số nguyên tố");
            //}
            //BÀI 9
            Console.WriteLine("Bài 9. Chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng");
            Console.Write("Nhập số nguyên dương: ");
            int s = int.Parse(Console.ReadLine());
            int dem_sao = 1;
            for(int i = 1; i <= s; i++) 
            {
               bai9(); 
                for(int j = 1; j <i ; j++)
                { Console.Write("\t"); }
                                
            }




            //Console.Write("\n");
            //Console.Write("Kiem tra so nguyen to trong C#:\n");
            //Console.Write("----------------------------");
            //Console.Write("\n\n");

            //int number;
            //int bien_dem = 0;

            //Console.Write("Nhap mot so bat ky: ");
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //    if (number % i == 0)
            //        bien_dem++;

            //if (bien_dem == 2)
            //    Console.WriteLine("So da cho la so nguyen to.");
            //else
            //    Console.WriteLine("So da cho khong phai la so nguyen to.");

            //Console.ReadKey();








            //hien thi cac so tu 1 den 1000;

            //int a = 5;
            ////int b = a++;

            //int b = ++a;

            //Console.WriteLine(b);
            //Console.WriteLine(a);
            //tinh tong cac so chia het cho 5 hoac chia het cho 7???
            //int tong = 0;
            //for (int i = 1; i <= 100; i = i + 2)
            //{
            //    if (i % 5 == 0 || i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //        tong += i;
            //    }
            //    //tong = tong + i;
            //}
            //Console.WriteLine("Tong day so chan la {0}", tong);


            //Yc: nhap vao thang bat ky, hien thi so ngay trong thang vua nhap.
            //thang 2: 28 29 ngay
            //thang 4 6 9 12: 30 ngay
            //thang 1 3 5 7 8 11: 31 ngay
            //int thang = 2;

            //if (thang == 2) Console.Write("Co 28 hoac 29 ngay");
            //if (thang == 4 || thang == 6 || thang == 9 || thang == 12) Console.Write("Co 30 ngay");
            //if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 11) Console.Write("Co 31 ngay");
            //Console.Write("Moi nhap so nguyen n = ");
            //int n = int.Parse(Console.ReadLine());

            //switch (n)
            //{
            //    case 3:
            //    //Console.Write("Hinh tam giac");
            //    //break;
            //    case 4:
            //        Console.Write("Hinh tu giac");
            //        break;
            //    default:
            //        Console.Write("Gia tri khong hop le");
            //        break;
            //}
            //if (n == 3) Console.Write("Hinh tam giac");
            //if (n == 4) Console.Write("Hinh tu giac");
            //if (n == 3 || n == 4) Console.Write("Hinh tu giac");


            //dieu kien if loai 1
            //dieu kien la n >= 0
            //if (n >= 0)
            //{ //danh dau bat dau khoi lenh
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //} //danh dau ket thuc khoi lenh
            //if (n >= 0) Console.WriteLine("Gia tri vua nhap vao lon hon 0"); 

            //Console.WriteLine("Gia tri vua nhap vao lon hon 0");

            //dieu kien if loai 2 hay if day du
            //DK1: n >= 0
            //DK2: n chia het cho 2 hay khong? 4 % 2 = 0
            //if (n >= 0 && n % 2 == 0)
            //{
            //    if (n % 2 == 0) //DK chia het cho 2
            //    {
            //        Console.WriteLine("Gia tri vua nhap vao lon hon 0 va chia het cho 2");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Gia tri vua nhap vao lon hon 0 va khong chia het cho 2");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Gia tri vua nhap vao nho hon 0");
            //}
            //int a = 10;
            //int b = 20;
            //int c = --a + b--; // --a = a = a - 1, b-- = b = b - 1
            //////chuyen if loai 2 ve if loai 1
            //string noidung = "Gia tri vua nhap vao lon hon 0";
            //if (n < 0) noidung = "Gia tri vua nhap vao nho hon 0";
            //Console.WriteLine(noidung);

            //Console.WriteLine( n >= 0 ? "Gia tri vua nhap vao lon hon 0" : "Gia tri vua nhap vao nho hon 0");
            //Console.WriteLine(noidung ?? "Gia tri vua nhap vao lon hon 0");

            //if(noidung is null)
            //{
            //    noidung = "Gia tri vua nhap vao lon hon 0";
            //}
            //else
            //{
            //    noidung = noidung;
            //}

            Console.ReadKey();
            }
        }

    }

 
