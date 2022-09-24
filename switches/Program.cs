using System;

namespace switches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Lucky Number");
            int lucky_num = int.Parse(Console.ReadLine());

            /*switch (lucky_num)
            {

                case 1:
                    Console.WriteLine("Your Lucky Number is {0}", lucky_num);
                    break;
                case 2:
                    Console.WriteLine("Your Lucky Number is {0}", lucky_num);
                    break;
                case 3:
                    Console.WriteLine("Your Lucky Number is {0}", lucky_num);
                    break;
                case 4:
                    Console.WriteLine("Your Lucky Number is {0}", lucky_num);
                    break;
                case 5:
                    Console.WriteLine("Your Lucky Number is {0}", lucky_num);
                    break;
                default:
                    Console.WriteLine("Entered Wrong number");
                    break;


            } */

            switch (lucky_num)
            {

                case 1:
                    
                case 2:
                    
                case 3:
                    
                case 4:
                    
                case 5:
                    Console.WriteLine("Your Lucky Number is {0}", lucky_num);
                    break;
                default:
                    Console.WriteLine("Entered Wrong number");
                    break;


            }



        }
    }
}
