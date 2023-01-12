using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__pendu.Classes
{
    internal class IHM
    {
        #region Déclaration Des Variables Globale
        private int nbEssaisMax;
        LePendu pendu;
        bool ok = false;
        #endregion

        public IHM()
        {
            nbEssaisMax = 10;
        }
        public void Demarrer()
        {
            Console.WriteLine("Bienvenue au jeu du pendu !");
            Console.Write("Combien de coups souhaitez-vous avoir ? : ");
            int input;
            while(!Int32.TryParse(Console.ReadLine(), out input) || input <= 0) Console.Write("Erreur de saisir, réessayer : ");
            nbEssaisMax = input;
            pendu = new();
            Afficher();
            while (!ok)
            {
                pendu.GetNbEssais();
                PickChar(pendu);
                if(pendu.IsLoose())
                {
                    ok = true;
                    Loose(pendu);
                }
                else if (pendu.IsWon())
                {
                    ok = true;
                    Win(pendu);
                }
            }

        }

        private void Afficher()
        {
            Console.WriteLine($"Mot à trouver : {pendu.GenererMasque()}");
            Console.WriteLine("Nombre de coups restants : " + (nbEssaisMax));
        }

        private static void PickChar(LePendu p)
        {
            Console.Write("Essayer une lettre : ");
            char c = Console.ReadLine()[0];
            p.TestChar(c);
        }

        private static void Loose(LePendu p)
        {
            OnRed("Vous avez perdu.");
        }

        private static void Win(LePendu p)
        {
            OnGreen("Vous avez gagné");
        }

        private static void OnRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnCyan(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void WaitUser()
        {
            Console.WriteLine("Appuyez sur Enter pour proposer une nouvelle lettre...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void Exit()
        {
            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
            Console.Read();
            Environment.Exit(0);
        }
    }
}
