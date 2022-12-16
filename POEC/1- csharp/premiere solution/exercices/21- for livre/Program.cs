Console.WriteLine("Menu et sous menu");

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"\tchapitre {i} :");
    for (int j = 1; j <= 3; j++) Console.WriteLine($"\t\t-partie {i}{j} :");
}

Console.WriteLine("touche fermer");
Console.Read();