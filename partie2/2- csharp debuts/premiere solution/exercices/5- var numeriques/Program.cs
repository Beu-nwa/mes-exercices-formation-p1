// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veuillez saisir un premier nombre : ");
int nb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Veuillez saisir un second nombre : ");
int nb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"La somme de ces 2 nombres est : {nb1+nb2}.");
Console.WriteLine("\nAppuyer sur entrer pour fermer la console");
Console.Read();