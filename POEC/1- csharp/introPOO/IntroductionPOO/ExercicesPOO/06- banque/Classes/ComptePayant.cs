using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__banque.Classes
{
    public class ComptePayant : Compte
    {
        private double coutTransaction = 0.50;
        public ComptePayant(double solde, Client client, double ct) : base(solde, client)
        {
            this.coutTransaction = ct;
            PlafondBas = -1000;
            PlafondHaut = 10000;
        }

        public double CoutTransaction { get => coutTransaction; set => coutTransaction = value; }

        public override void ToString()
        {
            Helpers.ToGreen($"Le compte Payant a été ajouté avec succès à l'id {id} avec un coût de transaction de : {coutTransaction} euros.");
        }
        public override void Depot(Operation op)
        {
            OperationList.Add(op);
            this.solde += op.Montant - coutTransaction;
        }
        public override void Retrait(Operation op)
        {
            OperationList.Add(op);
            this.solde -= op.Montant - coutTransaction;
        }
        public override void DisplayOperations()
        {
            string chaine = "";
            int i = 0;
            foreach (Operation op in OperationList)
            {
                chaine += $"\n\tId: {++i}, ";
                chaine += op.ToString();
                chaine += $"\nFrais de transaction : {coutTransaction} euros.";
            }
            Console.WriteLine(chaine);
        }
    }
}
