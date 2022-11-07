const result = document.querySelector(`#result`);

var affichage = "<h2>Test de connection</h2><p>",
    lettre = String(prompt("entrer une lettre"));

if(lettre == "a" || lettre == "e" ||lettre ==  "i" ||lettre ==  "o" ||lettre ==  "u" ||lettre ==  "y" ) affichage += `<b>${lettre}</b> est une voyelle`
else affichage += `<b>${lettre}</b> est une consonne`;


affichage += `</p>`



result.innerHTML = affichage;






















