using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04__heritage_salaries.Classes
{
    internal class Commercial : Salaries
    {
        private double chiffreAffaire;
        private double commission;

        public Commercial()
            {
            chiffreAffaire = 0;
            commission = 0;
            }
        public Commercial(string matricule, string categorie, string service, string nom, int salaire, double chiffreAffaire, double commission) : base(matricule, categorie, service, nom, salaire)
        {
            Matricule = matricule;
            Categorie = categorie;
            Service = service;
            Nom = nom;
            Salaire = salaire;
            ChiffreAffaire = chiffreAffaire;
            Commission = commission;
        }
        public double ChiffreAffaire
        {
            get { return chiffreAffaire; }
            set
            {
                if (value >= 0) chiffreAffaire = value;
                else Console.WriteLine($"Erreur, le chiffre d'affaires du matricule {Matricule} est négatif.");
            }
        }

        public double Commission
        {
            get { return commission; }
            set
            {
                if (value >= 0 && value <= 100) commission = value;
                else Console.WriteLine($"Erreur, la commission du matricule {Matricule} doit être comprise entre 0 et 100%.");
            }
        }

        #region methodes

        public override string AfficherSalaire()
        {
            return $"\n{Nom} est un commerciale avec comme salaire : \n\t fixe : {Salaire}.\n\tAvec commission : {(Salaire + ((Commission / 100) * ChiffreAffaire))}";
        }

        #endregion
    }
}
