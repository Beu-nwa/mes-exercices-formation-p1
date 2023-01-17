using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01__chaises.Classes
{
    internal class Chaise
    {
        #region attributs

        private string model;
        private int nbpieds;
        private string materiaux;
        private string couleur;

        #endregion

        #region constructeur
        public Chaise()
        {
            model = "model par défaut";
            nbpieds = 4;
            materiaux = "bois";
            couleur = "marron";
        }
        public Chaise(string model, int nbpieds, string materiaux, string couleur) : this()
        {
            Model = model;
            Nbpieds = nbpieds;
            Materiaux = materiaux;
            Couleur = couleur;
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length > 1) model = value;
                else Console.WriteLine($"Erreur, le model {value} devrait comporter au moins deux caractères...");
            }
        }
        public int Nbpieds
        {
            get { return nbpieds; }
            set
            {
                if(value>=0) { nbpieds = value; }
                else Console.WriteLine($"Erreur, la chaise {model} ne peut pas avoir un nombre de pieds négatif de {value}");
            }
        }
        public string Materiaux
        {
            get { return materiaux; }
            set
            {
                if (value.Length > 1) materiaux = value;
                else Console.WriteLine($"Erreur pour la chaise {model}, le matériaux {value} doit comporter au moins deux caractères...");
            }
        }
        public string Couleur
        {
            get { return couleur; }
            set
            {
                if (value.Length > 1) couleur = value;
                else Console.WriteLine($"Erreur pour la chaise {model}, la couleur {value} doit comporter au moins deux caractères...");
            }
        }

        #endregion

        #region methodes

        public override string ToString()
        {
            return $"\nLe model de chaise \"{model}\" : \n\tPieds : {(nbpieds == 0 ? $"La chaise n'a pas de pieds." : $"La chaise a {nbpieds} pieds.")}" +
                $"\n\tMatériaux : {materiaux}.\n\tCouleur : {couleur}";
        }

        #endregion
    }
}
