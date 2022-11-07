const result = document.querySelector(`#result`);
var affichage = "<h2>calcul de l'hypotenuse</h2><p>",
    cotea,
    coteb;

cotea = Number(prompt("entrer la valeur du premier cote de votre triangle rectangle (en cm)"))
coteb = Number(prompt("entrer la valeur du second cote de votre triangle rectangle (en cm)"))



affichage += `<ul><li> vous avez entré : <b>${cotea}</b> cm et <b>${coteb}</b> cm </li>`;
affichage += `<li> hypotenuse <b>${Math.round(Math.sqrt((Math.pow(cotea,2))+(Math.pow(coteb,2)))*100)/100}</b> cm  </li></ul></p>`;


result.innerHTML = affichage;






















