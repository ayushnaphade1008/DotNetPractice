using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the percentage:");
            int percentage = int.Parse(Console.ReadLine());
            if (percentage >= 70)
            {
                Console.WriteLine("passed in first Division");
            }
            else if (percentage <=70 && percentage >= 35)
            {
                Console.WriteLine("passed in  Second Division");
            }
            else {
                Console.WriteLine("Failed");
            }
        }
    }
}
