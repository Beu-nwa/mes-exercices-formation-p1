using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionPOO.Classes
{
    internal class Voitures
    {
        #region Attributs
        private string model;
        private string couleur;
        private int autonomie;
        private int reservoir;
        private bool demaree;
        private bool circule;
        #endregion

        #region Constructeurs
        public Voitures()
        {
            Demaree = false;
        }

        public Voitures(string model, string couleur, int autonomie, int reservoir) : this()
        {
            Model = model;
            Couleur = couleur;
            Autonomie = autonomie;
            Reservoir = reservoir;
        }
        #endregion

        #region Propriètés
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length > 1)
                    model = value;
                else
                    //throw new Exception("Erreur format Model");
                    Console.WriteLine("Erreur, le nom doit comporter au moins deux caractères...");
            }
        }
        public string Couleur { get => couleur; set => couleur = value; }
        public int Autonomie { get => autonomie; set => autonomie = value; }
        public int Reservoir { get => reservoir; set => reservoir = value; }
        public bool Demaree { get => demaree; set => demaree = value; }
        public bool Circule { get => circule; set => circule = value; }
        #endregion

        #region Methodes
        public void DemarrerMoteur()
        {
            if (!demaree)
            {
                demaree = true;
                Console.WriteLine("La voiture est démarée... le moteur tourne");
            }
            else
                Console.WriteLine("Le moteur tourne déjà ! ! !");
        }

        public void ArreterMoteur()
        {
            if (demaree && !circule)
            {
                demaree = false;
                Console.WriteLine("Le moteur est désormais coupé.");
            }
            else
                Console.WriteLine("Impssobile de couper le moteur.. Le moteur est surement deja à l'arret.");
        }

        public void Rouler()
        {
            if (demaree && !circule)
            {
                Console.WriteLine("La voiture est désormais en circulaton.");
            }
            else if (circule)
                Console.WriteLine("La voiture circule déjà");
            else
                Console.WriteLine("Il faut mettre le moteur en route pour pouvoir rouler");
        }

        public void Stoper()
        {
            if (demaree && circule)
            {
                Console.WriteLine("La voiture est désormais stoppée.");
            }
            else if (!circule)
                Console.WriteLine("La voiture est déjà stoppée");
            else
                Console.WriteLine("Impossible de stopper un vehicule dont le moteur est arreté.");
        }

        public void Klaxonner()
        {
            Console.WriteLine($"La {Model} {Couleur} klaxonne.");
        }

        public void FaireLePlein()
        {
            reservoir = 100;
            autonomie = 100;
            Console.WriteLine($"La {Model} {Couleur} a fait le plein.");
        }

        public void Afficher()
        {
            Console.WriteLine($"La voiture est une {Model} de couleur {Couleur}, avec une autonomie de {Autonomie}km avec un réservoir de {Reservoir}L.");
        }

        public override string ToString()
        {
            return $"Model : {Model} => Couleur : {Couleur} - Range : {Autonomie} km - Réservoir : {Reservoir}L";
        }
        #endregion
    }
}
