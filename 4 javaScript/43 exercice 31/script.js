result = document.querySelector(`#result`);

var affichage = `<h2>Liste de contact : </h2>
<hr> 
<div>
    <table class="table">
        <thead class="table-dark">
            <tr>
                <th>Prenom</th>
                <th>Nom</th>
                <th>Age</th>
            </tr>
        </thead>
        <tbody>`;

var eleves = [
    // ici j'ai 1 tableau numerique qui contient 3 objets qui contiennent chacun 3 propriétés.
    {
        prenom: "Jean",
        nom: "Dupont",
        age: 15
    },
    {
        prenom: "Pierre",
        nom: "Durant",
        age: 16
    },
    {
        prenom: "Jean",
        nom: "Martin",
        age: 17
    },
    {
        prenom: "ben",
        nom: "ten",
        age: 10,
        monstres: [
            "celui a 4 bras",
            "le fantome",
            "le vert"
        ],
        // monstres est un tableau numérique
    },
    {
        prenom: "Scooby",
        nom: "Doo",
        age: 9,
        caract: {
            type: "chien",
            couleur: "marron",
            gateau_prefere: "crocs scooby"
        }
        // ici caract est un tableau associatif
    },
];

for (let eleve of eleves) {
    affichage += `  <tr>
                        <td>${eleve.prenom}</td>
                        <td>${eleve.nom}</td>
                        <td>${eleve.age}</td>
                    </tr>`
}

affichage += `  
        </tbody>
    </table>
    <hr>
    La personne à la deuxieme position de l'annuaire est : <br>
    <br>
    <b>${eleves[1].nom} ${eleves[1].prenom}</b>
</div>`

result.innerHTML = affichage;

console.log(`${eleves[3].prenom} ${eleves[3].nom} : l'un de ses monstres est : ${eleves[3].monstres[1]}`);
console.log(`${eleves[4].prenom} ${eleves[4].nom} : l'une de ses caractéristiques est : ${eleves[4].caract.type}`);