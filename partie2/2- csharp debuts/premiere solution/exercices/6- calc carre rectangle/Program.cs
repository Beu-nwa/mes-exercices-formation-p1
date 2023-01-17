// See https://aka.ms/new-console-template for more information
Console.WriteLine("1 pour carré, autre valeur pour triangle");
int type = Convert.ToInt32(Console.ReadLine());

if(type == 1)
{
Console.WriteLine("Veuillez saisir la longueur d'un coté du carré : ");
double nb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Le carré de coté : {nb} cm\n\t aire: {nb*nb}cm²\n\t premietre : {4*nb}cm");
}
else
{
    Console.WriteLine("Veuillez saisir la longueur du 1er côté du rectangle : ");
    double nb1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Veuillez saisir la longueur du 2nd côté du rectangle : ");
    double nb2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Le carré de coté : {nb1}cm et {nb2}cm\n\t aire: {nb1 * nb2}cm²\n\t premietre : {2*nb1+2*nb2}cm");
}


Console.WriteLine("\nAppuyer sur entrer pour fermer la console");
Console.Read();