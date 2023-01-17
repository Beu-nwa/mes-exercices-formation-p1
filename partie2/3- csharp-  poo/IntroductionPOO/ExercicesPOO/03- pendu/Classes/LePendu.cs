using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__pendu.Classes
{
    internal class LePendu
    {
        #region attributs

        private Mot generateur;
        private int nbEssai { get; set; }
        private int nbLettreTrouvee { get; set; }
        private string masque { get; set; }
        private string motATrouver { get; set; }

        #endregion

        #region constructeur

        public LePendu()
        {
            Generateur = new Mot();
            MotATrouver = Generateur.Generer();
            NbEssai = 10;
            NbLettreTrouvee = 0;
            GenererMasque();
        }

        #endregion

        #region propriétés

        public string MotATrouver { get => motATrouver; set => motATrouver = value; }
        public int NbEssai { get => nbEssai; set => nbEssai = value; }
        public int NbLettreTrouvee { get => nbLettreTrouvee; set => nbLettreTrouvee = value; }
        public string Masque { get => masque; set => masque = value; }
        public Mot Generateur { get => generateur; set => generateur = value; }


        #endregion
        public void TestChar(char c)
        {
            bool trouve = false;
            for (int i = 0; i < MotATrouver.Length; i++)
            {
                if (MotATrouver[i] == c)
                {
                    Masque = Masque.Substring(0, i) + c + Masque.Substring(i + 1);
                    trouve = true;
                    nbLettreTrouvee++;
                }
            }

            if (!trouve)
            {
                NbEssai--;
            }
            Console.WriteLine(Masque);
        }
        public string GenererMasque()
        {
            Masque = "";
            for (int i = 0; i < MotATrouver.Length; i++)
            {
                Masque += "-";
            }
            return Masque;
        }
        public bool IsLoose()
        {
            return NbEssai == 0;

        }
        public bool IsWon()
        {
            return nbLettreTrouvee == MotATrouver.Length;

        }
        public void GetNbEssais()
        {
            Console.WriteLine($"{NbEssai} essais restants");
        }
    }
}
