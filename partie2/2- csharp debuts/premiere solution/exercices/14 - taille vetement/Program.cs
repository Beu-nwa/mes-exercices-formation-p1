Console.WriteLine("taille cm");
double t = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("poids kg");
double p = Convert.ToDouble(Console.ReadLine());

#region conditons taille vetements

if (
    t >= 145 && t < 172 && p >= 43 && p <= 47 ||
    t >= 145 && t < 169 && p >= 48 && p <= 53 ||
    t >= 145 && t < 166 && p >= 54 && p <= 59 ||
    t >= 145 && t < 163 && p >= 60 && p <= 65
) Console.WriteLine($"Avec une taille de {t}cm et un poids de {p}kg. La taille 1 vous correspond.");
else if (
    t >= 169 && t < 183 && p >= 48 && p <= 53 ||
    t >= 166 && t < 178 && p >= 54 && p <= 59 ||
    t >= 163 && t < 175 && p >= 60 && p <= 65 ||
    t >= 160 && t < 172 && p >= 66 && p <= 71
) Console.WriteLine($"Avec une taille de {t}cm et un poids de {p}kg. La taille 2 vous correspond.");
else if (
    t >= 178 && t <= 183 && p >= 54 && p <= 59 ||
    t >= 175 && t <= 183 && p >= 60 && p <= 65 ||
    t >= 172 && t <= 183 && p >= 66 && p <= 71 ||
    t >= 163 && t <= 183 && p >= 72 && p <= 77
) Console.WriteLine($"Avec une taille de {t}cm et un poids de {p}kg. La taille 3 vous correspond.");
else Console.WriteLine("Aucune taille ne vous correspond..");

#endregion

Console.WriteLine("appuyer sur une touche pour fermer le programme");
Console.Read();