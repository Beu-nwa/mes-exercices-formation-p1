using IntroductionPOO.Classes;

//static void Afficher(Voiture v)
//{
//    Console.WriteLine($"La voiture est une {v.Model} de couleur {v.Couleur}, avec une autonomie de {v.Autonomie}km avec un réservoir de {v.Reservoir}L.");
//}

// Instanciation d'un objet voiture
//Voiture voitureDeNicolas = new Voiture();
Voitures voitureDeNicolas = new();
// Modifier les props de l'objet voitureDeNicolas
voitureDeNicolas.Model = "Clio";
voitureDeNicolas.Couleur = "Noir";
voitureDeNicolas.Reservoir = 50;
voitureDeNicolas.Autonomie = 900;

Console.WriteLine(voitureDeNicolas);

//Afficher(voitureDeNicolas);

voitureDeNicolas.Afficher();

voitureDeNicolas.DemarrerMoteur();
voitureDeNicolas.DemarrerMoteur();
voitureDeNicolas.DemarrerMoteur();

Voitures voitureDeJeanne = new Voitures("208", "Blanche", 800, 45);
Console.WriteLine(voitureDeJeanne);

//Afficher(voitureDeJeanne);

voitureDeJeanne.Afficher();


Console.WriteLine("Appuyez sur enter pour fermer le programme");
Console.Read();
