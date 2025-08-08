Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
  System.Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
  System.Console.WriteLine("Your subscription expires within a day!");
  discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
  System.Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
  discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
  System.Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
  System.Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

