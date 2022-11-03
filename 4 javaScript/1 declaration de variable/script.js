// commentaire sur une ligne

/*
commentaire multiligne
*/

/**
 * 
 * commenatire de vscode qui rajoute une etoile a chaque ligne
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */

// declarer une variable en ES5
var age;

// affectation de valeur

age = 25;
console.log(age);

// incrementation

age = age + 1;
console.log(age);
// operateur combiné
age += 1;
console.log(age);
// operateur d'incremention
age ++;
console.log(age);

var prenom;
prenom = "Anthony"


console.log(prenom)

console.log(prenom[0])
console.log(prenom[1])
console.log(prenom[2])
console.log(prenom[3])
console.log(prenom[4])
console.log(prenom[5])
console.log(prenom[6])

console.log("Terminé")

var nom;
// je ne lui donne pas de valeur
console.log(nom)
// on voit que nom est undefined
nom = "Martial"
console.log(nom)


console.log("hello, mon nom est "+prenom+ " " + nom + ", j'ai "+age + " ans")
console.log(`hello, mon nom est ${prenom} ${nom}, j'ai ${age} ans`)

console.log(typeof(age));
// age est de type number

var grandNombre = 6545546846848846543465465456465n;

console.log(grandNombre);
console.log(typeof(grandNombre));
// grandNombre est de type bigint (grand nombre)

var variableNulle = null
console.log(typeof(variableNulle));
// variableNulle est de type objet avec une valeur nulle


var monBooeleen = true
console.log(typeof(monBooeleen));
// monBooeleen est de type boolean