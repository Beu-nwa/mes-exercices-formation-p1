using _39__tp.Classes;

namespace _39__tp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] datas = { "Benoit", "Seb", "Simon", "Mack", "cricri", "Nico", "Olivier", "Amandine", "Allison", "l'autre Benoit", "Paul", "Fares", "Sondes", "Max" };
            string[] restants = new string[datas.Length];
            Array.Copy(datas, restants, datas.Length);
            string[] gagnants = new string[0];
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
                            Helpers.TextColor("Blue", $"\n--------- Le moment du tirage : ---------\n\n {restants[indexTmp]} a été tiré.e !");
                            Console.WriteLine($"\n\nConfirmer ? (oui/non)");
                            string answer = Convert.ToString(Console.ReadLine()).ToUpper();
                            while (answer != "OUI" && answer != "NON")
                            {
                                Console.WriteLine($"\n\nErreur de saisie... Confirmer ? (oui/non)");
                                answer = Convert.ToString(Console.ReadLine()).ToUpper();
                            }

                            if (answer == "OUI")
                            {
                                #region array.copy

                                Array.Resize(ref gagnants, gagnants.Length + 1); // augmente la taille du tableau
                                gagnants[gagnants.Length - 1] = restants[indexTmp]; // ajoute le nouveau gagnant au dernier index du tableau
                                restants = restants.Except(new string[] { restants[indexTmp] }).ToArray();

                                #endregion
                            }

                        }
                        else Console.WriteLine("Toute le monde est passé !");


                        break;

                    case 2:
                        Helpers.TextColor("Blue", $"\n--------- {gagnants.Length} personnes ont été tiré.es : ---------\n");
                        Helpers.DisplayArray(gagnants);
                        break;

                    case 3:
                        Helpers.TextColor("Green", $"\n--------- {restants.Length} personne.s restante.s : ---------\n");
                        Helpers.DisplayArray(restants);
                        break;

                    case 4:
                        Helpers.TextColor("Magenta", "\n--------- Tableau réinitialisé ---------\n");
                        Array.Resize(ref restants, datas.Length);
                        Array.Copy(datas, restants, datas.Length);
                        Array.Clear(gagnants);
                        Array.Resize(ref gagnants, 0);
                        break;
                }
            } while (choix != 0);

        }
    }
}
