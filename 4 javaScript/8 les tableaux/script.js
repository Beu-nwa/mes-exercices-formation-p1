// les tableaux numeriques
// on accede aux elements par leur position index




// declaration d'un tableau numerique

var monTableau = [];
var monTableau2 = new Array();


// affectation de valeurs à un tableau numérique

monTableau[0] = "Pêche";
monTableau[1] = "Pomme";
monTableau[2] = "Poire";
monTableau[3] = "Abricot";
// yen a une yen a une 


// affichage d'un tableau dans la console

console.log(monTableau);

// affichage d'un objet de mon tableau à un index donné dans la console

console.log(monTableau[3]);

// déclaration et affectation de valeur en meme temps

legumes = ["Carottes", "Choux", "Haricots"];
legumes2 = new Array("Carottes", "Choux", "Haricots");


// reaffectation de valeur

console.log(legumes[2]);
legumes[2] = "Epinards" ;
console.log(legumes[2]);


// affichage du nombre d'entrée dans un tableau

console.log(legumes.length);
var nbrLegumes = legumes.length;
console.log(`mon tableau contient ${nbrLegumes} legumes`);


// insertion d'un element sans connaitre le last index

legumes.push("Courgettes");
legumes.push("Potirons","aubergines");
console.table(legumes);

nbrLegumes = legumes.length;
console.log(`mon tableau contient ${nbrLegumes} legumes`);


// insertion d'un element en recuperant le dernier index 

legumes[legumes.length] = "cerises";
console.table(legumes);
legumes[legumes.length] = "cerises";
legumes[legumes.length] = "cerises";
legumes[legumes.length] = "cerises";
console.table(legumes);

// retirer le dernier element d'un tableau

legumes.pop();
legumes.pop();
legumes.pop();
console.table(legumes);


// retirer le premier element d'un tableau

legumes.shift();
console.table(legumes);


// retirer un ou plusieurs elements a un index donné
// => slice(indexDeDepart, nbr d'elements a retirer)

legumes.splice(2,3);
console.table(legumes);


// ajouter un element a un index donné
// => slice(indexDeDepart, nbr d'elements a retirer,valueAajouter)

legumes.splice(3,0,"concombre");
console.table(legumes);
// la prochaine ligne va placer machin a l'index 3 et donc decaller concombre a l'index 4
legumes.splice(3,0,"machin");
console.table(legumes);










































