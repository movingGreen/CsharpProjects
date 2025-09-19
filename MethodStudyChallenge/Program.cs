﻿string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
  // display internal email addresses
  ShowEmail(firstName: corporate[i, 0], lastName: corporate[i, 1], domain: externalDomain);
}

for (int i = 0; i < external.GetLength(0); i++)
{
  // display external email addresses
  ShowEmail(firstName: external[i, 0], lastName: external[i, 1], domain: externalDomain);

}

void ShowEmail(string firstName, string lastName, string domain)
{
  firstName = firstName.ToLower().AsSpan(0, 2).ToString();
  lastName = lastName.ToLower();

  System.Console.WriteLine($"{firstName}{lastName}@{domain}");
}