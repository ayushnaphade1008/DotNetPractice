// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
char ch = 'a';

int i = 10;
int j = ++i;
int[] ints = { 1, 2, 3, 4 };

int[] int1 = new int[] { 1, 2, 3 };
int[] int2 = new int[3];
int2[0] = 1;
int2[1] = 2;



Console.WriteLine("Before Reversed");
foreach (var item in ints)
{
    Console.Write(item + " ");
}
Console.WriteLine();
int index= Array.IndexOf(ints, 2);
Console.WriteLine($"index of 2 is {index}");
Array.Reverse(ints);

Console.WriteLine();

Console.WriteLine("After Reversed");
foreach (var item in ints)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Array.Clear(ints, 0, 2);
foreach (var item in ints)
{
    Console.Write(item + " ");
}
Console.WriteLine();

int[] cop = new int[2];
Array.Copy(ints, cop, 2);
foreach (var item in cop)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine($"{int.MinValue} and {int.MaxValue}");
Console.WriteLine($"i is {i} and j is {j}");

public enum Cons
{
    pieValue='v',
    Cricle=2
}





//string j = Convert.ToString(i);
//Console.WriteLine(j);





