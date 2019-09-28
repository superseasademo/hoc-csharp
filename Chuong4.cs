using System;

namespace Chuong4
{
    class PTCoThamChieu
    {
        //Phương thức có tham chiếu với từ khóa ref:

        //Hàm hoán vị với ref:
        public void hoanViRef(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        public void ThamChieuRef()
        {
            //Phải khai báo giá trị của biến trước khi dùng phương thức có ref
            int a = 1;
            int b = 2;
            
            Console.WriteLine("Truoc khi hoan vi: a = {0} - b = {1}", a , b);
            hoanViRef(ref a, ref b);
            Console.WriteLine("Sau khi hoan vi: a = {0} - b = {1}", a , b);
        }

        //Phương thức có tham chiếu với từ khóa out:

        //Hàm hoán vị với out:
        public void hoanViOut(out int a, out int b)
        {
            //Không được khai báo giá trị trước khi thực hiện out
            a = 1;
            b = 2;
            int t = a;
            a = b;
            b = t;
        }

        public void ThamChieuOut()
        {
            //Không cần khai báo giá trị của biến khi dùng phương thức out
            int a, b;
            hoanViOut(out a, out b);
            Console.WriteLine("Sau khi hoan vi: a = {0} - b = {1}", a , b);
        }
    }
}