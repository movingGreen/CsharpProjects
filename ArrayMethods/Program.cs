using System.Globalization;

string[] pallets = ["B14", "A11", "B12", "A13"];

// System.Console.WriteLine("Sorted...");
// Array.Sort(pallets);

// foreach (var pallet in pallets)
// {
//   System.Console.WriteLine($"-- {pallet}");
// }

// System.Console.WriteLine("");
// System.Console.WriteLine("Reversed...");
// Array.Reverse(pallets);

// foreach (var pallet in pallets)
// {
//   System.Console.WriteLine($"-- {pallet}");
// }

// System.Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);

// if (pallets[0] != null)
//   System.Console.WriteLine($"After: {pallets[0].ToLower()}");


// System.Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//   System.Console.WriteLine($"-- {pallet}");
// }


// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }


// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new(valueArray);
// string result = string.Join(",", valueArray);
// System.Console.WriteLine(result);

// string[] items = result.Split(',');

// foreach (string item in items)
// {
//   System.Console.WriteLine(item);
// }

string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(" ");

for (var i = 0; i < words.Length; i++)
{
  char[] charList = words[i].ToCharArray();
  Array.Reverse(charList);
  string? reversedWord = string.Join("", charList);

  if (reversedWord != null)
    words[i] = reversedWord;
}

pangram = string.Join(" ", words);
System.Console.WriteLine(pangram);