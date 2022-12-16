
//function moyenne(a)
//{
//    return Math.round((a /= n) * 100) / 100;
//}

Console.WriteLine("Combien de note devez vous entrer ?");
double n = Convert.ToDouble(Console.ReadLine());
double maxi = 0;
double mini = 20;
double moy = 0;

Console.WriteLine("Notes élèves:");

while (Double.IsNaN(n) || n < 2) {
    Console.WriteLine("Vous n'avez pas saisi un nombre de note valide, réessayez !");
    n = Convert.ToDouble(Console.ReadLine());
}


Console.WriteLine($"Vous avez choisi d'entrer {n} notes notées sur 20.");

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Veuillez entrer la note numéro {i}");
    double x = Convert.ToDouble(Console.ReadLine());
    while (Double.IsNaN(x) || x < 0 || x > 20)
    {
        Console.WriteLine($"Vous n'avez pas saisi une note valide. Veuillez entrer la note numéro {i}");
        x = Convert.ToDouble(Console.ReadLine());
    }

    Console.WriteLine($"La note {i} est : {x} / 20.");

    if (x <= mini) mini = x;
    if (x >= maxi) maxi = x;
    moy += x;
}

moy = Math.Round((moy /= n) * 100) / 100;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La plus grande note est {maxi} /20.");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La plus petite note est {mini} /20.");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"La moyenne est {moy} /20.");
Console.WriteLine("Appuyez sur Enter pour fermer le programme");
Console.Read();
