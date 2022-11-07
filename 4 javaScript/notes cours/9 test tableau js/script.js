result = document.querySelector(`#result`);

var affichage = `<h2>Tables de multiplications : </h2> <div><table class="table table-dark table-striped"><thead><th>id</th><th>prenom</th><th>nom</th></thead><tbody>`;

var eleves = [
    {
        id : 1,
        prenom: "Benoit",
        nom: "combe"
    },
    {
        id : 2,
        prenom: "Antoine",
        nom: "Balke"
        ,
    }
];

for (let eleve of eleves){
    affichage += `<tr><td>${eleve.id}</td> <td>${eleve.prenom}</td> <td>${eleve.nom}</td></tr>`
}

console.table(eleves);


affichage += `</tbody></table></div>`

result.innerHTML = affichage;