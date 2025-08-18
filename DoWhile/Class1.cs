Random random = new();
int current = 4;

do
{
  // current = random.Next(1, 10);
  current++;

  if (current >= 8) continue;

  Console.WriteLine(current);

} while (current != 14);

// while (current >= 3)
// {
//   Console.WriteLine(current);
//   current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");