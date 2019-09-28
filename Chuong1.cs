using System;

namespace Chuong1
{
    class HelloWorld
    {
        public void helloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }

    //Tạo kiểu cấu trúc - Struct:
    class KieuCauTruc
    {
        public struct st1
        {
            public string ten;
            public int maso;
        }

        public void KCT()
        {
            st1 s;
            s.ten = "abc";
            s.maso = 123;
            Console.WriteLine("Ten: {0} - Ma so: {1}", s.ten, s.maso);
        }
    }
}