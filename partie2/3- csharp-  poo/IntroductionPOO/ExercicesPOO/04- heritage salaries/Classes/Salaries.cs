using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04__heritage_salaries.Classes
{
    class Salaries
    {

        #region attributs

        private string matricule;
        private string categorie;
        private string service;
        private string nom;
        private int salaire;
        private static int instanceCount = 0;

        #endregion

        #region constructeur
        public Salaries()
        {
            matricule = "XXX-XXX-XXX";
            categorie = "inconnue";
            service = "inconnue";
            nom = "inconnue";
            salaire = 0;
        }
        public Salaries(string matricule, string categorie, string service, string nom, int salaire) : this()
        {
            Matricule = matricule;
            Categorie = categorie;
            Service = service;
            Nom = nom;
            Salaire = salaire;
            instanceCount++;
        }

        public string Matricule
        {
            get { return matricule; }
            set
            {
                if (value.Length == 11) matricule = value;
                else Console.WriteLine($"Erreur, le matricule {value} devrait comporter 11 caracteres");
            }
        }
        public string Categorie
        {
            get { return categorie; }
            set
            {
                if (value.Length > 1) categorie = value;
                else Console.WriteLine($"Erreur, la catégorie du matricule {matricule} devrait comporter au moins 1 caractere");
            }
        }
        public string Service
        {
            get { return service; }
            set
            {
                if (value.Length > 1) service = value;
                else Console.WriteLine($"Erreur, le service du matricule {matricule} devrait comporter au moins 1 caractere");
            }
        }
        public string Nom
        {
            get { return nom; }
            set
            {
                if (value.Length > 1) nom = value;
                else Console.WriteLine($"Erreur, le nom du matricule {matricule} devrait comporter au moins 1 caractere");
            }
        }
        public int Salaire
        {
            get { return salaire; }
            set
            {
                if (value >= 0) salaire = value;
                else Console.WriteLine($"Erreur, le salaire du matricule {matricule} est négatif.");
            }
        }
        #endregion

        #region methodes

        virtual public string AfficherSalaire()
        {
            return $"\nLe salaire de {nom} est {salaire}";
        }
        public static int GetInstanceCount()
        {
            return instanceCount;
        }
        public static double CalculerMoyenneSalaires(Salaries[] salariés)
        {
            double sommeSalaires = 0;
            foreach (Salaries salarie in salariés)
            {
                sommeSalaires += salarie.Salaire;
            }
            return Math.Round(sommeSalaires / salariés.Length, 2);
        }
        public static double CalculerMoyenneSalairesV2(List<Salaries> salariés)
        {
            double sommeSalaires = 0;
            foreach (Salaries salarie in salariés)
            {
                sommeSalaires += salarie.Salaire;
            }
            return Math.Round(sommeSalaires / salariés.Count, 2);
        }
        public static void ResetInstanceCount(int value = 0)
        {
            instanceCount = value;
        }

        #endregion
    }
}
