// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercise6");

/*
 * 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

 */

List<string> listNames = new List<string>(); 

while (true)
{
    Console.WriteLine("Enter Name");
    string names = Console.ReadLine();
    
    if(names.Length==0)
    {
        break;
    }
    
    
    listNames.Add(names);
        
    
}

if(listNames.Count==1)
{
    Console.WriteLine($"{listNames[0]} likes your post");

}
else if (listNames.Count == 2)
{
    Console.WriteLine($"{listNames[0]}, {listNames[1]} likes your post");
}
else
{
    Console.WriteLine($"{listNames[0]}, {listNames[1]} and {listNames.Count-2} others likes your post");
}



// 2.Write a program and ask the user to enter their name.
// Use an array to reverse the name and then store the result
// in a new string. Display the reversed name on the console.

Console.WriteLine("Enter Name");
string name = Console.ReadLine();
char[] charName = name.ToCharArray();
for (int i = charName.Length - 1; i >= 0; i--)
{
    Console.Write(charName[i].ToString());
}
Console.WriteLine();

Array.Reverse(charName);
foreach (var item in charName)
{
    Console.Write(item.ToString());
}

//3- Write a program and ask the user to enter 5 numbers.
//If a number has been previously entered, display an error message and ask the user to re-try.
//Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
//Console.WriteLine("Enter Number");
//int fnum = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Second Number");
//int snum = Convert.ToInt32(Console.ReadLine());

//if (snum == fnum)
//{
//    Console.WriteLine("Error Retry");
//    Console.WriteLine("Enter Second Number");
//    int snum = Convert.ToInt32(Console.ReadLine());

//}
var list = new List<int>();
while (list.Count < 5)
{
    Console.WriteLine("Enter Number");
    int number = Convert.ToInt32(Console.ReadLine());
    if (list.Contains(number))
    {
        Console.WriteLine("Not Duplicated enter again");

        continue;
    }
    list.Add(number);
}
list.Sort();
foreach (var item in list)
{
    Console.WriteLine(item);

}




//var array = new int[5];
//for (int i = 0; i < 5; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//    if (array[i] == array[i + 1])
//    {
//        Console.WriteLine("enter again");
//        array[i + 1] = Convert.ToInt32(Console.ReadLine());
//        break;
//    }
//}


//4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
//The list of numbers may include duplicates.
//Display the unique numbers that the user has entered.


String str = String.Empty;
var listNum = new List<int>();
do
{
    Console.WriteLine("ENTER THE NUMBER");
    str = Console.ReadLine();

    if (!str.Equals("quit"))
    {
        int number = Convert.ToInt32(str);
        listNum.Add(number);


    }
    else
    {
        break;
    }


}
while (true);
listNum.Sort();
for (int i = 0; i < listNum.Count; i++)
{
    for (int j = i + 1; j < listNum.Count; j++)
    {
        if (listNum[i] == listNum[j])
        {
            Console.WriteLine(listNum[i]);
            listNum.Remove(listNum[i]);
            break;
        }
    }
}



//5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
//If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
//otherwise, display the 3 smallest numbers in the list.
Console.WriteLine("Comma Seperated Values");
string listComma = Console.ReadLine();
List<int> listint = new List<int>();
while (true)
{
    if (listComma == null || listComma.Length < 13)
    {
        Console.WriteLine("Invalid List");
        Console.WriteLine("Enter List Again");
        listComma = Console.ReadLine();
        continue;
    }
    else
    {
        string[] splited_string = listComma.Split(", ");
        for (int i = 0; i < splited_string.Length; i++)
        {
            listint.Add(Convert.ToInt32(splited_string[i]));

        }
        listint.Sort();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(listint[i]);
        }
        break;

    }
}




