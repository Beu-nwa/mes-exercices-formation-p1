Console.WriteLine("Quel est la longueur en cm du premier côté AB ?");
double AB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quel est la longueur en cm du premier côté BC ?");
double BC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quel est la longueur en cm du premier côté CA ?");
double CA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Le triangle est de cotés {AB}cm, {BC}cm, ${CA}cm.");

#region conditons triangle

if (AB != BC && BC != CA && AB != CA) Console.WriteLine("Le triangle est quelconque");
else if (AB == BC && BC == CA) Console.WriteLine("Le triangle est équilatéral");
    else if (AB == BC) Console.WriteLine($"Le triangle est iscocèle en B");
        else if (AB == CA) Console.WriteLine($"Le triangle est iscocèle en A");
            else Console.WriteLine($"Le triangle est iscocèle en C");

#endregion

Console.WriteLine("appuyer sur une touche pour fermer le programme");
Console.Read();