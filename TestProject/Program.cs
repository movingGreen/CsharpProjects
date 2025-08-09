/*
  O propósito deste código é reverter uma string
  e contar quantas vezes a letra 'o' aparece nela.
*/
string textToCount = "The quick brown fox jumps over the lazy dog.";
char[] characterArray = textToCount.ToCharArray();
int letterCount = 0;

Array.Reverse(characterArray);

foreach (char character in characterArray)
{
  if (character == 'o')
  {
    letterCount++;
  }
}

string new_message = new string(characterArray);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount} times.");