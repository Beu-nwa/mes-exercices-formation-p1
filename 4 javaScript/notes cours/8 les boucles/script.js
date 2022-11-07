
// le while

var i = 0;
while (i <= 10) {
    console.log(`boucle i : ${i}`);
    i++;
};


// le do while

console.log("------------------------");
console.log('deuxieme méthode');

var y = 0;
do {
    console.log(`boucle y : ${y}`);
    y++;
} while (y <= 10)

// ici y vaut 10

console.log("avec le do while, la boucle est au moins executée une fois même si la condition est fausse.");

// ici y voudra 11 car la boucle est executée puis vérifiée. Il éffectue donc quand même la boucle.
do {
    console.log(`boucle y : ${y}`);
    y++;
} while (y <= 10)



// le for

console.log("------------------------");
console.log("methode boucle for");

for (x = 1; x <= 10; x++) {
    console.log(`boucle for, x vaut : ${x}`);
}

// le for pour explorer un tableau

console.log("------------------------");
console.log("explorer un tableau avec un for");

var jours = ["lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "diamnche"]

for (a = 0; a < jours.length; a++) console.log(`a l'index ${a} on trouve : ${jours[a]}`);


// le for in

console.log("------------------------");
console.log("explorer un tableau 2d avec un for in");

var contact = {
    nom: "monNom",
    prenom: "monPrenom",
    telephone: "monNumero",
    mail: "monMain"
}

for (var key in contact) console.log(` ${contact[key]}`);


// le for of

console.log("------------------------");
console.log("explorer un tableau 2d avec un for of");

const names = ["robert", "benoit", "adrien", "antoine"];

for (let name of names) console.log(` ${name}`);

// for avec if break continue

console.log("------------------------");
console.log("for avec if break continue");

for (j = 0; j < jours.length; j++) {
    if (j == 0) {
        console.log("debut de la semaine");
        continue;
    }
    console.log(`jours : ${jours[j]}`);
    if (j === 4)
        break;
}

