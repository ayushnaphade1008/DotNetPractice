using System;

namespace canteen
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_bill = 0;

        Start:
            Console.WriteLine("Welcome to Coditas Canteen");
            Console.WriteLine("What will You prefer 1-Tea , 2-coffee, 3- milk");
            int user_input = int.Parse(Console.ReadLine());

            switch (user_input)
            {

                case 1:
                    
                    total_bill += 10;
                    
                    break;
                case 2:
                   
                    total_bill += 15;
                    
                    break;
                case 3:
                    
                    total_bill += 20;
                    

                    break;
                default:
                    Console.WriteLine("invalid input");
                    goto Start;
            }
        Decide:
            Console.WriteLine("Do you want to purchase anything else");
            string user_input_2 = Console.ReadLine();

            
            switch (user_input_2.ToUpper())
            {
                case "YES":
                    goto Start;

                case "NO":
                    Console.WriteLine("thanks for visiting");
                    break;
                default:
                    Console.WriteLine("You entered wrong choice");
                    goto Decide;
            }

            Console.WriteLine("total amount to be paid {0}", total_bill);
           
        }
    }
}