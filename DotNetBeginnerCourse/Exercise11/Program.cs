// See https://aka.ms/new-console-template for more information
Console.WriteLine("Excercise 11");
//1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
//Display the count on the console.
int count = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        count++;

    }
}
Console.WriteLine($"Count is {count}");



//Write a program and continuously ask the user to enter a number or "ok" to exit.
//Calculate the sum of all the previously entered numbers and display it on the console.
int sum = 0;
String str =String.Empty;
do
{
    Console.WriteLine("ENTER THE NUMBER");
     str= Console.ReadLine();
    
    if (!str.Equals("ok"))
    {
        int number = Convert.ToInt32(str);
        sum += number;


    }
    else
    {
        break;
    }
   
    
}
while (true);
Console.WriteLine($"Sum of Entered Number is {sum} ");

//3 - Write a program and ask the user to enter a number.
//Compute the factorial of the number and print it on the console.
//For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

Console.WriteLine("Enter Number");
int num = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= num; i++)
{
    factorial *= i;

}
Console.WriteLine($"{num}!  = {factorial}");



//4 - Write a program that picks a random number between 1 and 10.
//Give the user 4 chances to guess the number. If the user guesses the number,
//display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly,
//you can display the secret number on the console first.)
var random = new Random();
var randNumber = random.Next(1, 10);
Console.WriteLine($"RANDPM NUMBER={randNumber}");
int chance = 0;
while (chance < 4)
{
    Console.WriteLine("Guess the Number");
    int guessedNo = Convert.ToInt32(Console.ReadLine());
    if (randNumber == guessedNo)
    {
        Console.WriteLine("YOU WON");
        break;
    }
    else if (randNumber != guessedNo && chance == 3)
    {
        Console.WriteLine("YOU LOST");
        break;
    }
    else
    {
        chance++;
    }

}




//5 - Write a program and ask the user to enter a series of numbers separated by comma.
//Find the maximum of the numbers and display it on the console.
//For example, if the user enters “5, 3, 8, 1, 4", the program should display 8

Console.WriteLine("Enter Array Size");
int arraySize = Convert.ToInt32(Console.ReadLine());
var array = new int[arraySize];
Console.WriteLine("Enter Elements in Array");
for (int i = 0; i < arraySize; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int maxArray = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxArray)
    {
        maxArray = array[i];
    }
}

Console.WriteLine($"Maximum element is {maxArray}");


//Console.WriteLine("Enter Value");
//string str = Console.ReadLine();
//var splitted = str.Split(",");
//List<int> list = new List<int>();
//for (int i = 0; i < splitted.Length; i++)
//{
//    list.Add(Convert.ToInt32(splitted[i]));
//}
//list.Sort();
//Console.WriteLine(list[list.Count - 1]);
