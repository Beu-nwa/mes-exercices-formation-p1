const result = document.querySelector(`#result`);

var affichage = "<h2>Les switchs cases</h2><p>";


const gender = prompt("entrer Mr ou Mme ou Other") ;

switch (gender){
    case  "Mr" : affichage +="Bonjour Monsieur";
    break;
    case  "Mme" : affichage +="Bonjour Madame";
    break;
    case  "Other" : affichage +="Bonjour vous ?";
    break;
}






affichage += `</p>`;

result.innerHTML = affichage;






















