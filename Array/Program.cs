using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            
            int[] arr_1 = { 7,14,21 };
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr_1[1]);
        }
    }
}
