Console.Write("Combien de valeur voulez vous dans le tableau ? ");
int x;
while(!Int32.TryParse(Console.ReadLine(), out x)) Console.Write("Erreur de saisie, essayer de nouveau de renseigner le nombre de note");
Random rnd = new Random();

#region tableaux generiques

int[] numbers = new int[x];
Random r = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, 51);
}

int y = 0;
foreach(int number in numbers)
{
    Console.WriteLine($"{number.ToString().PadLeft(y, ' ')}");
    y += 10;
}

y = 0;
//Array.Sort(numbers);
//foreach (int number in numbers)
foreach (int number in numbers.OrderBy(nb => nb))
{
    Console.WriteLine($"{number.ToString().PadLeft(y, ' ')}");
    y += 10;
}
//y = 0;
//foreach (int number in numbers)
//{
//    Console.WriteLine($"{number.ToString().PadLeft(y, ' ')}");
//    y += 10;
//}

#endregion

#region Dictionary

//Dictionary<string, int> dict = new Dictionary<string, int>();
//for (int i = 1; i <= x; i++)
//{
//    dict.Add("Key" + i, rnd.Next(1, 51));
//}

// Print the contents of the dictionary
//int y = 0;
//foreach (KeyValuePair<string, int> entry in dict)
//{
//    Console.WriteLine($"{entry.Value.ToString().PadLeft(y, ' ')}");
//    y += 10;
//    Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
//}

//Console.WriteLine($"Après : ");
//y = 0;
//foreach (KeyValuePair<string, int> entry in dict.OrderBy(kvp => kvp.Value))
//{
//    Console.WriteLine($"{entry.Value.ToString().PadLeft(y, ' ')}");
//    y += 10;
//}

#endregion
