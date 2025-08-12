System.Console.WriteLine("a" == "a");
System.Console.WriteLine("a" == "A");
System.Console.WriteLine(1 == 2);

string myValue = "a";
System.Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
System.Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());