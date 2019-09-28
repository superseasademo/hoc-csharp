using System;

namespace Chuong3
{
    //Vòng lặp ForEach
    class VLForEach
    {
        public void VLFE()
        {
            int[] arr = new int[5]{1, 2, 3, 4, 5};

            foreach(int i in arr)
            {
                Console.WriteLine(i + "\t");
            }
        }
    }
}