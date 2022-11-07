const result = document.querySelector(`#result`);

var affichage = "<h2>Categorie de l'enfant</h2><p>",
    age = Number(prompt("Quel est l'âge de votre enfant ?"));

if (age < 3) affichage += `Votre enfant agé de <b>${age}</b> ans est trop jeune`;
else {
    if (age < 7) affichage += `Votre enfant agé de <b>${age}</b> ans appartient à la catégorie <b>Baby</b>`;
    else {
        if (age < 9) affichage += `Votre enfant agé de <b>${age}</b> ans appartient à la catégorie <b>Poussin</b>`;
        else {
            if (age < 11) affichage += `Votre enfant agé de <b>${age}</b> ans appartient à la catégorie <b>Pupille</b>`;
            else {
                if (age < 13) affichage += `Votre enfant agé de <b>${age}</b> ans appartient à la catégorie <b>Minime</b>`;
                else {
                    if (age < 18) affichage += `Votre enfant agé de <b>${age}</b> ans appartient à la catégorie <b>Cadet</b>`;
                    else affichage += `Votre enfant agé de <b>${age}</b> ans est trop vieux`;
                }


            }
        }
    }
}






affichage += `</p>`;

result.innerHTML = affichage;






















