using com.sun.security.ntlm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__banque.Classes
{
    public class Banque
    {
        private List<Compte> comptes;
        private List<Client> clients;
        public Banque()
        {
            Comptes = new List<Compte>();
            Clients = new List<Client>();
        }

        public List<Compte> Comptes { get => comptes; set => comptes = value; }
        public List<Client> Clients { get => clients; set => clients = value; }

        public void InjecterData()
        {
            Client dataclient = new("Benoit", "Combe", "0605040548");
            Client dataclient2 = new("Maxime", "Letelier", "0605040203");
            Client dataclient3 = new("Seb", "inou", "0605080907");
            //InjecterDataClient(dataclient);
            //InjecterDataClient(dataclient2);
            //InjecterDataClient(dataclient3);
            Compte datacompte = new(1000, dataclient);
            CompteEpargne datacompte2 = new(4500, dataclient2, 5.5);
            ComptePayant datacompte3 = new(6450, dataclient3, 0.45);
            //InjecterDataCompte(datacompte);
            //InjecterDataCompte(datacompte2);
            //InjecterDataCompte(datacompte3);
            InjecterDatas(dataclient, AjouterClient);
            InjecterDatas(dataclient2, AjouterClient);
            InjecterDatas(dataclient3, AjouterClient);
            InjecterDatas(datacompte, AjouterCompte);
            InjecterDatas(datacompte2, AjouterCompte);
            InjecterDatas(datacompte3, AjouterCompte);

            Console.WriteLine($"il y a {Comptes.Count} comptes dans ma liste de compte.");
            Console.WriteLine($"il y a {Clients.Count} clients dans ma liste de client.");
        }
        //private void InjecterDataClient(Client client)
        //{
        //    if (!AjouterClient(client)) Console.WriteLine($"Il y a eu une erreur, le client {client.id} n'a pas été ajouté.");
        //}
        //private void InjecterDataCompte(Compte compte)
        //{
        //    if (!AjouterCompte(compte)) Console.WriteLine($"Il y a eu une erreur, le compte {compte.id} n'a pas été ajouté.");
        //}

        public delegate bool AddItemDelegate<T>(T item); // T : generique, admet tous les types
        private void InjecterDatas<T>(T data, AddItemDelegate<T> addItem)
        {
            if (!addItem(data))
                Console.WriteLine($"Il y a eu une erreur, l'objet {data} n'a pas été ajouté.");
        }
        //private void InjecterDatas(Client client, AddItemDelegate<Client> addItem)
        //{
        //    if (!addItem(client))
        //        Console.WriteLine($"Il y a eu une erreur, le client {client.id} n'a pas été ajouté.");
        //}

        //private void InjecterDatas(Compte compte, AddItemDelegate<Compte> addItem)
        //{
        //    if (!addItem(compte))
        //        Console.WriteLine($"Il y a eu une erreur, le compte {compte.id} n'a pas été ajouté.");
        //}

        // test ----------------------------------------

        public bool AjouterCompte(Compte compte)
        {
            int nbComptesAvantAjout = Comptes.Count;
            Comptes.Add(compte);
            int nbComptesApresAjout = Comptes.Count;

            return nbComptesApresAjout - nbComptesAvantAjout == 1; // vrai si le compte a bien était ajouté.
        }
        public bool AjouterClient(Client client)
        {
            int nbClientsAvantAjout = Clients.Count;
            Clients.Add(client);
            int nbClientsApresAjout = Clients.Count;

            return nbClientsApresAjout - nbClientsAvantAjout == 1; // vrai si le client a bien était ajouté.
        }

        public Compte RechercherCompte(int id)
        {
            return Comptes.Find(x => x.id == id);
        }
    }
}
