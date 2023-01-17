// tp avec des listes
var personnes = new List<string> { "Benoit", "Seb", "Simon", "Mack", "cricri", "Nico", "Olivier", "Amandine", "Allison", "l'autre Benoit", "Paul", "Fares", "Sondes", "Max" };
var newpersonnes = new List<string> { };
Random rnd = new Random();
int choix;
do
{
    Console.WriteLine("\n--------- Le grand tirage au sort  ---------\n");
    Console.Write("1/ Effectuer un tirage\n2/ Voir la liste des personnes déjà tirées\n3/ Voir la liste des personnes restantes\n0/ Quitter\nFaites votre choix : ");
    while (!Int32.TryParse(Console.ReadLine(), out choix) || (choix != 0 && choix != 1 && choix != 2 && choix != 3)) Console.WriteLine("Choix invalide, réessayez ! ");

    switch (choix)
    {
        case 1:
            int indexTmp = rnd.Next(personnes.Count);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n--------- Le grand tirage : ---------\n\n {personnes[indexTmp]} a été tiré.e !");
            Console.ForegroundColor = ConsoleColor.White;
            newpersonnes.Add(personnes[indexTmp]);
            personnes.Remove(personnes[indexTmp]);

            break;

        case 2:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n--------- {newpersonnes.Count} personnes sont tranquille : ---------\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string pers in newpersonnes)
            {
                Console.WriteLine(pers);
            }
            break;

        case 3:
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"\n--------- Il reste {personnes.Count} personnes restantes : ---------\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string pers in personnes)
            {
                Console.WriteLine(pers);
            }
            break;
    }
} while (choix != 0);