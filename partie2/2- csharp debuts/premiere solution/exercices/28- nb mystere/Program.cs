int nbCoups = 0;
int maximum = 50;
int minimum = 0;
bool success = false;
Random rand = new Random();
int nbMyster = rand.Next(0, 51);

Console.WriteLine($"Trouvez le nombre mystère qui se situe entre {minimum} et {maximum} (c'est un entier)");

while(success == false)
{
Console.WriteLine($"tentative numéro : {++nbCoups}");
int x = Convert.ToInt32(Console.ReadLine());

    if ((x < nbMyster) && (x >= minimum)) Console.WriteLine($"Le nombre mystère est plus grand que {x}.");
    else if ((x > nbMyster) && (x <= maximum)) Console.WriteLine($"Le nombre mystère est plus petit que {x}.");
    else if (x == nbMyster)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Vous avez trouvé le nombre mystère {nbMyster} en {nbCoups} coups");
        Console.ForegroundColor = ConsoleColor.White;
        success = true;
    }
    else Console.WriteLine($"La valeur : {x} n'est pas correcte.");
}

Console.WriteLine("Appuyez sur Enter pour fermer le programme");
Console.Read();