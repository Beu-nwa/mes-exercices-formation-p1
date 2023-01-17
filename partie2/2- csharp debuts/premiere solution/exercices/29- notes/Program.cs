// notes while.

Console.WriteLine("Combien de note devez vous entrer ?");
//double n = Convert.ToDouble(Console.ReadLine());
double maxi = 0;
double mini = 20;
double total = 0;
int i = 0;
string texte1 = "";
string texte2 = "";

//ok
//Console.WriteLine("Notes élèves:");
//while (Double.IsNaN(n) || n < 2)
//{
//    Console.WriteLine("Vous n'avez pas saisi un nombre de note valide, réessayez !");
//    n = Convert.ToDouble(Console.ReadLine());
//}

//test
while(!double.TryParse(Console.ReadLine(), out double n))
{
    Console.WriteLine("Vous n'avez pas saisi un nombre de note valide, réessayez !");
    //n = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"Vous avez choisi d'entrer {n} notes notées sur 20.");
Console.WriteLine("Notes élèves:");


while (i < n)
{
    i++;
    Console.WriteLine($"Veuillez entrer la note numéro {i}");
    double x = Convert.ToDouble(Console.ReadLine());
    if (x == 777)
    {
        texte1 = $"Vous aviez choisi d'entrer {n} notes mais avez stoppé après la {i - 1}eme note.";
        n = i - 1;
    }
    while (Double.IsNaN(x) || x < 0 || (x > 20) && (x != 777))
    {
        Console.WriteLine($"Vous n'avez pas saisi une note valide. réessayez d'entrer la note numéro ${i}");
        x = Convert.ToDouble(Console.ReadLine());
    }
    if (x <= mini) mini = x;
    if ((x >= maxi) && (x != 777)) maxi = x;
    if (x != 777)
    {
        total += x;
        texte2 += $"\n\tLa note {i} est : {x} / 20.";
    }
}
Console.WriteLine($"{texte1}\n{texte2}\n\tSur l 'ensemble des {n} notes :\n\t");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La plus grande note est {maxi} /20.");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La plus petite note est {mini} /20.");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"La moyenne des {n} notes est : {Math.Round((total /= n) * 100) / 100} /20.");

Console.WriteLine("Appuyez sur Enter pour fermer le programme");
Console.Read();