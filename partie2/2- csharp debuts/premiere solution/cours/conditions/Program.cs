
Console.WriteLine("Quel est le solde de votre compte bancaire"); 
double solde = Convert.ToDouble(Console.ReadLine());

#region if else

if (solde < 0) Console.WriteLine("votre solde est négatif");

else if (solde == 0) Console.WriteLine("votre solde est nul");

else
{
    Console.WriteLine("votre solde est positif");
    Console.WriteLine($"solde restant: {solde}");
}

#endregion



Console.WriteLine("appuyer sur une touche pour fermer le programme");
Console.Read();