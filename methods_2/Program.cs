using System;

namespace methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int m = 0;
            int[] arr = new int[] { 1, 2, 3 };
            
            Pass_by_Value(i);
            Pass_by_Value1( ref m);
            Console.WriteLine(i);
            Console.WriteLine(m);
            Params_demo(9,18,27,36);


        }
        // by value
        public static void Pass_by_Value(int j)
        {
            j = 100;
        }
        //by ref
        public static void Pass_by_Value1(ref int k)
        {
            k = 100;
        }

        //params parameter

        public static void Params_demo(params int[] arr)
        {
            Console.WriteLine(arr.Length);
            foreach(int x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}
