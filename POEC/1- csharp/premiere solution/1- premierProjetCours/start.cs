using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1__premierProjetCours
{
    public class start
    {
        public static void Main(string[] args)
        {
            // ctrl k c : commenter;
            // ctrl k u : décommenter;

            #region affichage console

            Console.Write("je m'affiche");
            Console.Write("sans retour");

            Console.WriteLine("à la ligne");
            //avec retour à la ligne apres l'instruction

            Console.Write("Hello, World!");

            #endregion

            #region lecture sasie utilisateur

            // lire un nombre
            Console.Write("saisir un caractere:");
            char @char = (char)Console.Read();
            Console.WriteLine(@char);

            // lire une chaine de caractere
            string maChaine = Console.ReadLine();
            Console.WriteLine(maChaine);
                
            #endregion

            #region changement de couleur

            #endregion


            Console.WriteLine("\n\nappuyer sur entrer pour fermer le programme");
            Console.Read();

        }
    }
}
