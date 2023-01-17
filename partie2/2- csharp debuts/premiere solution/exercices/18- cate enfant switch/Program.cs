Console.WriteLine("quel est l'âge de votre enfant ?");
int age = Convert.ToInt32(Console.ReadLine());

#region jspquoi cases

switch (age)
{
    case <3 :
        Console.WriteLine($"Votre enfant agé de {age} an.s est trop jeune");
        break;
    case <7:
        Console.WriteLine($"Votre enfant agé de {age} ans appartient à la catégorie baby");
        break;
    case <9:
        Console.WriteLine($"Votre enfant agé de {age} ans appartient à la catégorie poussin");
        break;
    case <11:
        Console.WriteLine($"Votre enfant agé de {age} ans appartient à la catégorie pupille");
        break;
    case <13:
        Console.WriteLine($"Votre enfant agé de {age} ans appartient à la catégorie minime");
        break;
    case < 18:
        Console.WriteLine($"Votre enfant agé de {age} ans appartient à la catégorie cadet");
        break;
    default:
        Console.WriteLine($"Votre enfant agé de {age} est trop vieux.");
        break;
}

#endregion

Console.WriteLine("appuyer sur une touche pour quitter le programme");
Console.Read();