
Console.WriteLine("Jusqu'à combien voulez vous voir la somme des entiers chainés ?");
int x = Convert.ToInt32(Console.ReadLine());
int somme;
string ligne = "";
string affichage = "";
bool boolean = false;

Console.WriteLine($"Voici la liste des entiers chaînés dont la somme est égale à ${x}");
Console.WriteLine($"Voici la liste des entiers chaînés demandée : ");

for (int i = 1; i <= (x / 2); i++)
{
    somme = 0;
    ligne = $"\n{x} = {i}";

    for (int j = i; somme < x; j++)
    {
     if (j != i) ligne += $" + {j}";
     somme += j;
    }

    if (somme == x)
    {
        affichage += ligne;
        boolean = true;
    }
}

if (boolean == false) Console.WriteLine($"La valeur entrée ne correspond à aucune somme de nombre en chaîne !");

Console.WriteLine(affichage);
Console.WriteLine("toucher c fermer");
Console.Read();