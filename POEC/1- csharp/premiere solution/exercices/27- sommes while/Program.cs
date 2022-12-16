Console.WriteLine("Jusqu'à combien voulez vous voir la somme des entiers chainés ?");
int x = Convert.ToInt32(Console.ReadLine());
int somme;
string ligne = "";
string affichage = "Entiers en chaîne avec while :\n";
bool boolean = false;
int i = 0;

while (Double.IsNaN(x) || x < 0)
{
    Console.WriteLine("Jusqu'à combien voulez vous voir la somme des entiers chainés ?\n");
    x = Convert.ToInt32(Console.ReadLine());
}

affichage += $"Voici la liste des entiers chaînés dont la somme est égale à {x}.\n";

while (i < (x / 2))
{
    i++;
    somme = i;
    ligne = $"\n\t{x} = {i} ";
    int j = i;
    while (somme < x)
    {
        j++;
        ligne += $" + {j}";
        somme += j;
    }
    if (somme == x) affichage += $"{ligne}";
}

Console.WriteLine(affichage);
Console.WriteLine("\ntoucher c fermer");
Console.Read();