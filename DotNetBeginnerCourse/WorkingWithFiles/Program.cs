// See https://aka.ms/new-console-template for more information
Console.WriteLine("Working With FIlES");


Directory.CreateDirectory(@"C:\cd_training\Folder2");
Console.WriteLine("Created Succesfuly");

var allFiles = Directory.GetFiles(@"C:\cd_training", "*.txt", SearchOption.AllDirectories);
foreach (var file in allFiles)
{
    Console.WriteLine(file);
}

var directory1 = Directory.GetDirectories(@"C:\cd_training", "*.*", SearchOption.AllDirectories);
foreach (var file in directory1)
{
    Console.WriteLine(file);
}
var directory = Directory.GetDirectories(@"C:\cd_training");
foreach (var file in directory)
{
    Console.WriteLine(file);
}
Directory.Exists(@"C:\cd_training");

//=============================================================================

var DirectIn = new DirectoryInfo(@"C:\cd_training");
DirectIn.Create();

DirectIn.GetDirectories(@"C:\cd_training");
DirectIn.GetFiles(@"C:\cd_training");


//============================================================================

string path1 = @"C:\cd_training\DotNet Course\1. Beginners C#\9. Working with Files\nemade.txt";




Console.WriteLine(Path.GetExtension(path1));
Console.WriteLine(Path.GetDirectoryName(path1));
Console.WriteLine(Path.GetFileName(path1));