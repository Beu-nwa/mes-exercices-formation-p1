Console.WriteLine("entrer le numérateur");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("entrer le dénominateur");
int deno = Convert.ToInt32(Console.ReadLine());

#region conditons

if (num % deno == 0) Console.WriteLine($"{num} est divisible par {deno}");
else Console.WriteLine($"{num} n'est pas divisible par {deno}");

#endregion

Console.WriteLine("appuyer sur une touche pour fermer le programme");
Console.Read();