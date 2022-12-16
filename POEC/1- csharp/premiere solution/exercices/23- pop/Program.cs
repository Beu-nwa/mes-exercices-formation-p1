
Console.WriteLine("Population de Tourcoing :");
double p = 96809;
double t = 0.0089;

for (int n = 1; n > 0; n++)
{
    p = p * (1 + t);
    Console.WriteLine($"En {n+2015}, la population sera de {Math.Round(p)} habitants");
    if (p >= 120000)
    {
        Console.WriteLine($"Avec un taux de {t*100}%, la polulation dépassera 120K et atteindra {Math.Round(p)} habitants en {n} années, soit en {n+2015}");
        break;
    }
}

Console.WriteLine("toucher c fermer");
Console.Read();