
using _02__salaries.Classes;

Salarie[] salrieArray = {
    new ("045-785-564",              "personnel",    "entretien",        "Timeo",    28954),
    new("152-781-525",               "ouvrier",      "usinage",         "Tintin",    44556),
    new ("752-741-520",              "employé",      "informatique",    "Roger",     54844),
    new ("447-410-850",              "cadre",        "chef d'équipe",   "Léo",       65122),
    new ("01512032135146545131531",  "bureautique",  "stagiaire",       "",          -42)
};

foreach ( Salarie x in salrieArray)
{
    Console.WriteLine(x.AfficherSalaire());
}

Console.WriteLine($"\n{Salarie.GetInstanceCount()} employés dans l'entreprise.");
Console.WriteLine($"La moyenne des salaires est :{Salarie.CalculerMoyenneSalaires(salrieArray)}");
Salarie.ResetInstanceCount();
Console.WriteLine($"\n{Salarie.GetInstanceCount()} employés dans l'entreprise.");
Console.WriteLine($"La moyenne des salaires est :{Salarie.CalculerMoyenneSalaires(salrieArray)}");
Salarie.ResetInstanceCount(42);
Console.WriteLine($"\n{Salarie.GetInstanceCount()} employés dans l'entreprise.");
Console.WriteLine($"La moyenne des salaires est :{Salarie.CalculerMoyenneSalaires(salrieArray)}");
