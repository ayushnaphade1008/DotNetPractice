using System;

namespace while_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int start_num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter last number");
            int end_num = int.Parse(Console.ReadLine());

            // using while loop
            while (start_num <= end_num)
            {
                Console.Write(start_num + " ");
                start_num += 1;
            }  
            

            //using do while loop

            do
            {
                Console.Write(start_num + " ");
                start_num += 1;
            }
            while (start_num <= end_num); 
        }
    }
}
