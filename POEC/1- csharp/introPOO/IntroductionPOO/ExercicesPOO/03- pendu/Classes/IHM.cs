using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__pendu.Classes
{
    internal class IHM
    {
        //private LePendu lePendu;
        private int nbEssaisMax;

        public IHM()
        {
            //lePendu = new LePendu();
            nbEssaisMax = 10;
        }
        public void Demarrer()
        {
            Console.WriteLine("Bienvenue au jeu du pendu !");
            Console.Write("Combien de coups souhaitez-vous avoir ? (10 par défaut) : ");
            int input;
            while(!Int32.TryParse(Console.ReadLine(), out input) || input <= 0) Console.Write("Erreur de saisir, réessayer : ");
            nbEssaisMax = input;

            Afficher();

        }

        private void Afficher()
        {
            Console.WriteLine("Mot à trouver : " + Mot.Generer());
            Console.WriteLine("Nombre de coups restants : " + (nbEssaisMax));
        }
    }
}
