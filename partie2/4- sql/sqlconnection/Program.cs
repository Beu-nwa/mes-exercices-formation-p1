
using Microsoft.Data.SqlClient;

string coString = @"Data Source=(LocalDB)\IDP88;Integrated Security=True"; // chemin d'acces

// string request = "select * from person";
// string request = "insert into person (nom, email, telephone) values ('nomTest', 'Test@Test.fr', '+33 6 25 45 68 25')";
// string request = "select top 5 * from person";
SqlConnection connection = new SqlConnection(coString);

// SqlCommand command = new SqlCommand(request, connection); // preparation de l'objet


// connection.Open(); // ouverture de la commande

// int nbLigne = command.ExecuteNonQuery(); // retourne le nb de ligne affectées par la commande
// int Id = (int)command.ExecuteScalar(); // retourne le champs indiqué dans la request
// SqlDataReader reader = command.ExecuteReader(); // retourne l'ensemble des resultats correspondant

// while (reader.Read()) Console.WriteLine($"ID: {reader.GetInt32(0)},  NOM : {reader.GetString(1)}, EMAIL : {reader.GetString(1)}, TEL : {reader.GetString(2)}");

#region saisie user

Console.Write("saisir le nom :");
string nom = Console.ReadLine();
Console.Write("saisir le email :");
string email = Console.ReadLine();
Console.Write("saisir le telephone :");
string tel = Console.ReadLine();

string request = "insert into person (nom, email, telephone) values ( @nom, @email, @tel)";
SqlCommand command2 = new SqlCommand(request, connection);
command2.Parameters.Add(new SqlParameter("@nom", nom));
command2.Parameters.Add(new SqlParameter("@email", email));
command2.Parameters.Add(new SqlParameter("@tel", tel));

#endregion
connection.Open();
int nbLigne = command2.ExecuteNonQuery();
command2.Dispose(); // liberation de l'objet
connection.Close(); // fermeture de la connection

Console.WriteLine( "nb de ligne affectées par la commande : " + nbLigne);
// Console.WriteLine( "id : " + Id);

Console.Read();
Console.WriteLine("fermer...");