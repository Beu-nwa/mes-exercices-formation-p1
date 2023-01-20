using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpContacts.Classes;
using TpContacts.DAO;

namespace TpContacts
{
    public class IHM
    {
        PersonDAO _daoPerson;
        ContactDAO _daoContact;
        AddressDAO _daoAddress;
        Contact_Address_DAO _daoContact_Address;
        public IHM()
        {

        }
        public void Start()
        {
            int choix;
            do
            {
                Console.WriteLine($"app contacts :");
                Console.WriteLine($"\t 1/ Ajouter\t 2/ Modifier \t 3/ Supprimer \t 4/ Trouver \t 0/ quitter");
                while (!Int32.TryParse(Console.ReadLine(), out choix) || (choix < 0) || (choix > 4)) Console.Write("Erreur, réessayez : ");
                Console.Clear();
                switch (choix)
                {
                    case 1:
                        {
                            AddContact();
                        }
                        break;
                    case 2:
                        {
                            UpdateContact();
                        }
                        break;
                    case 3:
                        {
                            DeleteContact();
                        }
                        break;
                    case 4:
                        {
                            FindContact();
                        }
                        break;
                }
            } while (choix != 0);

            Close();
        }

        private void AddContact()
        {
            _daoPerson = new();
            _daoContact = new();
            _daoAddress = new();
            _daoContact_Address = new();
            int day = 0, month = 0, year = 0;
            Person p = new();
            Address ad = new();
            Contact c = new();
            Contact_Address c_ad = new();

            // person : firstname, lastname, date of birth
            Console.WriteLine("Personne : ");
            TryRead("Veuillez saisir le nom : ", () => p.Lastname = Console.ReadLine());
            TryRead("Veuillez saisir le prénom : ", () => p.Firstname = Console.ReadLine());
            TryRead("Veuillez saisir le jour de naissance : ", () => day = Convert.ToInt32(Console.ReadLine()));
            TryRead("Veuillez saisir le mois de naissance : ", () => month = Convert.ToInt32(Console.ReadLine()));
            TryRead("Veuillez saisir l'année de naissance : ", () => year = Convert.ToInt32(Console.ReadLine()));
            // contact : contact_address, phone_number, email;
            Console.WriteLine("Contact : ");
            TryRead("Veuillez saisir le numéro de téléphone : ", () => c.Phone_number = Console.ReadLine());
            TryRead("Veuillez saisir l' email : ", () => c.Email = Console.ReadLine());
            // address : number, road, post_code, country
            Console.WriteLine("Adresse : ");
            TryRead("Veuillez saisir le numéro de l'adresse : ", () => ad.Number = Console.ReadLine());
            TryRead("Veuillez saisir la voie : ", () => ad.Road = Console.ReadLine());
            TryRead("Veuillez saisir le code postal : ", () => ad.Post_code = Console.ReadLine());
            TryRead("Veuillez saisir la ville : ", () => ad.Town = Console.ReadLine());
            TryRead("Veuillez saisir le pays : ", () => ad.Country = Console.ReadLine());
            // add person
            p.Dateofbirth = new DateTime(year, month, day);
            p.Person_id = _daoPerson.Create(p);
            // c.Person_id = p.Person_id;
            // c.Firstname = p.Firstname;
            // c.Lastname = p.Lastname;
            // c.Dateofbirth = p.Dateofbirth;

            // add address et bind_table
            (bool address_found, int aid) = _daoAddress.Find(ad);
            if (!address_found) // find = false, l'adresse n'existe pas, la créer
            {
                aid = _daoAddress.Create(ad); // retourne l'id de l'adresse créée
                Console.WriteLine($"Nouvelle adresse créée à l'id {aid}");
            }
            else Console.WriteLine($"L'adresse existait déjà à l'id {aid}");
            ad.Address_id = aid;
            c.Contact_address = ad;
            _daoContact_Address.Create(c.Contact_id, ad.Address_id); // ajout du lien entre l'adresse et le contact dans la bdd
            //c_ad.Address_id = ad.Address_id;
            //c_ad.Contact_id = c.Contact_id;

            // add contact
            c.Contact_id = _daoContact.Create(c); // ajout du contact dans la bdd (sans son adresse)

            Console.Clear();
            Console.WriteLine($"------- Contact ajouté \"-------");
            Console.WriteLine($"IDS     : id_person : {p.Person_id}, id_contact : {c.Contact_id}");
            Console.WriteLine($"PERSON  : nom : {p.Lastname}, prénom : {p.Firstname}, date de naissance : {p.Dateofbirth}");
            Console.WriteLine($"CONTACT : email : {c.Email}, téléphone : {c.Phone_number}");
            Console.WriteLine($"ADRESSE (id:{ad.Address_id}) : {ad.Number} {ad.Road} {ad.Post_code} {ad.Town} {ad.Country}");
            Console.WriteLine($"---------------------------------");
        }

        private void UpdateContact()
        {
            _daoPerson = new();
            _daoContact = new();
            _daoAddress = new();
            _daoContact_Address = new();
            int tmp_id = 0;
            TryRead("Quel est l'id du contact que vous voulez mettre à jour ?", () => tmp_id = Convert.ToInt32(Console.ReadLine()));
            (bool found, Contact tmpContact) = _daoContact.Find(tmp_id);
            Person tmpPerson = new();
            Address tmpAddress = new();
            if (found)
            {
                tmpPerson.Person_id = tmpContact.Person_id;
                tmpPerson.Firstname = tmpContact.Firstname;
                tmpPerson.Lastname = tmpContact.Lastname;
                tmpAddress.Address_id = tmpContact.Contact_address.Address_id;
                tmpAddress.Number = tmpContact.Contact_address.Number;
                tmpAddress.Road = tmpContact.Contact_address.Road;
                tmpAddress.Post_code = tmpContact.Contact_address.Post_code;
                tmpAddress.Town = tmpContact.Contact_address.Town;
                tmpAddress.Country = tmpContact.Contact_address.Country;
                int confirm_update_type = 0;
                int confirm_update = 0;
                TryRead($"changer un élement de PERSON (nom, prénom); 0:non ou 1:oui", () => confirm_update_type = Convert.ToInt32(Console.ReadLine()));
                if (confirm_update_type == 1)
                {
                    // changer prénom
                    TryRead($"changer le prénom {tmpPerson.Firstname}, 0:non ou 1:oui", () => confirm_update = Convert.ToInt32(Console.ReadLine()));
                    if (confirm_update == 1)
                    {
                        tmpPerson.Firstname = Console.ReadLine();
                        confirm_update = 0;
                    }
                    // changer nom
                    TryRead($"changer le nom {tmpPerson.Lastname}, 0:non ou 1:oui", () => confirm_update = Convert.ToInt32(Console.ReadLine()));
                    if (confirm_update == 1)
                    {
                        tmpPerson.Lastname = Console.ReadLine();
                        confirm_update = 0;
                    }
                    confirm_update_type = 0;
                    _daoPerson.Update(tmpPerson);
                }

                TryRead($"changer un élement de CONTACT (tel, email); 0:non ou 1:oui", () => confirm_update_type = Convert.ToInt32(Console.ReadLine()));
                if (confirm_update_type == 1)
                {
                    // changer numéro de telephone
                    TryRead($"changer le numéro de téléphone {tmpContact.Phone_number}, 0:non ou 1:oui", () => confirm_update = Convert.ToInt32(Console.ReadLine()));
                    if (confirm_update == 1)
                    {
                        tmpContact.Phone_number = Console.ReadLine();
                        confirm_update = 0;
                    }
                    // changer email
                    TryRead($"changer l'email {tmpContact.Email}, 0:non ou 1:oui", () => confirm_update = Convert.ToInt32(Console.ReadLine()));
                    if (confirm_update == 1)
                    {
                        tmpContact.Email = Console.ReadLine();
                        confirm_update = 0;
                    }
                    confirm_update_type = 0;
                    _daoContact.Update(tmpContact);
                }

                TryRead($"changer un élement de ADDRESS (numéro, voie, code-postal, ville, pays); 0:non ou 1:oui", () => confirm_update_type = Convert.ToInt32(Console.ReadLine()));
                if (confirm_update_type == 1)
                {
                    Console.WriteLine($"L'adresse d'id {tmpAddress.Address_id} est liée à {_daoContact_Address.Count(tmpAddress.Address_id)} contact-s");
                        // changer numéro adresse
                        TryRead($"changer le numéro de l'adresse {tmpAddress.Number}, 0:non ou 1:oui", () => confirm_update = Convert.ToInt32(Console.ReadLine()));
                        if (confirm_update == 1)
                        {
                            tmpAddress.Number = Console.ReadLine();
                            confirm_update = 0;
                        }
                        // changer la voie
                        TryRead($"changer la voie {tmpAddress.Road}, 0:non ou 1:oui", () => confirm_update = Convert.ToInt32(Console.ReadLine()));
                        if (confirm_update == 1)
                        {
                            tmpAddress.Road = Console.ReadLine();
                            confirm_update = 0;
                        }
                        // changer le code postal
                        TryRead($"changer le code postal {tmpAddress.Post_code}, 0:non ou 1:oui", () => confirm_update = Convert.ToInt32(Console.ReadLine()));
                        if (confirm_update == 1)
                        {
                            tmpAddress.Post_code = Console.ReadLine();
                            confirm_update = 0;
                        }
                        // changer la ville
                        TryRead($"changer la ville {tmpAddress.Town}, 0:non ou 1:oui", () => confirm_update = Convert.ToInt32(Console.ReadLine()));
                        if (confirm_update == 1)
                        {
                            tmpAddress.Town = Console.ReadLine();
                            confirm_update = 0;
                        }
                        // changer le pays
                        TryRead($"changer le pays {tmpAddress.Country}, 0:non ou 1:oui", () => confirm_update = Convert.ToInt32(Console.ReadLine()));
                        if (confirm_update == 1)
                        {
                            tmpAddress.Country = Console.ReadLine();
                            confirm_update = 0;
                        }
                    if (_daoContact_Address.Count(tmpAddress.Address_id) == 1)
                    {
                        // contact unique pour l'adresse, pas de pb
                        Console.WriteLine($"Un seul contact ({_daoContact_Address.Count(tmpAddress.Address_id)}) est lié à l'adresse d'id {tmpAddress.Address_id}");
                        _daoAddress.Update(tmpAddress);
                        Console.WriteLine($"----- Adresse modifiée. Conserve l'id {tmpAddress.Address_id} ------");
                    }
                    else
                    {
                        // plusieurs contacts pour l'adresse :
                        Console.WriteLine($"Plusieurs contacts ({_daoContact_Address.Count(tmpAddress.Address_id)}) sont liés à l'adresse d'id {tmpAddress.Address_id}");
                        Contact_Address tmp_bind_c_a = new();
                        tmp_bind_c_a.Address_id = _daoAddress.Create(tmpAddress);
                        tmp_bind_c_a.Contact_id = tmpContact.Contact_id ;
                        _daoContact_Address.Update(tmp_bind_c_a);
                        Console.WriteLine($"----- Adresse modifiée à l'id {tmp_bind_c_a.Address_id} ------");
                    }
                    confirm_update_type = 0;
                    Console.WriteLine($"Nouvelle adresse : {tmpAddress.Number} {tmpAddress.Road} {tmpAddress.Post_code} {tmpAddress.Town} {tmpAddress.Country}");
                    Console.WriteLine($"---------------------------------------------");
                }

            }
            else { Console.WriteLine($"Aucun contact trouvé à l'id {tmp_id}"); }
        }

        private void DeleteContact()
        {
            _daoPerson = new();
            _daoContact = new();
            _daoContact_Address = new();
            _daoAddress = new();
            int tmp_id = 0;
            TryRead("Veuillez saisir l' id du contact à supprimer : ", () => tmp_id = Convert.ToInt32(Console.ReadLine()));
            (bool found, Contact tmpContact) = _daoContact.Find(tmp_id);
            if (found)
            {
                Console.WriteLine($"Êtes-vous sur de vouloir supprimer le contact : ");
                Console.WriteLine($"contact_id : {tmpContact.Contact_id}, nom_complet : {tmpContact.Firstname}, {tmpContact.Lastname}");
                // find le contact avec le tmp_id pour trouver le preson_id et le address_id
                Console.Write("Appuyer sur 0 pour confirmer la suppression, sinon entrer un autre chiffre : ");
                int deleteChoice = Convert.ToInt16(Console.ReadLine());
                if (deleteChoice == 0)
                {
                    // delete pour chaque type
                    // del person
                    if (_daoPerson.Delete(tmpContact.Person_id)) Console.WriteLine("del person success");
                    else Console.WriteLine("del person failure");
                    // del contact
                    if (_daoContact.Delete(tmpContact.Contact_id)) Console.WriteLine("del contact success");
                    else Console.WriteLine("del contact failure");
                    // del bind
                    if (_daoContact_Address.Delete(tmpContact.Contact_id)) Console.WriteLine("del bind-c/a success");
                    else Console.WriteLine("del bind-c/a failure");
                    // del address avec condition 
                    if (_daoContact_Address.Count(tmpContact.Contact_address.Address_id) != 1)
                    {
                        if (_daoAddress.Delete(tmpContact.Contact_address.Address_id)) Console.WriteLine("del address success");
                        else Console.WriteLine("del address failure");
                    }
                    else Console.WriteLine("d'autres contact utilisent cette adresse, elle n'a donc pas été supprimé");
                }
                else Console.WriteLine("Action de suppression annulé.");
            }
            else { Console.WriteLine($"Aucun contact trouvé à l'id {tmp_id}"); }
        }

        private void FindContact()
        {
            _daoContact = new();
            _daoContact_Address = new();
            int tmp_id = 0;
            TryRead("Veuillez saisir l' id du contact à afficher : ", () => tmp_id = Convert.ToInt32(Console.ReadLine()));
            (bool found, Contact c) = _daoContact.Find(tmp_id);
            if (found)
            {
                Console.WriteLine($"---------- contact trouvé : \"----------");
                Console.WriteLine($"\tid :{c.Contact_id}");
                Console.WriteLine($"\tnom :{c.Lastname}");
                Console.WriteLine($"\tprénom :{c.Firstname}");
                Console.WriteLine($"\tdate de naissance :{c.Dateofbirth}");
                Console.WriteLine($"\temail :{c.Email}");
                Console.WriteLine($"\ttel :{c.Phone_number}");
                Console.WriteLine($"-----------------------------------------");
                Console.WriteLine($"Adresse : {c.Contact_address.Number} {c.Contact_address.Road} {c.Contact_address.Post_code} {c.Contact_address.Road} {c.Contact_address.Country}");
                Console.WriteLine($"nombre de contact associés à l'adresse : {_daoContact_Address.Count(c.Contact_address.Address_id)}");

            }
            else Console.WriteLine($"Aucun contact trouvé à l'id {tmp_id}");
        }

        private void TryRead(string message, Action ReadElement)
        {
            bool valid = false;
            do
            {
                Console.WriteLine(message);
                try
                {
                    ReadElement();
                    valid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!valid);
        }

        public void Close()
        {
            Console.WriteLine("Fermer le programme...");
            Console.Read();
        }

    }
}
