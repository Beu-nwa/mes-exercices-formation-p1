const result = document.querySelector(`#result`);
var affichage = "<h2>calcul perimetre et aire carre</h2><p>",
    cote,
    cotea,
    coteb;

cote = Number(prompt("entrer la valeur du cote de votre carré (en cm)"))

affichage += `votre carré est de coté <b>${cote}</b> cm <br>`;
affichage += `<ul><li>permietre <b>${cote*4}</b> cm </li>`;
affichage += `<li>aire <b>${cote*cote}<b> cm² <br> </li></ul> </p>`;

affichage += "<h2>calcul perimetre et aire rectangle</h2><p>"

cotea = Number(prompt("entrer la valeur du premier cote de votre rectangle (en cm)"))
coteb = Number(prompt("entrer la valeur du second cote de votre rectangle (en cm)"))



affichage += `votre rectangle est de coté <b>${cotea}</b> cm et <b>${coteb}</b> cm <br>`;
affichage += `<ul><li> permietre <b>${(cotea+coteb)*2}</b> cm  </li>`;
affichage += `<li> aire <b>${cotea*coteb}<b> cm² <br> </li></ul> </p>`;


result.innerHTML = affichage;






















