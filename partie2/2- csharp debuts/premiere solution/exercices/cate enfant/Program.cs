// Exercice 12............................................
Console.WriteLine("quel est l'âge de votre enfant ?");
int age = Convert.ToInt32(Console.ReadLine());

#region conditons categories

if (age < 3) Console.WriteLine($"Votre enfant agé de {age} an.s est trop jeune");
else if (age < 7) Console.WriteLine($"Votre enfant agé de {age} ans appartient à la catégorie baby");
    else if (age < 9) Console.WriteLine($"Votre enfant agé de {age} ans appartient à la catégorie poussin");
        else if (age < 11) Console.WriteLine($"Votre enfant agé de {age} ans appartient à la catégorie pupille");
            else if (age < 13) Console.WriteLine($"Votre enfant agé de {age} ans appartient à la catégorie minime");
                else if (age < 18) Console.WriteLine($"Votre enfant agé de {age} ans appartient à la catégorie cadet");
                    else Console.WriteLine($"Votre enfant agé de {age} est trop vieux.");

#endregion

Console.WriteLine("appuyer sur une touche pour fermer le programme");
Console.Read();