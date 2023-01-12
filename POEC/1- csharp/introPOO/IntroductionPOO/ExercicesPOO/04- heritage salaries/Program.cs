using _04__heritage_salaries.Classes;
using System;

Salaries[] salrieArray = {
    new ("045-785-564",              "personnel",    "entretien",        "Timeo",    28954),
    new("152-781-525",               "ouvrier",      "usinage",         "Tintin",    44556),
    new ("752-741-520",              "employé",      "informatique",    "Roger",     54844),
    new ("447-410-850",              "cadre",        "chef d'équipe",   "Léo",       65122),
    new ("01512032135146545131531",  "bureautique",  "stagiaire",       "",          -42)
};

Commercial[] commercialArray =
{
    new Commercial("123-456-789", "commercial", "ventes", "Jane", 45000, 250000, 10),
    new Commercial("987-654-321", "commercial", "ventes", "John", 55000, 350000, 15)
};

List<Salaries> allEmployees = new List<Salaries>();
allEmployees.AddRange(salrieArray);
allEmployees.AddRange(commercialArray);

int choix;
do
{
    Console.WriteLine($"===== Gestion des employés =====\n\n\t1/ Ajouter un employé.\n\t2/ Afficher le salaire des employés.\n\t3/ Rechercher un employé.\n\t0/ Quitter.");
    while (!Int32.TryParse(Console.ReadLine(), out choix) || (choix !=1 && choix != 2 && choix != 3 && choix != 0) ) Console.Write("Erreur de saisie, réessayez : ");
    switch (choix)
    {
        case 1 :
            {
                Console.Clear();
                int choix2;
                Console.WriteLine($"===== Ajouter un employé =====\n\n\t1/ Salarié.\n\t2/ Commerciale.\n\t0/ Retour.");
                while (!Int32.TryParse(Console.ReadLine(), out choix2) || (choix2 != 1 && choix2 != 2 && choix != 0)) Console.Write("Erreur de saisie, réessayez : ");
                switch (choix2)
                {
                    case 1:
                        {
                            #region ajouter salarie

                            Console.WriteLine("===== Ajouter un salarie =====");

                            Console.Write("Entrez le matricule XXX-XXX-XXX : ");
                            string mat = Console.ReadLine();
                            Console.Write("Entrez la catégorie : ");
                            string cate = Console.ReadLine();
                            Console.Write("Entrez le service : ");
                            string serv = Console.ReadLine();
                            Console.Write("Entrez le nom : ");
                            string nom = Console.ReadLine();
                            Console.Write("Entrez le salaire fixe : ");
                            int baseSalary = int.Parse(Console.ReadLine());

                            Salaries newSalarie = new Salaries(mat, cate, serv, nom, baseSalary);
                            allEmployees.Add(newSalarie);
                            Console.WriteLine("Le salarie a été ajouté avec succès !");
                            Console.Clear();

                            #endregion
                        }
                        break;
                    case 2:
                        {
                            #region ajouter commerciale

                            Console.WriteLine("===== Ajouter un commercial =====");

                            Console.Write("Entrez le matricule XXX-XXX-XXX : ");
                            string mat = Console.ReadLine();
                            Console.Write("Entrez la catégorie : ");
                            string cate = Console.ReadLine();
                            Console.Write("Entrez le service : ");
                            string serv = Console.ReadLine();
                            Console.Write("Entrez le nom : ");
                            string nom = Console.ReadLine();
                            Console.Write("Entrez le salaire fixe : ");
                            int baseSalary = int.Parse(Console.ReadLine());
                            Console.Write("Entrez le chiffre d'affaires : ");
                            int salesVolume = int.Parse(Console.ReadLine());
                            Console.Write("Entrez le taux de commission : ");
                            int commissionRate = int.Parse(Console.ReadLine());

                            Commercial newCommercial = new Commercial(mat, cate, serv, nom, baseSalary, salesVolume, commissionRate);
                            allEmployees.Add(newCommercial);
                            Console.WriteLine("Le commercial a été ajouté avec succès !");
                            Console.Clear();

                            #endregion
                        }
                        break;
                }
            }
            break;
        case 2 :
            {
                #region display salaires des employés

                Console.Clear();
                Console.WriteLine($"===== Salaire des employés =====\n\n");

                foreach (Salaries x in allEmployees)
                {
                    Console.WriteLine(x.AfficherSalaire());
                }

                Console.WriteLine($"\n\nSalaire fixe moyen des employés : {Salaries.CalculerMoyenneSalairesV2(allEmployees)}\n\n");

                #endregion

            }
            break;
        case 3 :
            {
                #region rechercher employe

                Console.Clear();
                Console.WriteLine("===== Rechercher un employé par son nom =====");
                Console.Write("Merci de saisir le nom de l'employé recherché : ");
                string nomTmp = Console.ReadLine();
                Salaries foundEmployee = allEmployees.Find(employee => employee.Nom == nomTmp);
                if (foundEmployee != null)
                {
                    Console.WriteLine($"Nom : {foundEmployee.Matricule}");
                    Console.WriteLine($"Catégorie : {foundEmployee.Categorie}");
                    Console.WriteLine($"Service : {foundEmployee.Service}");
                    Console.WriteLine($"Nom : {foundEmployee.Nom}");
                    Console.WriteLine($"Salaire : {foundEmployee.AfficherSalaire()}\n");
                }
                else
                {
                    Console.WriteLine("Aucun employé trouvé avec ce nom.");
                }

                #endregion
            }
            break;
    }

} while (choix !=0);