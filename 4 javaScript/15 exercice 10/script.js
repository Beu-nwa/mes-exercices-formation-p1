const result = document.querySelector(`#result`);

var affichage = "<h2>Test de connection</h2><p>",
    email = String(prompt("entrez votre mail"));


if(email == "be@gmail.com"){
    var mdp = String(prompt("entrez votre mdp"));
        if(mdp == "mot de passe") affichage += `Bienvenu sur votre compte`
        else affichage += `mdp incorrect`
}else affichage += `email incorrect`

affichage += `</p>`;
result.innerHTML = affichage;






















