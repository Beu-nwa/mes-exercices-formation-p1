using System;

Console.WriteLine($"Distributeur de boissons\n\t1/ Eau\n\t2/ Jus d'orange\n\t3/ Limonade\n\t4/ Café\n\t5/ Thé\nFaites votre choix:");
int choix = Convert.ToInt32(Console.ReadLine());

#region distrib cases

switch (choix)
{
    case 1:
        Console.WriteLine("eau glouglou");
        break;
    case 2:
        Console.WriteLine("Jus d'orange");
        break;
    case 3:
        Console.WriteLine("Limonade");
        break;
    case 4:
        Console.WriteLine("Café");
        break;
    case 5:
        Console.WriteLine("Thé");
        break;
    default:
        Console.WriteLine("Vous avez sasi une valeur invalide...");
        break;
}

#endregion

Console.WriteLine("appuyer sur une touche pour quitter le programme");
Console.Read();