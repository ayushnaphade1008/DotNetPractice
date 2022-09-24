// See https://aka.ms/new-console-template for more information
Console.WriteLine("Live Coding WithString");
var sentence = "You cannot define a method inside the definition of an enumeration type To add functionality to an enumeration type create an extension method.";
const int maxLength = 30;
if (sentence.Length < maxLength)
{
    Console.WriteLine(sentence);
}
else
{
    var words=sentence.Split(' ');
    var totalC = 0;
    var list = new List<string>();
    foreach (var item in words)
    {
        list.Add(item);
        totalC += item.Length + 1;
        if(totalC > maxLength)
        {
            break;
        }


    }
    //foreach (var item in list)
    //{
    //}
    var summary = string.Join(" ", list) + "...";
    Console.WriteLine(summary);
    //Console.WriteLine(sentence.Substring(0, maxLength));
}


