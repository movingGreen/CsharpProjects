System.Console.WriteLine("a" == "a");
System.Console.WriteLine("a" == "A");
System.Console.WriteLine(1 == 2);

string myValue = "a";
System.Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";

System.Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

System.Console.WriteLine("a" != "a");
System.Console.WriteLine("a" != "A");
System.Console.WriteLine(1 != 2);

string myValue2 = "a";
System.Console.WriteLine(myValue2 != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

string pangram = "The quick brown fox jumps over the lazy dog";
System.Console.WriteLine(!pangram.Contains("fox"));
System.Console.WriteLine(!pangram.Contains("cow"));
System.Console.WriteLine(pangram.Contains("fox") == false);
System.Console.WriteLine(!pangram.Contains("fox"));

Console.WriteLine();