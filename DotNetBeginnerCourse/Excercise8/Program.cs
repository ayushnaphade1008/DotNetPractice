// See https://aka.ms/new-console-template for more information
Console.WriteLine("Excerise8");
//1- Write a program and ask the user to enter a few numbers separated by a hyphen.
//Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9"
//or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
//Console.WriteLine("Enter Seqence");
//string sequence1 = Console.ReadLine();
//string[] splitedSequence = sequence1.Split('-');
//int num=Convert.ToInt32(splitedSequence[0]);
//for (int i = 0; i < splitedSequence.Length; i++)
//{
//    var numrray = Convert.ToInt32(splitedSequence[i]);
//    if (splitedSequence[i] == splitedSequence[i + 1] + 1)
//    {
//        Console.WriteLine("consecutive");
//    }
//}


//2- Write a program and ask the user to enter a few numbers separated by a hyphen.
//If the user simply presses Enter, without supplying an input, exit immediately;
//otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

Console.WriteLine("Enter Seqence");
string sequence = Console.ReadLine();
if (sequence == string.Empty)
{
    Console.WriteLine("exit");
}
else
{
var split = sequence.Split('-');
    for (int i = 0; i < split.Length; i++)
    {
        for (int j = i+1; j < split.Length; j++)
        {
            if (split[i] == split[j])
            {
                Console.WriteLine("Duplicate");
                break;
            }
           
        }
       

    }
}





/* 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
 A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
 otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.*/










//4- Write a program and ask the user to enter a few words separated by a space.
//Use the words to create a variable name with PascalCase. For example,
//if the user types: "number of students", display "NumberOfStudents".
//Make sure that the program is not dependent on the input. So,
//if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".


Console.WriteLine("Enter few words");
string sentence = Console.ReadLine().ToLower();
string[] word = sentence.Split(' ');

foreach (string item in word)
{
    Console.Write(char.ToUpper(item[0]) + item.Substring(1));
}




















//5- Write a program and ask the user to enter an English word.
//Count the number of vowels (a, e, o, u, i) in the word. So,
//if the user enters "inadequate", the program should display 6 on the console.






