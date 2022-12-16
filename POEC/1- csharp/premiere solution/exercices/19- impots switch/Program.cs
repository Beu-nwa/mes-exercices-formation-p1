Console.WriteLine("Renseigner le montant de vos revenus");
double revenus = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Combien d'adulte compose votre foyer ?");
double part = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Combien d'enfant compose votre foyer ?");
double partEnfants = Convert.ToDouble(Console.ReadLine());
double montantsImpots = 0;
part += partEnfants < 3 ? partEnfants / 2 : partEnfants - 1;
revenus /= part;

#region jspquoi cases

switch (revenus)
{
    case < 10225: montantsImpots = 0;
        break;
    case < 26070:
        montantsImpots = (revenus - 10225) * 0.11;
        break;
    case < 74545: montantsImpots = 10225 * 0 + 15845 * 0.11 + (revenus - 26070) * 0.3;
        break;
    case < 160336: montantsImpots = 15845 * 0.11 + 48475 * 0.3 + (revenus - 74545) * 0.41;
        break;
    case >= 160336: montantsImpots = 15845 * 0.11 + 48475 * 0.3 + 85791 * 0.41 + (revenus - 160336) * 0.45;
        break;
    default:
        Console.WriteLine($"ya petit probleme");
        break;
}

Console.WriteLine($"Votre foyer composé de {part} parts, avec un revenu de {Math.Round(revenus)}€ par part paieras {Math.Round(montantsImpots) * part}€ d'impots.");

#endregion


Console.WriteLine("appuyer sur une touche pour quitter le programme");
Console.Read();