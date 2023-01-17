using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__premierProjetCours
{
    public class start
    {
        public static void Main(string[] args)
        {
            #region Affichage dans la console
            Console.Write("Je m'affiche...");
            Console.Write("sans retour");
            // retour à la ligne apres l'information
            Console.WriteLine("à la ligne");
            Console.Write("Hello Worl!");
            #endregion

            #region Lecture saisie utilisateur
            // lire un nombre
            //Console.Write("Veuillez saisir un nombre : ");
            //char @char = (char)Console.Read();
            //Console.WriteLine(@char);

            //Lire une chaîne de caractère
            Console.Write("Veuillez saisir une chaine de caractere :  : ");
            string maChaine1 = Console.ReadLine();
            Console.Write("Veuillez saisir une chaine de caractere :  : ");
            string maChaine2 = Console.ReadLine();
            Console.Write("Veuillez saisir une chaine de caractere :  : ");
            string maChaine3 = Console.ReadLine();
            Console.WriteLine(maChaine1);
            Console.WriteLine(maChaine2);
            Console.WriteLine(maChaine3);
            #endregion

            #region surcharge WriteLine

            // surcharge WriteLine(string format, obj1, obj2, obj3) 
            Console.WriteLine("je formate ma chaine avec {0} et avec {1} et avec {2}", maChaine1, maChaine2, maChaine3);

            #endregion

            #region Changer la couleur de la police dans la console

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Je suis en vert");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion

            #region changer la couleur de fond

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Le fond est rouge");
            Console.BackgroundColor = ConsoleColor.Black;

            #endregion

            #region caracteres speciaux
            // le \ permet au caractere qui suit d'echaper à sa fonction premiere

            Console.WriteLine("\nLes caracteres speciaux\n");
            // afficher un chemin d'acces dans la console
            Console.WriteLine("c:\\repertoire\\MonFichier.cs");
            Console.WriteLine(@"c:\repertoire\MonFichier.cs");

            // le \ devant les "
            Console.WriteLine("hello, I'm \"Benoit\"");

            // Mise en forme de texte
            Console.WriteLine("je vais sauter une ligne après cette phrase \n");
            Console.WriteLine("\t il y a une tabulation au début");

            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("symbole euro : €\n");

            #endregion

            #region date et heure

            DateTime date = DateTime.Now;
            Console.WriteLine("date et heure : {0:d} at {0:t}", date);

            #endregion

            Console.WriteLine("Appuyez sur Enter pour fermer le programme");
            Console.Read();

    }
    }
}
