double maxi = 0;
double mini = 20;
double total = 0;
double nbNoteTotal = 0;

Console.WriteLine($"Notes élèves : \n");

int choix;
do
{
    Console.WriteLine($"Gestion des notes avec menu\n\n\t1---Saisir notes\n\t2---Voir la plus grande note\n\t3---Voir la plus petite note\n\t4---Voir la moyenne\n\t0---Quitter");
    choix = Convert.ToInt16(Console.ReadLine());
    Console.Clear();
    if (choix == 1)
    {
        Console.WriteLine($"Il y a actuellement {nbNoteTotal} notes enregistrée.s.\nCombien de note devez vous entrer ?");
        int nbNote = Convert.ToInt16(Console.ReadLine());
        while (Double.IsNaN(nbNote) || nbNote < 2)
        {
            Console.WriteLine("Vous n'avez pas saisi un nombre de note valide, réessayez !");
            nbNote = Convert.ToInt16(Console.ReadLine());
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"----------- Saisir les notes : \"-----------\n999 pour arréter....");
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 1; i <= nbNote; i++)
        {
            Console.Write($"Merci de saisir la note {i} : ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (i == nbNote) nbNoteTotal += i;
            else if (x == 999)
            {
                nbNoteTotal += i - 1;
                break;
            }

            while (Double.IsNaN(x) || x < 0 || x > 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Vous n'avez pas saisi une note valide. Essayez de nouveau d'entrer la note {i} : ");
                Console.ForegroundColor = ConsoleColor.White;
                x = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"{x}");

            if (x <= mini) mini = x;
            if (x >= maxi) maxi = x;
            total += x;
        }
        Console.Clear();
    }
    if (choix == 2)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"----------- La plus grande note : \"-----------\n\t La plus grande note est {maxi}\n\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
    if (choix == 3)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"----------- La plus petite note : \"-----------\n\t La plus petite note est {mini}\n\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
    if (choix == 4)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"----------- La moyenne : \"-----------\n\t La moyenne des notes est {Math.Round((total /= nbNoteTotal) * 100) / 100}\n\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

} while (choix != 0);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Le menu de note a été fermé.");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Appuyez sur une touche pour fermer le programme");
Console.Read();