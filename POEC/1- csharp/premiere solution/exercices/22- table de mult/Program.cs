for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"\nTable de {i} :");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"\t{i} x {j} = {i * j}");
    }
}

Console.WriteLine("touche fermer");
Console.Read();