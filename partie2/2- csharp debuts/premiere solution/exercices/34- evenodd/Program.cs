Console.Write("Combien de valeur voulez vous dans le tableau ? ");
int x = Convert.ToInt16(Console.ReadLine());

int[] tabs = new int[x];

#region sasie utilsateur

Console.WriteLine($"Inserer {x} valeurs dans le tableau : ");
for (int i = 0; i < tabs.Length; i++)
{
    Console.Write($"Saisir la valeur {i + 1} : ");
    while (!Int32.TryParse(Console.ReadLine(), out tabs[i])) Console.Write($"Mauvaise saisie ! Réessayer de saisir la valeur {i + 1} : ");
}

#endregion

for (int i = 0; i < tabs.Length; i++)
{
    Console.WriteLine($"Le nombre {tabs[i]} est : {(tabs[i] % 2 == 0 ? "pair" : "impair")}");
}