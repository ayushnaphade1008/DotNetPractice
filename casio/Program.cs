using System;

namespace casio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number");
            int num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            int num_2 = int.Parse(Console.ReadLine());

            int add_1= Add(num_1, num_2);
            Console.WriteLine("result of Addition is {0}",add_1);
            int sub_1 = Sub(num_1, num_2);
            Console.WriteLine("result of subraction is {0}", sub_1);
            int mul_1 = Mul(num_1, num_2);
            Console.WriteLine("result of Mul is {0}", mul_1);
            int div_1 = Div(num_1, num_2);
            Console.WriteLine("result of Div {0}", div_1);
        }
        static int Add(int x, int y)
        {
            int z = 0;
            if (x <= 0 || y <= 0)
            {
                z = 0;
            }
            else
            {
                z = x + y;
            }
        
            return z;
        }
        static int Sub(int x, int y)
        {
            int z = 0;
            if (x <= 0 || y <= 0)
            {
                z = 0;
            }
            else
            {
                z = x - y;
            }
           
            return z;
        }
        static int Mul(int x, int y)
        {
            int z = 0;
            if (x <= 0 || y <= 0)
            {
                z = 0;
            }
            else
            {
                z = x * y;
            }
            
            return z;
        }
        static int Div(int x, int y)
        {
          int z = 0;
           if (x <= 0 || y <= 0)
           {
            z = 0;
           }
           else
           {
           z = x / y;
           }
           return z;
        }
                
            
        
    }
}
