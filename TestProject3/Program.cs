Random randomCoin = new Random();
int coinValue = randomCoin.Next(0, 2);
System.Console.WriteLine(coinValue == 0 ? "Heads" : "Tails");