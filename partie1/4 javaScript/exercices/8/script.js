const result = document.querySelector(`#result`);
var affichage = "<h2>calcul du cout ttc d'un bien</h2><p>",
    prix,
    tva;

prix = Number(prompt("quel est le cout hors taxe de votre bien (en euros) ?"));
tva = Number(prompt("quel est le montant de la tva qui s'y applique (en %) ?"));
tva /= 100;




affichage += `<ul><li> cout HT : <b>${prix}</b> euros </li>`;
affichage += `<li> montant TVA : <b>${tva*100}</b> % </li>`;
affichage += `<li> TTC : <b>${prix*(1+tva)}</b> euros </li></ul>`;




result.innerHTML = affichage;






















