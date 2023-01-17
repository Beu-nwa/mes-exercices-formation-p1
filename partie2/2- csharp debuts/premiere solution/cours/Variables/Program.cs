// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region chaines de caracteres

string prenom;
prenom = "Benoit";
string nom = "Combe";
string nom2  = nom;
Console.WriteLine(nom==nom2);
Console.WriteLine("changer la valeur de nom2 : ");
nom2  = Console.ReadLine();
Console.WriteLine(nom == nom2);

Console.WriteLine(" prenom: {0} \n nom : {1}\n", prenom, nom);
Console.WriteLine($"Initiales: {prenom[0]}.{nom[0]}");

#endregion

#region variables numériques
// entiers
int age;
age = 25;
Console.WriteLine($"Mon age est de {age} ans.");
Console.WriteLine($"Dans un an j'aurai {++age} ans.");
Console.WriteLine($"Veuillez saisir votre age : ");
int age2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"votre age est : {age2} ans");

// decimaux
float nb1 = 3.1417F;
double nb2 = 3.1416;
decimal nb3 = 3.14159265358979323846264338327950288419716939937510582M;
// en fin de valeur: F pour float et M pour decimal;
Console.Write($"{nb1} est de type : ");
Console.WriteLine(nb1.GetType());
Console.Write($"{nb2} est de type : ");
Console.WriteLine(nb2.GetType());
Console.Write($"{nb3} est de type : ");
Console.WriteLine(nb3.GetType());

Console.WriteLine("entrer un nombre");
double nb = Convert.ToDouble(Console.ReadLine());
Console.Write($" le nombre entré {nb} est de type : ");
Console.WriteLine(nb.GetType());

Console.WriteLine($"La somme de {nb1} et de {nb2} est égale à : {nb1+nb2} ");

#endregion

#region variables de type objet

object monObjet = "Ma chaine objet";
Console.WriteLine(monObjet);

#endregion

Console.WriteLine("\nAppuyer sur entrer pour fermer la console");
Console.Read();