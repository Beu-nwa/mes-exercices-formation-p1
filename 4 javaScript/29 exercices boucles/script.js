var names = ["benoit","antoine","gaetan","camille","mathilde"];


console.log("----------------");
console.log("avec une boucle for");

for (k=0; k < names.length; k++) console.log(names[k]);

console.log("----------------");
console.log("avec une boucle while");

var k = 0;
while (k < names.length) {console.log(names[k])
    k++};

    

console.log("----------------");
console.log("le for in");

var contact = {
    nom : "Benoit",
    prenom : "Combe",
    telephone : "0648648229",
    mail : "cnbfgjk@hotmail.com"
}

for( let item in contact) console.log(` ${item} : ${contact[item]} `);; 

    

console.log("----------------");
console.log("le for of");


for (const name of names) console.log(`${name}`);


console.log("----------------");
console.log("boucles imbriquées");

for (i = 1; i < 3; i++){
    console.log("--");
    console.log(`i = ${i}`);
    for(j = 1; j<10; j++) console.log(`j = ${j}`);
}
