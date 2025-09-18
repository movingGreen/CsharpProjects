﻿// int[] schedule = { 800, 1200, 1600, 2000 };

// DisplayAdjustedTimes(schedule, 6, -6);


// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//   int diff = 0;

//   if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//   {
//     Console.WriteLine("Invalid GMT");
//   }
//   else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//   {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//   }
//   else
//   {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//   }

//   for (int i = 0; i < times.Length; i++)
//   {
//     int newTime = (times[i] + diff) % 2400;
//     Console.WriteLine($"{times[i]} -> {newTime}");
//   }

// }
//=============================================
// string[] students = ["Jenna", "Ayesha", "Carlos", "Viktor"];

// DisplayStudents(students);
// DisplayStudents(new string[] { "Robert", "Vanya" });

// void DisplayStudents(string[] students)
// {
//   foreach (string student in students)
//   {
//     Console.Write($"{student}, ");
//   }

//   System.Console.WriteLine();
// }
// =========================================
// using System.Net.NetworkInformation;
// double pi = 3.14159;
// PrintCircleInfo(12);
// PrintCircleInfo(24);

// // double circumference = 2 * pi * radius;

// void PrintCircleArea(int radius)
// {

//   double area = pi * (radius * radius);

//   System.Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {

//   double circumference = 2 * pi * radius;

//   System.Console.WriteLine($"Circumference = {circumference}");
// }

// void PrintCircleInfo(int radius)
// {
//   System.Console.WriteLine($"Circle with radius {radius}");
//   PrintCircleArea(radius);
//   PrintCircleCircumference(radius);
// }
// ===========================================

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c)
// {
//   c = a * b;
//   System.Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }
// ========================================
// int[] array = [1, 2, 3, 4, 5];

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array)
// {
//   foreach (int a in array)
//   {
//     Console.Write($"{a} ");
//   }

//   System.Console.WriteLine();
// }

// void Clear(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = 0;
//   }
// }

// ============================================

// string status = "Healthy";

// System.Console.WriteLine($"Start: {status}");
// SetHealth(false);
// System.Console.WriteLine($"End: {status}");

// void SetHealth(bool isHealthy)
// {
//   status = (isHealthy ? "Healthy" : "Unhealthy");
//   System.Console.WriteLine($"Middle: {status}");
// }
// ===============================

string[] guestList = ["Rebecca", "Nadia", "Noor", "Jonte"];
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
RSVP("Tony", 1, "Jackfruit", true);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize, string allergies, bool inviteOnly)
{
  if (inviteOnly)
  {
    bool found = false;

    foreach (string guest in guestList)
    {
      if (guest.Equals(name))
      {
        found = true;
        break;
      }
    }

    if (!found)
    {
      System.Console.WriteLine($"Sorry, {name} is not on the guest list");
      return;
    }
  }

  rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
  count++;
}

void ShowRSVPs()
{
  System.Console.WriteLine("\nTotal RSVPs:");

  for (int i = 0; i < count; i++)
  {
    System.Console.WriteLine(rsvps[i]);
  }
}