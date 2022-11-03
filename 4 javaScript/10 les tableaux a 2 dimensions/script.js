// les tableaux a deux dimensions

// declaration de 2 tableaux numeriques


var legumes = ["Carottes", "Choux", "Haricots"];
var fruits = ["Raisins", "Bananes", "Abricots"];
console.table(legumes);
console.table(fruits);


// creation d'un tableau a deux dimensions

var primeur = [legumes,fruits];
// var primeur = new Array(legumes, fruits)
console.table(primeur);


// affichage d'un element a un index precis
console.log(primeur[0][0]);
console.log(primeur[1][2]);


// avec une matrice d etableaux associatifs

var zoo = [
    {
        nom: "Simba",
        espece: "Lion",
        continent: "Afrique",
    },
    {
        nom: "Tony",
        espece: "Kangouroo",
        continent: "Océanie",
    },
];

console.table(zoo);
console.log(`les  noms sont : ${zoo[0].nom} et ${zoo[1].nom}`);

























