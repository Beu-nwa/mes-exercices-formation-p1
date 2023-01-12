using jdk.@internal.dynalink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__banque.Classes
{
    public class Compte
    {
        private static int idCounter = 0;
        public readonly int id;
        public double solde;
        private double plafondBas = -100;
        private double plafondHaut = 5000;
        private Client client;
        private List<Operation> operationList;

        public int Id { get => id;}
        public double Solde { get => solde; set => solde = value; }
        internal Client Client { get => client; set => client = value; }
        internal List<Operation> OperationList { get => operationList; set => operationList = value; }
        public double PlafondBas { get => plafondBas; set => plafondBas = value; }
        public double PlafondHaut { get => plafondHaut; set => plafondHaut = value; }

        public Compte(double solde, Client client)
        {
            this.id = ++idCounter;
            this.solde = solde;
            this.client = client;
            this.operationList = new List<Operation>();
        }
        public virtual void ToString()
        {
            Helpers.ToGreen($"Le compte a été ajouté avec succès à l'id {id}");
        }

        public virtual void DisplayOperations()
        {
            string chaine = "";
            int i = 0;
            foreach (Operation op in operationList)
            {
                chaine += $"\n\tId: {++i}, ";
                chaine += op.ToString();
            }
            Console.WriteLine( chaine );
        }
        public virtual void AddInterest()
        {
            Helpers.ToRed($"Le compte d'id {id} existe mais n'est pas un compte épargne et n'a donc pas de taux d'intérêt. Réessayez avec un autre numéro de compte : ");
        }
        public virtual void Depot(Operation op)
        {
            //if (Solde + op.Montant >= plafondHaut)
            //{
            //    ActionNotificationLimiteAtteinte?.Invoke(this, EventArgs.Empty);
            //}
            //else
            //{
                operationList.Add(op);
                this.solde += op.Montant;
            //}
        }
        public virtual void Retrait(Operation op)
        {
            //if (Solde - op.Montant <= plafondBas)
            //{
            //    ActionNotificationLimiteAtteinte?.Invoke(op, EventArgs.Empty);
            //}
            //else
            //{
                operationList.Add(op);
                this.solde -= op.Montant;
            //}
        }

        //public event EventHandler ActionNotificationLimiteAtteinte += compte.OnActionNotificationLimiteAtteinte;
        //private void OnActionNotificationLimiteAtteinte(Operation op, EventArgs e)
        //{
        //    Console.WriteLine("Limite atteinte !");
        //}
        //compte.ActionNotificationLimiteAtteinte += compte.OnActionNotificationLimiteAtteinte;

    }
}
