// string first = "Hello";
// string second = "World";

// System.Console.WriteLine($"{first} {second}!");
// System.Console.WriteLine($"{second} {first}!");
// System.Console.WriteLine($"{first} {first} {first}!");

// decimal price = 123.45m;
// int discount = 50;

// System.Console.WriteLine($"Price: {price:c} (Save {discount:c})");
// System.Console.WriteLine("");

// decimal measurement = 123456.78912m;
// System.Console.WriteLine($"Measurement: {measurement:N1} units");

// decimal tax = .36785m;
// System.Console.WriteLine($"Tax rate: {tax:p3}");

decimal price = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = string.Format("You saved {0:c2} off the regular {1:c2} price. ", price - salePrice, price);
yourDiscount += $"A discount of {((price - salePrice) / price):p0}!";

System.Console.WriteLine(yourDiscount);