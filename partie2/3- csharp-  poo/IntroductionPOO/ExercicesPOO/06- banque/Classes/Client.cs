using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__banque.Classes
{
    public class Client
    {
        private static int idCounter = 0;
        public readonly int id;
        private string nom;
        private string prenom;
        private string tel;

        public int Id { get => id; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }
        public Client(string n, string pn, string tl)
        {
            this.id = ++idCounter;
            this.nom = n;
            this.prenom = pn;
            this.tel = tl;
        }
        public void ToString()
        {
            Helpers.ToGreen($"Le client {nom} {prenom} a été ajouté avec succès à l'id {id}");
        }
    }
}
