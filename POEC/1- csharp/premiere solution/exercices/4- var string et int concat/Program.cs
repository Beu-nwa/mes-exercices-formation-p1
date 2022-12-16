// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veuillez saisir votre nom : ");
string nom = Console.ReadLine();
Console.WriteLine("Veuillez saisir votre prénom : ");
string prenom = Console.ReadLine();
Console.WriteLine("Veuillez saisir votre âge : ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Bonjour {prenom} {nom}, vous avez {age} ans.");
Console.WriteLine("\nAppuyer sur entrer pour fermer la console");
Console.Read();