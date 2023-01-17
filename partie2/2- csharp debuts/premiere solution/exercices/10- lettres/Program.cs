Console.WriteLine("entrer une lettre");
string lettre = Console.ReadLine();

#region conditons

if (lettre == "a" || lettre == "A" || lettre == "e" || lettre == "E" || lettre == "I" || lettre == "i" || lettre == "o" || lettre == "O" || lettre == "u" || lettre == "U" || lettre == "y" || lettre == "Y")
    Console.WriteLine($"{lettre} est une voyelle");

else if (Char.IsLetter(lettre,0)) Console.WriteLine($"{lettre} est une consonne");

else Console.WriteLine($"{lettre} n'est pas une lettre");

#endregion



Console.WriteLine("appuyer sur une touche pour fermer le programme");
Console.Read();