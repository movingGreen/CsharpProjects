/*
string[] fraudulentOrderIds = new string[3];

fraudulentOrderIds[0] = "A123";
fraudulentOrderIds[1] = "B456";
fraudulentOrderIds[2] = "C789";
// fraudulentOrderIds[4] = "D012";
*/

string[] fraudulentOrderIds = ["A123", "B456", "C789"];
System.Console.WriteLine($"First: {fraudulentOrderIds[0]}");
System.Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
System.Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

fraudulentOrderIds[0] = "F000";
System.Console.WriteLine($"Reassign First: {fraudulentOrderIds[0]}");
System.Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process.");


