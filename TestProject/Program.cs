﻿for (int i = 0; i < 100; i++)
{
  Console.Write(i);

  if (i % 3 == 0 && i % 5 == 0)
  {
    Console.Write(" - FizzBuzz");
  }
  else if (i % 3 == 0)
  {
    Console.Write(" - Fizz");
  }
  else if (i % 5 == 0)
  {
    Console.Write(" - Buzz");
  }

  Console.WriteLine();
}