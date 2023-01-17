using MyEnvironement.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.IHM
{
    internal class IHM
    {
        public void Start()
        {
            Console.WriteLine("Start...");
            Menu();
        }

        public void Menu()
        {
            Console.WriteLine("Type d'adresse:\n\t1/ appartement\n\t2/ maison\n\t0/ quitter");
            int choix;
            while (!int.TryParse(Console.ReadLine(), out choix) || (choix != 0 && choix != 1 && choix != 2)) Console.Write("Choix incorrect, réessayez: ");

            if(choix == 0) WaitUser();
            else
            {
                List<Location> locations = new List<Location>();
                Console.Write("Nom du bien: ");
                string nomBien = Console.ReadLine();

                #region pieces

                Console.WriteLine("Combien de piece");
                int nbpiece = int.Parse(Console.ReadLine());
                for(int y = 1; y <= nbpiece; y++)
                {
                    #region objets

                    Console.WriteLine("Combien de meuble");
                    int nbFurniture = int.Parse(Console.ReadLine());
                    List<Furniture> furnitures = new List<Furniture>();
                    for (int i = 1; i <= nbFurniture; i++)
                    {
                        Console.Write("\tNom du meuble: ");
                        string nom = Console.ReadLine();
                        Furniture meuble = new(i, nom);
                        furnitures.Add(meuble);
                    }

                    Console.WriteLine("Combien d' équipement");
                    int nbEquipement = int.Parse(Console.ReadLine());
                    List<Furniture> Equipements = new List<Furniture>();
                    for (int i = 1; i <= nbEquipement; i++)
                    {
                        Console.Write("\tNom du meuble: ");
                        string nom = Console.ReadLine();
                        Furniture equip = new(i, nom);
                        Equipements.Add(equip);
                    }

                    #endregion
                }



                //public Room(string roomName, List<Furniture> furnitureList, List<Equipment> equipmentList)
                //    Room roomTmp = new()

                #endregion

                #region Owners

                Console.Write("Combien de personne compose le bien : ");
                int nbOwners = int.Parse(Console.ReadLine());
                List<Person> people = new List<Person>();
                for (int i = 1; i <= nbOwners; i++)
                {
                    Console.WriteLine($"informations de la personne {i}: ");
                    Console.WriteLine($"informations de la personne {i}: ");
                    Console.Write("\tGenre: ");
                    string title = Console.ReadLine();
                    Console.Write("\tPrénom: ");
                    string firstname = Console.ReadLine();
                    Console.Write("\tNom: ");
                    string lastname = Console.ReadLine();

                    Console.WriteLine("\tEntrer la date de naissance au format (MM/DD/YYYY):");
                    string dateOfBirthString = Console.ReadLine();
                    DateTime dateOfBirth;
                    while (!DateTime.TryParse(dateOfBirthString, out dateOfBirth))
                    {
                        Console.Write("\t\tEntrée non valide, veuillez réessayer:");
                        dateOfBirthString = Console.ReadLine();
                    }

                    Person person = new(i, title, firstname, lastname, dateOfBirth);
                    people.Add(person);
                }

                #endregion

                #region Address

                Console.Write("Id du bien: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Numéro de voie: ");
                int homeNumber = int.Parse(Console.ReadLine());
                Console.Write("Nom de la voie: ");
                string roadName = Console.ReadLine();
                Console.Write("Code postal: ");
                int zipCode = int.Parse(Console.ReadLine());
                Console.Write("Ville: ");
                string city = Console.ReadLine();
                Console.Write("Etat: ");
                string state = Console.ReadLine();
                Console.Write("Pays: ");
                string country = Console.ReadLine();
                if (choix == 1)
                {
                    Console.Write("Id de l'appartement: ");
                    int idAppart = int.Parse(Console.ReadLine());
                    Console.Write("Numéro d'entrée: ");
                    int entryNumber = int.Parse(Console.ReadLine());
                    Console.Write("Etage: ");
                    int floor = int.Parse(Console.ReadLine());
                    Console.Write("Numéro de porte: ");
                    int doorNumber = int.Parse(Console.ReadLine());
                    FlatAddress flatAddress = new(id, homeNumber, roadName, zipCode, city, state, country, idAppart, entryNumber, floor, doorNumber);
                    //locations.Add(new Flat(nomBien, flatAddress, people, ));
                    //public Flat(nomBien, FlatAddress address, List<Person> owners, List<Room> rooms)
                }
                else
                {
                    HouseAddress houseAddress1 = new(id, homeNumber, roadName, zipCode, city, state, country);
                    HouseAddress houseAddress = houseAddress1;
                }

                #endregion
            }
        }

        public void WaitUser()
        {
            Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
            Console.Read();
        }
    }
}
