using System;

namespace for_foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int i;
            int j = 0;
            
            //using for loop

            for ( i = 0; i < arr.Length; i++)
            {
                Console.WriteLine (arr[i]);
                
            }

            //using while loop
            while (j < arr.Length)
            {
                Console.WriteLine(arr[j]);
                j++;
            }
            Console.WriteLine(".................LENGTH................");
            Console.WriteLine("length of arr: " + arr.Length);

            //foreach loop

            foreach(int k in arr)
            {
                Console.WriteLine(k);
            }

            // implementation of Continue
            for (int m = 2; m <= 20; m++)
            {
                if (m % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(m);
            }

            //implementation of Break
            for(int n=0; n<=10; n++)
            {
                if (n == 5)
                {
                    break;
                }
                Console.WriteLine(n);
            }
        }
    }
}
