// See https://aka.ms/new-console-template for more information
using UpCasDownCast;
using System.Collections;
using System.Collections.Generic;

//Console.WriteLine("Hello, World!");

//Text text= new Text();
//Shape shape = text;


//text.width = 200;

//StreamReader reader = new StreamReader(new FileStream());
ArrayList arrayList = new ArrayList();
arrayList.Add(new Text());
var list = new List<int>();
Shape shape = new Text();
Text text = (Text)shape;
