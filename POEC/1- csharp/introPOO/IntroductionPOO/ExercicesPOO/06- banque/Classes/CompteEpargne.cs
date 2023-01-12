using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__banque.Classes
{
    public class CompteEpargne : Compte
    {
        private double tauxRemuneration = 5;

        public CompteEpargne(double solde, Client client, double taux) : base(solde, client)
        {
            this.tauxRemuneration = Helpers.ConvertPurcentage(taux);
            PlafondBas = 0;
            PlafondHaut = 100000;
        }

        public double TauxRemuneration
        {
            get => tauxRemuneration;
            set => tauxRemuneration = value;
        }

        public override void ToString()
        {
            Helpers.ToGreen($"Le compte épargne a été ajouté avec succès à l'id {id} et au taux {tauxRemuneration}.");
        }
        public override void AddInterest()
        {
            this.solde += tauxRemuneration * solde;
            Helpers.ToGreen($"Les intérêts des montant de {tauxRemuneration} ont été ajoutés au compte numéro {id} passant le solde à {solde} euros.");
        }
    }
}
