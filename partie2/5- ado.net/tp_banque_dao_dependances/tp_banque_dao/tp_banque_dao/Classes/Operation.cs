﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_banque_dao.Classes
{
    public class Operation
    {
        private int id;
        private decimal montant;
        private int idCompte;
        private DateTime dateOperation;
        private static int counter = 0;

        public Operation(decimal montant)
        {
            Id = ++counter;
            Montant = montant;
            DateOperation = DateTime.Now;
        }

        public Operation(decimal montant, int idCompte)
        {
            Id = ++counter;
            Montant = montant;
            IdCompte = idCompte;
            DateOperation = DateTime.Now;
        }

        public Operation(int id, int idCompte, DateTime date, decimal montant)
        {
            Id = id;
            IdCompte = idCompte;
            Montant = montant;
            DateOperation = date;
        }

        public int Id { get => id; set => id = value; }
        public int IdCompte { get => idCompte; set => idCompte = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public DateTime DateOperation { get => dateOperation; set => dateOperation = value; }

        public override string ToString()
        {
            return $"Id:{(Id < 10 ? "0" + Id : Id)}, Date:{DateOperation}";
        }
    }
}