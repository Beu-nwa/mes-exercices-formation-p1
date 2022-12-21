using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__pendu.Classes
{
    internal class Mot
    {
        private static string[] mots = { "maison", "arbre", "ordinateur", "chat", "voiture", "livre", "telephone", "ecole", "jardin", "soleil", 
            "plage", "animal", "ville", "pays", "mer", "montagne", "ocean", "ciel", "nuage", "lune", "etoile", "fleur", "feuille", "oiseau", 
            "insecte", "souris", "poisson", "reptile", "mammifere", "crustace", "vegetal", "mineral", "electronique", "mecanique", "chimique", 
            "biologique", "physique", "mathematique", "geographie", "histoire", "litterature", "musique", "danse", "theatre", "cinema", "art", 
            "sport", "loisir", "voyage", "alimentation", "habitation", "vetement", "bijou", "accessoire" };

        public static string Generer()
        {
            int index = new Random().Next(mots.Length);
            return mots[index];
        }
    }
}
