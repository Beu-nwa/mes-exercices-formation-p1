const result = document.querySelector(`#result`);
var affichage = "";
var phrase = "jE sUis Une PhraSe";
var mots;

affichage += `<p>`;

affichage += phrase;

affichage += `<br>`;

affichage += phrase.toLowerCase();

affichage += `<br>`;

affichage += phrase.toLowerCase().split("");

affichage += `<br>`;

mots = phrase.toLowerCase().split(" ");

affichage += mots;
affichage += `<br>`;
affichage += mots[0][0];
affichage += mots[1][0];
affichage += mots[2][0];
affichage += mots[3][0];
affichage += `<br>`;

console.table(phrase);
console.table(mots);

// affichage += mots.value.first();
// Value
// .toUpperCase();

affichage += `<br>`;

affichage += mots[0][0].toUpperCase();
affichage += mots[1][0];
affichage += mots[2][0];
affichage += mots[3][0];
affichage += `<br>`;
affichage += mots[0].toUpperCase();
affichage += `<br>`;
affichage += phrase;
affichage += `<br>`;

// const wordTable = mots.map((x) => a[0]).flat(2);
// console.log(wordTable);

// const tableauDeMot = mots.filter(x => x.filter(y => y[0]))
// console.log(tableauDeMot);

// const fistLetters = mots.forEach((element) =>
//   console.log(element[0].toUpperCase())
// );
// const fistLetters2 = phrase
  // .split(" ")
  // .forEach((element) => console.log(element[0].toUpperCase()));
// affichage += mots.forEach(element => element[0].toUpperCase());
// affichage += fistLetters
affichage += `<br>`;
affichage += `<br>`;

x=>{

}

affichage += phrase.toLowerCase().split(" ").map(x=>x[0].toUpperCase()+x.slice(1)).join(" ");
// map equivalent de forEach
// slice se mets a l'index 1 d'un mot et copie le reste du mot (en mettant un deuxieme parametre au slice, on peut definir combien de caractere il va copier)
affichage += `</p>`;

result.innerHTML = affichage;

// var arr = [
//   [
//     ["Name 1", 2, "Nigeria"],
//     ["Name 3", 52, "Egypt"],
//     ["Name 5", 75, "South Africa"],
//   ],
//   [
//     ["Name 5", 8, "Nigeria"],
//     ["Name 1", 62, "Egypt"],
//     ["Name 3", 115, "South Africa"],
//   ],
//   [
//     ["Name 6", 88, "Nigeria"],
//     ["Name 3", 92, "Egypt"],
//     ["Name 5", 825, "South Africa"],
//   ],
// ];

// const res = arr.map((x) => x.map((a) => a[0])).flat(2);
// console.log(res);
