using com.sun.xml.@internal.bind.v2.model.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__banque.Classes
{
    public class Operation
    {
        public int id;
        private DateTime transactionDate;
        private double montant;

        public Operation(double montant)
        {
            int tempId = ++id;
            this.id = tempId;
            this.transactionDate = DateTime.Now;
            this.montant = montant;
        }

        public int Id { get => id; }
        public DateTime TransactionDate { get { return this.transactionDate; } set { this.transactionDate = value; } }
        public double Montant { get { return this.montant; } set { this.montant = value; } }
        public override string ToString()
        {
            string chaine = $"Date: {TransactionDate} - Montant : ";
            if (montant >= 0)
            {
                return chaine + $"\u001b[32m{montant} euros.\u001b[0m";
            }
            else
            {
                return chaine + $"\u001b[31m{montant} euros.\u001b[0m";
            }
        }
    }
}
