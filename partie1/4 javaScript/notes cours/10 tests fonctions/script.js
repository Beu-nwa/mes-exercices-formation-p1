

var a = 10;
console.log(a);
// console.log(b);
// console.log(c);

function f() {
    let b = 20;
    var c = 30
}
// console.log(b);
// console.log(c);

f()

// console.log(b);
// console.log(c);

// que ce soit avec let ou var : b et c n'existent que dans la fonction et nepeuvent etre appelés ni avant ni apres

const lorem = `loremxfwdgbqxqv sw vfYnnqnwsv  Bnvjwnsvsdnjv vnsdv`;
const test = /[A-Z]/g;

console.log(lorem.match(test));

function fct(param = "parametre_par_defaut_si_on_lappelle_en_loubliant") { console.log(`${param}`) };

fct();
fct("blablabla");


console.log("------------------------------------------------------");


// diference var et let

console.log(prenomVar);
// |----> renvoi undefined        -----> considérée comme existante mais si elle est déclarée apres. Il l'a considere tout de meme comme pas encore définie
// console.log(prenomLet);        -----> message d'erreur car déclarée apres

prenomVar = "Gerard n'est pas né";
// |------> déclarée apres, définie ici.
console.log(prenomVar);

var prenomVar = "Gerard";
let prenomLet = "Ginette";

console.log(prenomVar);
console.log(prenomLet);


console.log("------------------------------------------------------");


const tabNum = [1, 2, 3, 4];

// const x = tabNum[0];
// const y = tabNum[1];

// revient au meme que :

const [x, y] = tabNum
// en faisant ca il va créer 2 const x et y. et il va les definir par les 2 premieres value du tableau tabNum

console.table(tabNum);
console.log(x, y);


console.log("------------------------------------------------------");


// const userList = {
//     prenom : "martin",
//     nom : "matin",
//     age : 17,
// };

// console.log(userList);

// const [firstName , LastName] = userList;

// console.log(firstName);

// function getFullName(firstName,LastName){
//     return `${firstName} ${LastName}`
// }

// console.log(getFullName(user));



console.log("------------------------------------------------------");

function fctBtnClick () {console.log("Vous avez : cliqué");}
function fctBtnDblClick () {console.log("Vous avez : double cliqué");}
function fctMouseOver () {console.log("Vous avez : survolé le btn");}
function fctMouseOut () {console.log("Vous avez : sorti du btn");}

console.log("------------------------------------------------------");

let inputUserGender = document.querySelector(`#inputUserGender`);
let inputValue;

function fctBtnValider() {
    alert(`input : ${inputUserGender.value}`);
    inputValue = inputUserGender.value;
    alert(`variable : ${inputValue}`);
}


console.log("------------------------------------------------------");



document.addEventListener("keyup",function(event){
    if(event.key === `Enter` ) alert(`Vous avez appuyé sur enter et entré la valeur ${document.querySelector(`#keyup`).value} `);
})