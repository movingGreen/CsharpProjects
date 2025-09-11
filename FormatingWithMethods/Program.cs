﻿// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');
// openingPosition += 1;

// // System.Console.WriteLine(openingPosition);
// // System.Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;

// System.Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";
// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(openSpan);
// openingPosition += 6;

// // System.Console.WriteLine(openingPosition);
// // System.Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;

// System.Console.WriteLine(message.Substring(openingPosition, length));

// string message = "hello there!";
// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// System.Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";

// while (true)
// {
//   int openingPosition = message.IndexOf('(');

//   if (openingPosition == -1) break;

//   openingPosition += 1;
//   int closingPosition = message.IndexOf(')');
//   int length = closingPosition - openingPosition;
//   System.Console.WriteLine(message.Substring(openingPosition, length));

//   message = message.Substring(closingPosition + 1);
// }

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = ['[', '{', '('];

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

// int closingPosition = 0;

// while (true)
// {
//   int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//   if (openingPosition == -1) break;

//   string currentSymbol = message.Substring(openingPosition, 1);

//   // Now  find the matching closing symbol
//   char matchingSymbol = ' ';

//   switch (currentSymbol)
//   {
//     case "[":
//       matchingSymbol = ']';
//       break;
//     case "{":
//       matchingSymbol = '}';
//       break;
//     case "(":
//       matchingSymbol = ')';
//       break;
//   }

//   // To find the closingPosition, use an overload of the IndexOf method to specify 
//   // that the search for the matchingSymbol should start at the openingPosition in the string. 

//   openingPosition += 1;
//   closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//   // Finally, use the techniques you've already learned to display the sub-string:

//   int length = closingPosition - openingPosition;
//   Console.WriteLine(message.Substring(openingPosition, length));
// }

string data = "12345John Smith          5000  3  ";
string updateData = data.Remove(1, 20);

Console.WriteLine(updateData);