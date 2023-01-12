using com.sun.xml.@internal.bind.v2.model.core;
using java.io;
using sun.net.www.content.image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace _06__banque.Classes
{
    internal class Ihm
    {
        Banque banque = new();
        public void Start()
        {
            Console.WriteLine("Démarrage de l'application...");
            banque.InjecterData();
            Helpers.ToBlue("\n---------- Banque Peu Populaire ----------");
            Menu();
        }

        public void Menu()
        {
            int choix;
            do
            {
                Helpers.ToBlue("\n    ------ Menu principal ------    ");
                Console.WriteLine($"\n\t1/ Création de compte.\n\t2/ Dépôt.\n\t3/ Retrait.\n\t4/ Historique.\n\t5/ Calcul des Interêts.\n\t0/ Quitter.");

                while (!Int32.TryParse(Console.ReadLine(), out choix) || (choix < 0) || (choix > 5)) Console.Write("Erreur, réessayez : ");
                Console.Clear();

                switch (choix)
                {
                    case 0:
                        Stop();
                        break;
                    case 1:
                        {

                            #region creation client

                            Helpers.ToBlue("\n    ------ Création client ------    ");
                            Console.Write("Nom : ");
                            string nom = Console.ReadLine();
                            while (!Helpers.IsLastName(nom))
                            {
                                Console.Write("Le nom n'est pas valide, veuillez réessayer : ");
                                nom = Console.ReadLine();
                            }

                            Console.Write("Prénom : ");
                            string prenom = Console.ReadLine();
                            while (!Helpers.IsFirstName(prenom))
                            {
                                Console.Write("Le prenom n'est pas valide, veuillez réessayer : ");
                                prenom = Console.ReadLine();
                            }

                            Console.Write("Numéro de téléphone : ");
                            string tl = Console.ReadLine();
                            while (!Helpers.IsPhoneNumber(tl))
                            {
                                Console.WriteLine("\nLe numéro de téléphone n'est pas valide, veuillez réessayer avec l'un de ces formats :\n\t+33 6 05 04 05 08\n\t06 06 05 06 04\n\t+336 0504 0508\n\t0606 0506 04");
                                tl = Console.ReadLine();
                            }
                            Client tmpclient = new(nom, prenom, tl);
                            if (banque.AjouterClient(tmpclient)) tmpclient.ToString();

                            #endregion

                            #region creation compte

                            Helpers.ToBlue("\n    ------ Création compte ------    ");
                            double soldeinit;
                            Helpers.ToCyan("Solde initial : ");
                            while (!Double.TryParse(Console.ReadLine(), out soldeinit) || soldeinit < 0) Console.WriteLine("Erreu de saisie, réessayez : ");
                            Console.WriteLine($"\n\nType de compte.\n\t1/ Normal.\n\t2/ Epargne.\n\t3/ Payant.");
                            int choixCompte;
                            while (!Int32.TryParse(Console.ReadLine(), out choixCompte) || (choixCompte < 1) || (choixCompte > 3)) Console.Write("Erreur, réessayez : ");

                            #region case choix compte

                            switch (choixCompte)
                            {
                                case 1:
                                    {
                                        Compte tmpcompte = new(soldeinit, tmpclient);
                                        if (banque.AjouterCompte(tmpcompte)) tmpcompte.ToString();
                                    }
                                    break;
                                case 2:
                                    {
                                        Helpers.ToCyan("Entrez le taux du compte en %. Il devra être compris entre 0 et 10% : ");
                                        double taux;
                                        while (!double.TryParse(Console.ReadLine(), out taux) || (taux < 0 && taux > 10)) Console.Write("Erreur, réessayez : ");
                                        CompteEpargne tmpcompte = new(soldeinit, tmpclient, taux);
                                        if (banque.AjouterCompte(tmpcompte)) tmpcompte.ToString();
                                    }
                                    break;
                                case 3:
                                    {
                                        Helpers.ToCyan("Entrez le coût de transaction pour chaque opération du compte. Il devra être compris entre 0 et 5 euros : ");
                                        double cout;
                                        while (!double.TryParse(Console.ReadLine(), out cout) || (cout < 0 && cout > 5)) Console.Write("Erreur, réessayez : ");
                                        ComptePayant tmpcompte = new(soldeinit, tmpclient, cout);
                                        if (banque.AjouterCompte(tmpcompte)) tmpcompte.ToString();
                                    }
                                    break;
                            }

                            #endregion

                            #endregion

                        };
                        break;
                    case 2:
                        {

                            #region depot d'argent

                            Helpers.ToBlue("------- Déposer des fonds ------");
                            Helpers.ToCyan("Numéro de compte : ");
                            int tmpid;

                            do
                            {
                                while (!Int32.TryParse(Console.ReadLine(), out tmpid) || tmpid < 0) Console.Write("Saisie invalide, réessayez : ");
                                if (banque.RechercherCompte(tmpid) != null)
                                {
                                    Helpers.ToGreen("Montant dépôt : ");
                                    double montant;
                                    while (!Double.TryParse(Console.ReadLine(), out montant) || montant < 0 || montant > 10000) Console.Write("Saisie invalide, réessayez : ");
                                    Operation tmpOperation = new(montant);
                                    banque.RechercherCompte(tmpid).Depot(tmpOperation);
                                    Helpers.ToCyan($"Un montant de : {montant} euros a été ajouté au compte numéro {tmpid} appartenant à {banque.RechercherCompte(tmpid).Client.Nom} {banque.RechercherCompte(tmpid).Client.Prenom}");
                                }
                                else
                                {
                                    Helpers.ToRed($"L'id de compte {tmpid} n'est lié à aucun compte, réessayez : ");
                                }
                            } while (banque.RechercherCompte(tmpid) == null);


                            #endregion

                        }
                        break;
                    case 3:
                        {

                            #region retrait d'argent

                            Helpers.ToBlue("------- Retirer des fonds ------");
                            Helpers.ToCyan("Numéro de compte : ");
                            int tmpid;

                            do
                            {
                                while (!Int32.TryParse(Console.ReadLine(), out tmpid) || tmpid < 0) Console.Write("Saisie invalide, réessayez : ");
                                if (banque.RechercherCompte(tmpid) != null)
                                {
                                    Helpers.ToGreen("Montant retrait : ");
                                    double montant;
                                    while (!Double.TryParse(Console.ReadLine(), out montant) || montant < 0 || montant > 10000) Console.Write("Saisie invalide, réessayez : ");
                                    Operation tmpOperation = new(-montant);
                                    banque.RechercherCompte(tmpid).Retrait(tmpOperation);
                                    Helpers.ToCyan($"Un montant de : {montant} euros a été retiré au compte numéro {tmpid} appartenant à {banque.RechercherCompte(tmpid).Client.Nom} {banque.RechercherCompte(tmpid).Client.Prenom}");
                                }
                                else
                                {
                                    Helpers.ToRed($"L'id de compte {tmpid} n'est lié à aucun compte, réessayez : ");
                                }
                            } while (banque.RechercherCompte(tmpid) == null);


                            #endregion

                        }
                        break;
                    case 4:
                        {

                            #region Historique des Transactions

                            Helpers.ToBlue("------- Historique des Transactions ------");
                            Helpers.ToCyan("Numéro de compte : ");
                            int tmpid;

                            do
                            {
                                while (!Int32.TryParse(Console.ReadLine(), out tmpid) || tmpid < 0) Console.Write("Saisie invalide, réessayez : ");
                                if (banque.RechercherCompte(tmpid) != null)
                                {
                                    Helpers.ToCyan($"Le compte numéro {tmpid} appartient à {banque.RechercherCompte(tmpid).Client.Nom} {banque.RechercherCompte(tmpid).Client.Prenom}");
                                    if(banque.RechercherCompte(tmpid).Solde >= 0) Helpers.ToGreen($"solde : {banque.RechercherCompte(tmpid).Solde}");
                                        else Helpers.ToRed($"solde : {banque.RechercherCompte(tmpid).Solde}");
                                    banque.RechercherCompte(tmpid).DisplayOperations();

                                }
                                else
                                {
                                    Helpers.ToRed($"L'id de compte {tmpid} n'est lié à aucun compte, réessayez : ");
                                }
                            } while (banque.RechercherCompte(tmpid) == null);

                            #endregion

                        }
                        break;
                    case 5:
                        {

                            #region attribution des intérêts

                            Helpers.ToBlue("------- Attribution des intérêts ------");
                            Helpers.ToCyan("Numéro de compte : ");
                            int tmpid;

                            do
                            {
                                while (!Int32.TryParse(Console.ReadLine(), out tmpid) || tmpid < 0) Console.Write("Saisie invalide, réessayez : ");
                                
                                if (banque.RechercherCompte(tmpid) != null) banque.RechercherCompte(tmpid).AddInterest();
                                else Helpers.ToRed($"L'id de compte {tmpid} n'est lié à aucun compte, réessayez : ");

                            } while (banque.RechercherCompte(tmpid) == null || !(banque.RechercherCompte(tmpid) is CompteEpargne));  // !(banque.RechercherCompte(tmpid).GetType() == typeof(CompteEpargne))

                            #endregion

                        }
                        break;
                }
            } while (choix != 0);
        }

        public void Stop()
        {
            Console.WriteLine("\nAppuyez sur une touche pour fermer l'application.");
            Console.Read();
        }
    }
}
