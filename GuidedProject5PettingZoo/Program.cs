using System;

string[] pettingZoo =
[
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
];

// foreach (string animal in pettingZoo)
// {
//     System.Console.WriteLine(animal);
// }

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    System.Console.WriteLine(schoolName);
    PrintGroup(group);
}

void RandomizeAnimals()
{
    Random random = new();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}

string[,] AssignGroup(int groups = 6)
{
    int start = 0;
    string[,] result = new string[groups, pettingZoo.Length / groups];

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        System.Console.Write($"Group {i + 1}: ");

        for (int j = 0; j < group.GetLength(1); j++)
        {
            System.Console.Write($"{group[i, j]} ");
        }

        System.Console.WriteLine();
    }
}
