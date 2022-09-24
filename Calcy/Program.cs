using System;
class Calcy
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("OPERATION:ADD/SUB/MUL/DIV");
        string str = Console.ReadLine().ToUpper();
        Console.WriteLine("ENTER FIRST NUMBER");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("ENTER SECOND NUMBER");
        int n = int.Parse(Console.ReadLine());

        Cal(m, n, str);
    }
    public static void Cal(int a, int b, string c)
    {
        if(c == "ADD" & a>0 & b > 0)
       {
            int sum = a + b;
            Console.WriteLine("sum is {0}",sum);
        }
        else if (c == "SUB" & a>0 & b > 0)
       {
            int sub = a - b;
            Console.WriteLine("sub is {0}", sub);
        }
        else if (c == "MUL" & a > 0 & b > 0 & a > b)
       {
            int mul = a * b;
            Console.WriteLine("mul is {0}",mul);
        }
       else if (c == "DIV" & a>0 & b > 0)
       {
            double div = (double) a / b;
            Console.WriteLine("Div is {0}", div);
        }
       else
        {
         Console.WriteLine("Invalid Input");
        }
    }
}