// See https://aka.ms/new-console-template for more information
Console.WriteLine("Inserer 5 valeurs dans le tableau : ");

int[] tabs = new int[5];

for (int i = 0; i<=5; i++)
{
    Console.Write($"Saisir la valeur {i} : ");
    tabs[i] = Console.Read();
}

//tabs.Map()
