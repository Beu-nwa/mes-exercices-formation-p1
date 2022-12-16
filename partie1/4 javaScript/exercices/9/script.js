const result = document.querySelector(`#result`);
var affichage = "<h2>calcul du capital final en fonction du ci, taux et nombre d'année</h2><p>",
    ci,
    cf,
    n,
    taux;

ci = Number(prompt("quel est le montant de votre capital initial (en euros) ?"));
taux = Number(prompt("quel est le taux d'intérets (en %) ?"));
n = Number(prompt("pendant combien d'année voulez vous le placer ?"));
taux /= 100;

cf = Math.round(ci*(Math.pow((1+taux),n)));

affichage += `avec un capital initial de <b>${ci}</b> euros, placé à <b>${taux*100}</b> % pendant <b>${n}</b> années : <br>`;
affichage += `<ul><li> le capital final sera de : <b>${cf}</b> euros </li>`;
affichage += `<li> montant total des interets : <b>${cf-ci}</b> euros </li></ul></p>`;

result.innerHTML = affichage;






















