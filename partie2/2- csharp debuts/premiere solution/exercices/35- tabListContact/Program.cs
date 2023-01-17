using _35__tabListContact;
class Program
{
    static void Main(string[] args)
    {
        Contact[] contacts = null;
        int choix;
        do
        {

            Console.WriteLine($"-------- Ma liste de contacts \"--------");
            Console.WriteLine($"1/ Saisir des contacts\n2/ Afficher mes contacts\n0/ Quitter");
            Console.WriteLine("Faites votre choix");

            while (!Int32.TryParse(Console.ReadLine(), out choix) || (choix != 0 && choix != 1 && choix != 2)) Console.WriteLine("Erreur de saisie ! Faites votre choix");
            Console.Clear();
            switch (choix)
            {
                case 1:
                    #region saisie user contacts

                    Console.Write($"Combien de contacts voulez-vous entrer ?");
                    int numberOfContacts;
                    while (!Int32.TryParse(Console.ReadLine(), out numberOfContacts)) Console.Write("Mauvaise saisie ! Combien de contacts voulez-vous entrer ? ");
                    contacts = new Contact[numberOfContacts];

                    for (int i = 0; i < numberOfContacts; i++)
                    {
                        Console.WriteLine($"\ncontact {i + 1} :");
                        Console.Write($"\t\tnom :");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write($"\t\tPrénom :");
                        string firstName = Convert.ToString(Console.ReadLine());
                        contacts[i] = new Contact(i+1 ,name, firstName);
                    }

                    #endregion
                    Console.Clear();
                    ;
                    break;
                case 2:
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine($"------ Affichage des contacts ------");
                    Console.ForegroundColor = ConsoleColor.White;

                    #region display contacts

                    foreach (Contact contact in contacts)
                    {
                        Console.WriteLine($"Contact n°{contact.Id} : {contact.Name} {contact.FirstName}");
                    }

                    #endregion
                    Console.WriteLine($"\t\t");
                    break;
                case 0:
                    Environment.Exit(0);
                    ;
                    break;
            }
        } while (choix != 0);
    }
}