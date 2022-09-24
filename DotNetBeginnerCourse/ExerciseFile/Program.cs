// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercise File");

//Write a program that reads a text file and displays the number of words.
//Write a program that reads a text file and displays the number of character including space.
//Write a program that reads a text file and displays the number of lines.
// Write a program that reads a text file and displays the longest word in the file.

string path = @"C:\cd_training\nemade.txt";
var text = File.ReadAllText(path);
var splited_text = text.Split(' ');
int words = 0;
int character = 0;
int lines = 0;
string largestWord = splited_text[0];
for (int i = 0; i < splited_text.Length; i++)
{
    if(splited_text[i].Length > largestWord.Length){
        largestWord = splited_text[i];
    }

}
Console.WriteLine(largestWord);







foreach (var item in splited_text)
{
    words++;
    Console.WriteLine(item);
}
Console.WriteLine($"Counts of words are {words}");



foreach (var item in text)
{
    Console.WriteLine(item);
    character++;
}
Console.WriteLine($"number of Character with Space in file are {character}");

var line = File.ReadAllLines(path);

foreach (var item in line)
{
    lines++;
    Console.WriteLine(item);
}
Console.WriteLine($"Counts of words are {lines}");


Console.WriteLine(File.ReadAllText(path));
Console.WriteLine(File.ReadAllLines(path));// System.String[]
/*Console.WriteLine(File.ReadAllBytes(path));  *///System.Byte[]
/*Console.WriteLine(File.ReadLines(path));*/ //System.IO.ReadLinesIterator


