// See https://aka.ms/new-console-template for more information
Console.WriteLine("capital de depart : ");
double ci = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Veuillez saisir le taux TVA en % : ");
double t = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Duree de l'epargne : ");
double n = Convert.ToDouble(Console.ReadLine());

double cf = ci * (Math.Pow((1 + (t / 100)), n));
Console.WriteLine($"vous ferez {Math.Round((cf - ci)*100)/100} euros de profit, soit un capital final de : {Math.Round((cf) * 100) / 100} euros ");
Console.WriteLine("\nAppuyer sur entrer pour fermer la console");
Console.Read();