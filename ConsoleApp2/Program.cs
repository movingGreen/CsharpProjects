// int first = 2;
// string second = "4";
// string result = first + second;

// System.Console.WriteLine(result);

// int myInt = 3;
// System.Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// System.Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// System.Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// System.Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 3.14123123084m;
// float myFloat = (float)myDecimal;

// System.Console.WriteLine($"Decimal: {myDecimal}");
// System.Console.WriteLine($"Float  : {myFloat}");

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// System.Console.WriteLine(message);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// System.Console.WriteLine(sum);

// string value = "bad";
// int result = 0;

// if (int.TryParse(value, out result))
// {
//   System.Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//   System.Console.WriteLine("Unable to report the measurement.");
// }

// System.Console.WriteLine($"Measurement (w/offset): {50 + result}");

string[] values = ["12,3", "45", "ABC", "11", "DEF"];
decimal sum = 0;
decimal auxNumber = 0;
string message = "";

foreach (var item in values)
{
  if (decimal.TryParse(item, out auxNumber))
  {
    sum += auxNumber;
  }
  else
  {
    message += item;
  }

}

System.Console.WriteLine($"Message: {message}");
System.Console.WriteLine($"Total: {sum}");

// ------------------------------------------------------------
System.Console.WriteLine("");
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(value1 / value2);

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");