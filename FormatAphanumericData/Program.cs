string first = "Hello";
string second = "World";

System.Console.WriteLine($"{first} {second}!");
System.Console.WriteLine($"{second} {first}!");
System.Console.WriteLine($"{first} {first} {first}!");

decimal price = 123.45m;
int discount = 50;

System.Console.WriteLine($"Price: {price:c} (Save {discount:c})");