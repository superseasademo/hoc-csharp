using System;

namespace Chuong2
{
    class XuatDuLieu
    {
        public void xuat1()
        {
            String s = "abc";
            Console.WriteLine("s = {0}", s);
        }

        public void xuat2()
        {
            String s = "abc";
            Console.WriteLine("s = " + s);
        }
    }

    class NhapDuLieu
    {
        public void nhap()
        {
            int a;

            float b;

            string c;

            double d;

            Console.Write("Nhap so nguyen: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc float: ");
            b = Single.Parse(Console.ReadLine());

            Console.Write("Nhap chuoi: ");
            c = Console.ReadLine();

            Console.Write("Nhap so thuc double: ");
            d = Double.Parse(Console.ReadLine());

            Console.WriteLine("So nguyen: {0} - So thuc float: {1} - Chuoi: {2} - So thuc double: {3}", a, b, c, d);
        }
    }
}