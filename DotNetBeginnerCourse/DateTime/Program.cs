// See https://aka.ms/new-console-template for more information
Console.WriteLine("DateTime");
var DateTime = new DateTime();
var now= DateTime.Now;
var tomorrow= now.AddDays(1);
var nextYear= now.AddYears(1);
var shortDate=now.ToShortDateString();
var longDate = now.ToLongDateString();
var shortTime = now.ToShortTimeString();
var longTimme = now.ToLongTimeString();
var fullTime = now.ToString();

Console.WriteLine($"{now} \n {tomorrow} \n {nextYear} \n {shortDate} \n {longDate} \n  {shortTime} \n {longTimme} \n {fullTime}");

var timeSpan = new TimeSpan(1, 2, 3);
var timeSpan1 = new TimeSpan(1, 0, 0); //bad practice
TimeSpan.FromDays(1); //prefered

var start = DateTime.Now;
var end = DateTime.Now.AddMinutes(2);
var duration = end - start;
Console.WriteLine($"Duration is {duration}");


//properties
Console.WriteLine($" Total Minutes are {timeSpan.TotalMinutes}");
Console.WriteLine($"Minutes are {timeSpan.Minutes}");

//Add -sub

Console.WriteLine($"add example {timeSpan.Add(TimeSpan.FromMinutes(8))}");
Console.WriteLine($"add example {timeSpan.Subtract(TimeSpan.FromMinutes(8))}");


//ToString

Console.WriteLine($"To String {timeSpan.ToString()}");