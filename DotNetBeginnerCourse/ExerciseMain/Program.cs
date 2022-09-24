// See https://aka.ms/new-console-template for more information
Console.WriteLine("Main Exercise");

//1- Write a program and ask the user to enter a number. The number should be between 1 to 10.
//If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
//(This logic is used a lot in applications where values entered into input boxes need to be validated.)

//do
//{
    Console.WriteLine("Enter te Number between 1 to 10");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber <= 10 && inputNumber >= 1)
    {
        Console.WriteLine("Valid");

    }
    else
    {
        Console.WriteLine("Invalid");
    }
//}
//while (true);



//2- Write a program which takes two numbers from the console and displays the maximum of the two.

Console.WriteLine("Enter First Number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > SecondNumber)
{
    Console.WriteLine($"First Number {firstNumber} Is Largest Number");
}
else
{
    Console.WriteLine($"Second Number {SecondNumber} Is Largest Number");
}

//Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
Console.WriteLine("Enter Height");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Width");
int width = Convert.ToInt32(Console.ReadLine());
if (height>width)
{
    Console.WriteLine("potrait");
}
else
{
    Console.WriteLine("Landscape");
}


/* Your job is to write a program for a speed camera. For simplicity,
ignore the details such as camera, sensors, etc and focus purely on the logic
. Write a program that asks the user to enter the speed limit. Once set,
the program asks for the speed of a car. If the user enters a value less
than the speed limit, program should display Ok on the console.
If the value is above the speed limit, the program should
calculate the number of demerit points. For every 5km/hr above the speed limit,
1 demerit points should be incurred and displayed on the console.
If the number of demerit points is above 12, the program should display License Suspended.*/
Console.WriteLine("Enter Speed Limit");
int speedLimit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Car Limit");
int CarLimit = Convert.ToInt32(Console.ReadLine());
int demerit = 0;
if (speedLimit > CarLimit)
{
    Console.WriteLine("OK");
}
else
{
    int extraSpeed = CarLimit - speedLimit;
    demerit=(int)extraSpeed/5;
}
Console.WriteLine($"Collected Demerit point are {demerit}");
if (demerit > 12)
{
    Console.WriteLine("License Suspended");
}























