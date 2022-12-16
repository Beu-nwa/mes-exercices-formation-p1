// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veuillez saisir la longueur du 1er côté AB du triangle : ");
double AB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Veuillez saisir la longueur du 2nd côté BC du triangle : ");
double BC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"l'hypotenuse vaut {Math.Round((Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(BC, 2))) *100)/100}cm");
Console.WriteLine("\nAppuyer sur entrer pour fermer la console");
Console.Read();