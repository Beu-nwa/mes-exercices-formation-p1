using System;
using System.Text;

Console.WriteLine("Renseigner le montant de vos revenus");
double revenus = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Combien d'adulte compose votre foyer ?");
double part = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Combien d'enfant compose votre foyer ?");
double partEnfants = Convert.ToDouble(Console.ReadLine());
double montantsImpots = 0;
part += partEnfants < 3 ? partEnfants / 2 : partEnfants - 1;
revenus /= part;

#region calc impots

if (revenus < 10225) montantsImpots = 0;
else if (revenus < 26070) montantsImpots = (revenus - 10225) * 0.11;
else if (revenus < 74545) montantsImpots = 10225 * 0 + 15845 * 0.11 + (revenus - 26070) * 0.3;
else if (revenus < 160336) montantsImpots = 15845 * 0.11 + 48475 * 0.3 + (revenus - 74545) * 0.41;
else montantsImpots = 15845 * 0.11 + 48475 * 0.3 + 85791 * 0.41 + (revenus - 160336) * 0.45;

#endregion

Console.WriteLine($"Votre foyer composé de {part} parts, avec un revenu de {Math.Round(revenus)} par part paieras {Math.Round(montantsImpots)*part}€ d'impots.");

Console.WriteLine($"fermer");
Console.Read();