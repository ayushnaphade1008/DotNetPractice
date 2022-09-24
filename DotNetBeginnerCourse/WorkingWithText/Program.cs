// See https://aka.ms/new-console-template for more information
Console.WriteLine("String operations");
string fullName = "Ayush Naphade   ";
int money = 12345;

Console.WriteLine($"Trim {fullName.Trim()}");
Console.WriteLine($"ToUpper {fullName.ToUpper()}");
Console.WriteLine($"ToLower {fullName.ToLower()}");

var index = fullName.IndexOf(' ');
var firstName = fullName.Substring(0,index);
var lastName= fullName.Substring(index + 1);

Console.WriteLine(firstName);
Console.WriteLine(lastName );

var names = fullName.Split(' ');
Console.WriteLine($"First name:{names[0]} and Last Name={names[1]}");

Console.WriteLine(fullName.Replace("Ayush", "Mansi"));

if (string.IsNullOrEmpty(fullName))
{
    Console.WriteLine("Invalid");
}
else
{
    Console.WriteLine("valid");
}


if (string.IsNullOrWhiteSpace(fullName))
{
    Console.WriteLine("Invalid");
}
else
{
    Console.WriteLine("valid");
}

Console.WriteLine(money.ToString("C"));
Console.WriteLine(money.ToString("C0"));




