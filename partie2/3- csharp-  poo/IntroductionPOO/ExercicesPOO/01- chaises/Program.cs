using _01__chaises.Classes;

Chaise[] chaiseArray = {
    new ("torture", 2, "beton", "gris"),
    new("classique", -4, "", ""),
    new ("confort", 3, "mousse", "rose"),
    new ("gratuit", 0, "carton", "peu importe")
};

foreach (Chaise x in chaiseArray)
{
    Console.WriteLine(x.ToString());
}
