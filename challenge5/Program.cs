string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
System.Console.WriteLine($"Dear {customerName},\n");
System.Console.WriteLine($"As a customer of our {currentProduct}, offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
System.Console.WriteLine($"Currently, you own {currentShares:n2} shares at a return of {currentReturn:p2}.\n");
System.Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:p2}. Given your current volume, your potential profit would be {newProfit:c2}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += $"{currentReturn:p2}".PadRight(9);
comparisonMessage += $"{currentProfit:c2}\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += $"{newReturn:p2}".PadRight(9);
comparisonMessage += $"{newProfit:c2}\n";

Console.WriteLine(comparisonMessage);