using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_banque_ihm.Classes
{
    internal class CompteEpargne : Compte
    {
        private decimal taux;

        public CompteEpargne(decimal solde, Client client, decimal taux) : base(solde, client)
        {
            Taux = taux;
        }

        public decimal Taux { get => taux; set => taux = value; }

        public bool CalculInterets()
        {
            return base.Depot(new Operation(Math.Round(Solde * Taux / 100, 2)));
        }
    }
}
