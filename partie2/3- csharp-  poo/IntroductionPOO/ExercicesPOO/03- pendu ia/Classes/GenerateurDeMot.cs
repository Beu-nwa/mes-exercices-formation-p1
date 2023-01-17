public class GenerateurDeMot
{
    private static string[] mots = { "maison", "arbre", "ordinateur", "chat", "voiture" };

    // Renvoie aléatoirement un mot parmi ceux stockés dans le tableau
    public static string Generer()
    {
        Random rnd = new Random();
        int index = rnd.Next(mots.Length);
        return mots[index];
    }
}