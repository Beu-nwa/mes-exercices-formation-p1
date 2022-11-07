function sommeEnChaine(n) {
    for (j = i + 1; somme < n; j++) {
        ligne += ` + ${j} `;
        somme += j;
        if (somme == n) {
            affichage += `${ligne}</li>`;
        }
        if (somme >= n) break;
    }
}
result = document.querySelector(`#result`);

var x = Number(prompt(`Jusqu'à combien voulez vous voir la somme des entiers chainés ?`)),
    somme,
    ligne = "",
    affichage = `<h2>Entiers en chaîne : </h2><hr>`;

if (isNaN(x)) {
    do {
        x = Number(prompt(`Vous n'avez pas saisi un nombre. réessayez !`));
    } while (isNaN(x));
}

affichage += `<div> <p> Voici la liste des entiers chaînés dont la somme est égale à ${x} <ul>`;

for (i = 1; i < (x / 2); i++) {
    somme = i;
    ligne = `<li> ${x} = ${i} `;
    sommeEnChaine(x);
}

affichage += `</ul></p></div> `;

result.innerHTML = affichage;
