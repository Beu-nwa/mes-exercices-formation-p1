double maxi = 0;
double mini = 20;
double total = 0;
double nbNoteTotal = 0;
int choix;

Console.WriteLine($"Notes élèves : \n");

do
{
    Console.WriteLine($"Gestion des notes avec menu\n\n\t1---Saisir notes\n\t2---Voir la plus grande note\n\t3---Voir la plus petite note\n\t4---Voir la moyenne\n\t0---Quitter");
    while (!Int32.TryParse(Console.ReadLine(), out choix))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Il faut sasir un chiffre !");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.Clear();
    switch (choix)
    {
        case 1:
            {
                Console.WriteLine($"Il y a actuellement {nbNoteTotal} notes enregistrée.s.\nCombien de note devez vous entrer ?");
                int nbNote;
                while (!Int32.TryParse(Console.ReadLine(), out nbNote) || nbNote < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Vous n'avez pas saisi un nombre de note valide, réessayez !");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"----------- Saisir les notes : \"-----------\n999 pour arréter....");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 1; i <= nbNote; i++)
                {
                    Console.Write($"Merci de saisir la note {i} : ");
                    double x;
                    while (!Double.TryParse(Console.ReadLine(), out x) || x < 0 || x > 20 && x!=999)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Vous n'avez pas saisi une note valide, réessayez d'entrer la note {i} !");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (x == 999)
                    {
                        nbNoteTotal += i - 1;
                        break;
                    }
                    else if (i == nbNote) nbNoteTotal += i;
                    Console.WriteLine($"{x}");
                    if (x <= mini) mini = x;
                    if (x >= maxi) maxi = x;
                    total += x;
                }
                Console.Clear();
            }
            break;
        case 2 :
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                if (total != 0) Console.WriteLine($"----------- La plus grande note : \"-----------\n\t La plus grande note est {maxi}\n\n");
                else Console.WriteLine($"----------- La plus grande note : \"-----------\n\t Il ne peut pas il y avoir de plus grande note sans note !\n\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            break;
        case 3:
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                if (total != 0) Console.WriteLine($"----------- La plus petite note : \"-----------\n\t La plus petite note est {mini}\n\n");
                else Console.WriteLine($"----------- La plus petite note : \"-----------\n\t Il ne peut pas il y avoir de plus petite note sans note !\n\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            break;
        case 4:
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                if (total != 0) Console.WriteLine($"----------- La moyenne : \"-----------\n\t total : {total} La moyenne des notes est {Math.Round((total /= nbNoteTotal) * 100) / 100}\n\n");
                else Console.WriteLine($"----------- La moyenne : \"-----------\n\t Il ne peut pas il y avoir de moyenne sans note !\n\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            break;
        case 0:
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vous avez fermé le menu...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            break;
        default:
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Cas invalide ! Choisissez entre 0, 1, 2, 3 et 4...\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            break;
    }
} while (choix != 0);

// Environment.Exit(0);
// Console.WriteLine("Appuyez sur une touche pour fermer le programme");
// Console.Read();