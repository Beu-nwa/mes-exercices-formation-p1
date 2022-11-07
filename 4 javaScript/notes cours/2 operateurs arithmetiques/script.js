var nb1 = 2, nb2 = 10, resultat;

console.log(nb1)
console.log(nb2)
console.log(resultat)

// addition

resultat = nb1 + nb2
console.log(`${nb1} + ${nb2} = ${resultat}`)

// soustraction

resultat = nb1 - nb2
console.log(`${nb1} - ${nb2} = ${resultat}`)
// multiplication

resultat = nb1 * nb2
console.log(`${nb1} x ${nb2} = ${resultat}`)
// division

resultat = nb1 / nb2
console.log(`${nb1} / ${nb2} = ${resultat}`)

console.log(nb1)
// il  faut incrementer avant d'afficher
console.log(nb1++);
console.log(nb1);
console.log(++nb1);

var prenom;
prenom = "Anthony";
console.log(prenom);
prenom = prompt("Quel est votre prenom");
console.log(prenom);

var age;
age = Number(prompt("donne age"))
console.log(age);
console.log(typeof(age));