const result = document.querySelector(`#result`);
var affichage = "";
var mot;
var reverseMot;

mot = prompt("Entrez un mot que vous pensez etre un palindrome");
affichage += `<p>Vous avez entré le mot : <b>${mot}</b> <br>`;

reverseMot = mot.split('').reverse().join('');
affichage += `L'inverse de ce mot est : <b>${reverseMot}</b> <br>`;

if(mot == reverseMot){
    affichage += `Le mot <b>${mot}</b> est un palindrome `
}else{
    affichage += `Le mot <b>${mot}</b> donne  <b>${reverseMot}</b> à l'envers, Ce n'est donc pas un palindrome.`
}

// if(mot == reverseMot) affichage += `Le mot <b>${mot}</b> est un palindrome `
// else affichage += `Le mot <b>${mot}</b> donne  <b>${reverseMot}</b> à l'envers, Ce n'est donc pas un palindrome.`


affichage += `</p>`;

result.innerHTML = affichage;