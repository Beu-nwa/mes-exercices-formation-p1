// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veuillez saisir le taux TVA en % : ");
double t = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Veuillez saisir le prix hors taxe : ");
double prix = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"le prix TTC vaut {Math.Round((prix*(1+(t/100))) * 100) / 100}cm");
Console.WriteLine("\nAppuyer sur entrer pour fermer la console");
Console.Read();
