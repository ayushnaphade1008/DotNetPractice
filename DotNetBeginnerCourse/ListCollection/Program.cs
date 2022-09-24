// See https://aka.ms/new-console-template for more information
Console.WriteLine("List");
List<int> ListOne = new List<int>();
ListOne.Add(1);
ListOne.Add(2);
ListOne.Add(3);
ListOne.Add(4);

Console.WriteLine("Reversed String");
ListOne.Reverse();

foreach (int i in ListOne)
{
    Console.WriteLine(i);
}

List<int> ListTwo = new List<int>() { 1, 2, 3, 4, 5, 6 };

// Addrange will add anothe inumerable array or list

ListTwo.AddRange(ListOne);
foreach (int i in ListTwo)
{
    Console.WriteLine(i);
}

