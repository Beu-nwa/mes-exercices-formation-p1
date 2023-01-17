// tp avec tableaux
string[] datas = { "Benoit", "Seb", "Simon", "Mack", "cricri", "Nico", "Olivier", "Amandine", "Allison", "l'autre Benoit", "Paul", "Fares", "Sondes", "Max"};
string[] restants = new string[datas.Length];
Array.Copy(datas, restants, datas.Length);
//string[] personnes = { "Benoit", "Seb", "Simon", "Mack", "cricri", "Nico", "Olivier", "Amandine", "Allison", "l'autre Benoit", "Paul", "Fares", "Sondes", "Max"};
//string[] newpersonnes = new string[personnes.Length];
string[] gagnants = new string[0];
//Random rnd = new Random();
int choix;
do
{
    Console.WriteLine("\n--------- Le grand tirage au sort  ---------\n");
    Console.Write("1/ Effectuer un tirage\n2/ Voir la liste des personnes déjà tirées\n3/ Voir la liste des personnes restantes\n4/ Réinitialiser\n0/ Quitter\nFaites votre choix : ");
    while (!Int32.TryParse(Console.ReadLine(), out choix) || (choix != 0 && choix != 1 && choix != 2 && choix != 3 && choix != 4)) Console.WriteLine("Choix invalide, réessayez ! ");

    switch (choix)
    {
        case 1:
            Console.Clear();
            if (restants.Length != 0)
            {
                int indexTmp = new Random().Next(restants.Length);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\n--------- Le grand tirage : ---------\n\n {restants[indexTmp]} a été tiré.e !");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n\nConfirmer ? (oui/non)");
                string answer = Convert.ToString(Console.ReadLine()).ToUpper();
                while (answer != "OUI" && answer != "NON")
                {
                    Console.WriteLine($"\n\nErreur de saisie... Confirmer ? (oui/non)");
                    answer = Convert.ToString(Console.ReadLine()).ToUpper();
                }
                 
                if(answer == "OUI")
                {

                #region null

                //newpersonnes[indexTmp] = personnes[indexTmp];
                //personnes[indexTmp] = null;

                #endregion

                #region array.copy

                // add
                Array.Resize(ref gagnants, gagnants.Length + 1); // augmente la taille du tableau
                    gagnants[gagnants.Length - 1] = restants[indexTmp]; // ajoute l'element au dernier index du tableau

                // remove
                //string[] tmpArray = new string[restants.Length - 1];
                //Array.Copy(restants, 0, tmpArray, 0, indexTmp); // copie le tableau jusqu'à l'element que je veux enlever sans le prendre
                //Array.Copy(restants, indexTmp + 1, tmpArray, indexTmp, restants.Length - indexTmp - 1); // copie le tableau à partir de l'element que je veux enlever sans le prendre
                //    restants = tmpArray;
                // remove v2
                restants = restants.Except(new string[] { restants[indexTmp] }).ToArray();

                #endregion
                }

            }
            else Console.WriteLine("Toute le monde est passé !");


            break;

        case 2:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n--------- {gagnants.Length} personnes ont été tiré.es : ---------\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string pers in gagnants)
            {
                Console.WriteLine(pers);
            }
            break;

        case 3:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n--------- {restants.Length} personne.s restante.s : ---------\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string pers in restants)
            {
                Console.WriteLine(pers);
            }
            break;

        case 4:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n--------- Tableau réinitialisé ---------\n");
            Console.ForegroundColor = ConsoleColor.White;

            //string[] tmpArray2 = { "Benoit", "Seb", "Simon", "Mack", "cricri", "Nico", "Olivier", "Amandine", "Allison", "l'autre Benoit", "Paul", "Fares", "Sondes", "Max" };
            //Array.Resize(ref personnes, tmpArray2.Length);
            //Array.Copy(tmpArray2, personnes, tmpArray2.Length);
            Array.Resize(ref restants, datas.Length);
            Array.Copy(datas, restants, datas.Length);
            Array.Clear(gagnants);
            Array.Resize(ref gagnants, 0);
            break;
    }
} while (choix != 0);