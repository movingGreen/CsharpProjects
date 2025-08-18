int vidaMonstro = 10;
int vidaHeroi = 10;
Random randomAtaque = new();


do
{
  int heroiAtaque = randomAtaque.Next(1, 10);
  vidaMonstro -= heroiAtaque;

  System.Console.WriteLine($"Monster was damaged and lost {heroiAtaque} health and now has {vidaMonstro} health.");

  if (vidaMonstro <= 0)
  {
    System.Console.WriteLine("Hero wins!");
    break;
  }

  int monstroAtaque = randomAtaque.Next(1, 10);
  vidaHeroi -= monstroAtaque;

  System.Console.WriteLine($"Hero was damaged and lost {monstroAtaque} health and now has {vidaHeroi} health.");

  if (vidaMonstro <= 0)
  {
    System.Console.WriteLine("Monster wins!");
    break;
  }

} while (true);