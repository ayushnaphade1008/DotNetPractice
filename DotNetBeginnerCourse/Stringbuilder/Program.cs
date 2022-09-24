// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("String Builder");

string str = "ayushnaphade.netdeveloperincoidtassolutionpune";
var builder = new StringBuilder(str);
builder.Append('-', 10);
builder.AppendLine();
builder.Append("AyushNaphade");
builder.AppendLine();
builder.Append('-', 10);
Console.WriteLine(builder.ToString());
builder.Replace('-', '+');
builder.Remove(0, 3);
builder.Insert(0, new String('#', 5));
Console.WriteLine(builder);


