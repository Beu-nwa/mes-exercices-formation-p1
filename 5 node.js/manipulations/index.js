// // console.log("ça marche");


// // la lecture d'un fichier .txt avec la methode readFile()
import fs from "fs";

// fs.readFile(`fichier1.txt`, (err,  data) =>{
//     if( err == null ) console.log(data.toString())
//     else console.log(err)
// })


// // lecture d'un fichier en sync
// // readFileSync()
// let data = fs.readFileSync(`fichier1.txt`);
// console.log(data.toString());


// // Ecriture dans une fichier .txt
// data += `\nContenu ajouté`;

// fs.writeFile("fichier1.txt", data, (err) => {
//     console.log(err);
// })

// // lecture
// data = fs.readFileSync(`fichier1.txt`);
// console.log(data.toString());


// // ajouter du contenu dans un fichier
// fs.appendFile("fichier1.txt", `\nJ'ajoute du nouveau contenu en async (par defaut)`, (err) =>{
//     console.log(err);
// })
// fs.appendFileSync("fichier1.txt", `\nJ'ajoute du nouveau contenu en sync`, (err) =>{
//     console.log(err);
// })

// // re-lecture d'un fichier en Sync
// data = fs.readFileSync(`fichier1.txt`);
// console.log(data.toString());

// fs.watchFile('fichier2.txt', (cur, prev) => {
//     console.log(cur);
//     console.log(fs.readFileSync("fichier2.txt").toString());
//     console.log(prev);
// })







// exemple d'ecriture dans un fichier csv

// let nom = "Combe";
// let prenom = "Benoit";
// // ecriture 
// fs.appendFileSync("data.csv", `${nom}, ${prenom}\n`);

// nom = "letete";
// prenom = "Maxou";
// // ecriture 
// fs.appendFileSync("data.csv", `${nom}, ${prenom}`);

// const lectureLigneFichier = (fichier) => {
//     const readLineInterface = readline.createInterface({
//         input : fs.createReadStream(fichier)
//     })
//     return readLineInterface;
// }













// // lectureLigneFichier("data.csv".on(`line`, (line)=>{
// //     console.log(line);
// // }))
// // const object = {cle: "valeur", autrecle: 123, encoreUneCle: true};
// const object = [
//     {cle: "valeur", autrecle: 123, encoreUneCle: true},
//     {cle: "valeur", autrecle: 123, encoreUneCle: true}
// ];
// // conversion en json
// const objectToJson = JSON.stringify(object);
// console.log(objectToJson);

// // reconversion en objet javascript
// const objectFromJsonString = JSON.parse(objectToJson);
// console.table(objectFromJsonString);











/** Exercice
 * 1/ recuperer le contenu d'un fichier data.json
 * 2/ reconstruire les objets js
 * 3/ ajouter un objet js
 */

// 1/ recuperer le contenu d'un fichier data.json
let fichier = fs.readFileSync('data.json');
console.log(fichier);

// 2/ reconstruire les objets json en js
let pers = JSON.parse(fichier);
console.table(pers);

// 3/ ajouter un objet js
let newPers = {
    titre : "Mme",
    fistrname: "Marie",
    lastname: "Champagne"
};

pers.push(newPers);
console.table(pers);

let newJsonTable = JSON.stringify(pers);
console.log(newJsonTable);

fs.writeFileSync('data.json', newJsonTable);

// NB en json, toutes les infos sont des strings sauf number et boolean
