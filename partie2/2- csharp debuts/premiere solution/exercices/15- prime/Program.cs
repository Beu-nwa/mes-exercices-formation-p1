using System.Text;

Console.WriteLine("Quel est votre age ?");
double age = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Depuis combien de temps en année travaillez vous chez nous ?");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quel est le montant de votre dernier salaire ?");
double salaire = Convert.ToDouble(Console.ReadLine());
double primeAge = 0;
double primeAncienneté = 0;

Console.WriteLine($"Avec {age} ans, {n} années d'ancienneté et un salaire de {salaire} euros, vos droits sont :");

#region prime ancienneté

if (n < 1) Console.WriteLine($"Vous n'avez pas cumuler l'année d'ancienneté nécéssaire pour être éligible {Math.Round(n * 365)} jours).");
else if (n <= 10)
{
    primeAncienneté = (salaire / 2) * n;
    Console.WriteLine($"Avec {n} année d'ancienneté, vous beneficierez d'une prime d'ancienneté de {primeAncienneté}.");
}
else
{
    primeAncienneté = (salaire / 2) * 10 + salaire * (n - 10);
    Console.WriteLine($"Avec {n} année d'ancienneté, vous beneficierez de'une prime d'ancienneté de {primeAncienneté}.");
}
#endregion

#region prime age

if (age < 46) Console.WriteLine($"Agé de {age} ans, vous etes trop jeune pour beneficier de la prime liée aà l'âge.");
else if (age < 50)
{
    primeAge = salaire * 2;
    Console.WriteLine($"Agé de {age} ans, La prime dûe à l'age vous offre 2 mois de salaire, soit {primeAge}.");
}
else
{
    primeAge = salaire * 5;
    Console.WriteLine($"Agé de {age} ans, La prime dûe à l'age vous offre 5 mois de salaire, soit {primeAge}.");
}

#endregion

Console.WriteLine("appuyer sur une touche pour fermer le programme");

Console.WriteLine($"Au total vous toucherez {primeAge+primeAncienneté} euros de primes cumulées.");
Console.Read();