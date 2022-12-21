public class IHM
{
    private LePendu lePendu;
    private int nbEssaisMax;

    public IHM()
    {
        lePendu = new LePendu();
        nbEssaisMax = 10;
    }

    // Demande à l'utilisateur de choisir le nombre de coups avant le début de la partie
    // et lance la partie
    public void Demarrer()
    {
        Console.WriteLine("Bienvenue au jeu du pendu !");
        Console.Write("Combien de coups souhaitez-vous avoir ? (10 par défaut) : ");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            nbEssaisMax = int.Parse(input);
        }

        lePendu.MotATrouve = GenerateurDeMot.Generer();
        lePendu.GenererMasque();

        while (lePendu.NbEssai < nbEssaisMax && !lePendu.TestWin())
        {
            Afficher();

            Console.Write("Proposez une lettre : ");
            char c = Console.ReadLine()[0];
            lePendu.TestChar(c);
        }

        Afficher();

        if (lePendu.TestWin())
        {
            Console.WriteLine("Bravo, vous avez gagné !");
        }
        else
        {
            Console.WriteLine("Désolé, vous avez perdu. Le mot était : " + lePendu.MotATrouve);
        }
    }

    // Affiche l'état actuel de la partie
    private void Afficher()
    {
        Console.WriteLine("Mot à trouver : " + lePendu.Masque);
        Console.WriteLine("Nombre de coups restants : " + (nbEssaisMax - lePendu.NbEssai));
    }
}