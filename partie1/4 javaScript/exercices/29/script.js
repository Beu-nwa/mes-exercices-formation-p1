result = document.querySelector(`#result`);

let x = Number(prompt(`Jusqu'à combien voulez vous voir la somme des entiers chainés ?`)),
    somme,
    i = 0,
    ligne = "",
    affichage = `<h2>Entiers en chaîne avec while : </h2><hr>`;

while (isNaN(x) || x < 0) x = Number(prompt(`Vous n'avez pas saisi un nombre. réessayez !`));

affichage += `<div> <p> Voici la liste des entiers chaînés dont la somme est égale à ${x} <ul>`;

while (i < (x / 2)) {
    i++;
    somme = i;
    ligne = `<li> ${x} = ${i} `;
    let j = i;
    while (somme < x) {
        j++;
        ligne += ` + ${j} `;
        somme += j;
    }
    if (somme == x) affichage += `${ligne}</li>`;
}

affichage += `</ul></p></div> `;

result.innerHTML = affichage;
