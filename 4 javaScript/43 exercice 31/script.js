result = document.querySelector(`#result`);

var affichage = `<h2>Liste de contact : </h2> <hr> <div><table class="table"><thead class="table-dark"><th>Prenom</th><th>Nom</th><th>Age</th></thead><tbody>`;

var eleves = [
    {
        prenom: "Jean",
        nom: "Dupont",
        age : 15
    },
    {
        prenom: "Pierre",
        nom: "Durant",
        age : 16
    },
    {
        prenom: "Jean",
        nom: "Martin",
        age : 17
    },
];

for (let eleve of eleves){
    affichage += `<tr><td>${eleve.prenom}</td> <td>${eleve.nom}</td><td>${eleve.age}</td></tr>`
}

affichage += `</tbody></table><hr> La personne à la deuxieme position de l'annuaire est : <br><br> <b>${eleves[1].nom} ${eleves[1].prenom}</b></div>`

result.innerHTML = affichage;