using MrRochelleGuestLecture;
using System.Net.Http.Headers;

Console.WriteLine("I am guest Lecturing for Mr. Rochelle!!");
Console.WriteLine("I am Mathew Desjardins. I am a Senior Lecturer");
Console.WriteLine("and CSCI 1250 & 1260 Course Coordinator.");
Console.WriteLine("\n");
Console.WriteLine("I run our BlueSky Tennessee Institute in Chatt, TN!");
Console.WriteLine("\n");
Console.WriteLine("Today we are going to talk about Properties and");
Console.WriteLine("the Copy Constructor.");
Console.WriteLine("\n");
Console.WriteLine("By the end of the class you should understand");
Console.WriteLine("both topics, when to use them. How to use them.");
Console.WriteLine("You should also have a better understanding of memory");
Console.WriteLine("allocation!");


var person = new Person();
//person.Name = "Matt";

//person.SSN = "0324165113546";
//Console.WriteLine(person.Name);

//Console.WriteLine(person.SSN);

person.Name = "Sally";

person.Shoes.Add("Levi", 12.5);
person.Shoes.Add("Black Vans", 13);
person.Shoes.Add("Navy Blue Vans", 12.5);

person.Address.StreetNumber = 12;

person.Address.StreetName = "SomeStreet";
person.Address.ZipCode = "37614";
person.Address.City = "JC";
person.Address.State = "TN";
   
foreach (var item in person.Shoes)
{
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
}
Console.ForegroundColor = ConsoleColor.Magenta;
Console.BackgroundColor = ConsoleColor.Black;
var person2 = new Person(person);

//String name = new String("Matt");
string name = "Matt";

//String name2 = new String(name);
string name2 = name;

Console.WriteLine( name);
Console.WriteLine(name2);
name2 = "Sally";

Console.WriteLine(name);
Console.WriteLine(name2);

Console.WriteLine(person.Address);

Console.WriteLine(person2.Address);

person.Address.State = "VA";

Console.WriteLine(person.Address);

Console.WriteLine(person2.Address);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;



