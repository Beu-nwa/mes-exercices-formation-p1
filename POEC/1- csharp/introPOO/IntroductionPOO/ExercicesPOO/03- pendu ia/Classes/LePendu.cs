public class LePendu
{
    public int NbEssai { get; set; }
    public string Masque { get; set; }
    public string MotATrouve { get; set; }

    public LePendu()
    {
        NbEssai = 0;
        Masque = "";
        MotATrouve = "";
    }
    public void TestChar(char c)
    {
        bool trouve = false;
        for (int i = 0; i < MotATrouve.Length; i++)
        {
            if (MotATrouve[i] == c)
            {
                Masque = Masque.Substring(0, i) + c + Masque.Substring(i + 1);
                trouve = true;
            }
        }

        if (!trouve)
        {
            NbEssai++;
        }
    }

    // Vérifie si la partie est gagnée (le mot a été entièrement découvert)
    public bool TestWin()
    {
        return Masque == MotATrouve;
    }

    // Génère un masque pour le mot à trouver (remplace chaque lettre par un tiret)
    public void GenererMasque()
    {
        Masque = "";
        for (int i = 0; i < MotATrouve.Length; i++)
        {
            Masque += "-";
        }
    }
}