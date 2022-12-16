Console.WriteLine($"QCM\nQuell est l'instruction qui permet de sortir d'une boucle en C#?");
Console.WriteLine($"\ta) quit\n\ta) continue\n\ta) break\n\ta) exit\n\nEntrez votre réponse : ");

bool stop = false;

do
{
    string attempt = Convert.ToString(Console.ReadLine()).ToUpper();
    if (attempt == "C")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Bravo!! C'est la bonne réponse !");
        Console.ForegroundColor = ConsoleColor.White;
        stop = true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Incorrecte !");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"Un nouvel essai ? Oui / Non ?");
        string answer = Convert.ToString(Console.ReadLine()).ToUpper();
        if (answer == "OUI") Console.WriteLine("essayez de nouveau :");
        else
        {
            stop = true;
            Console.ForegroundColor = ConsoleColor.Red;
            if (answer == "NON") Console.WriteLine("D'accord.. a+");
            if (answer != "NON") Console.WriteLine("Réponse Incorrecte, arrêt du programme.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
} while (stop == false);

Console.WriteLine("Appuyez sur Enter pour fermer le programme");
Console.Read();