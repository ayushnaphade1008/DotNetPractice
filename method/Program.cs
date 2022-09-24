using System;
//method and method overriding
namespace method
{
    class Program
    {
        static void Main(string[] args)
        {

            Program.odd_Num_1(50);

            //as  class is not static so we have create a object of class Program
            Program pro = new Program();

            pro.odd_Num_1();



        }
        // static class
        public static void odd_Num_1(int m)
        {
            int n = 1;
            while (n <= m)
            {
                Console.WriteLine(n);
                n += 2;

            }
        }
        // non static class
        void odd_Num_1()
        {
                int m = 1;
                while (m <= 10)
                {
                    Console.WriteLine(m);
                    m += 2;

                }



            
        }
    }
}
