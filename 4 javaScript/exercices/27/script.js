result = document.querySelector(`#result`);

let affichage = `<h2>Notes élèves avec noms : </h2><hr><p>`,
    etudiants = [{
        prenom: "José",
        nom: "Garcia",
        matieres: {
            francais: 16,
            anglais: 7,
            humour: 14
        }
    },
    {
        prenom: "Antoine",
        nom: "De Caunes",
        matieres: {
            francais: 15,
            anglais: 6,
            humour: 16,
            informatique: 4,
            sport: 10
        }
    }, {
        prenom: "toto",
        nom: "titi",
        matieres: {
            francais: 16,
            cuisine: 14,
            humour: 16,
            informatique: 4,
            sport: 10
        }
    }];

for (let etudiant of etudiants) {
    affichage += `<h5>${etudiant.prenom} ${etudiant.nom}</h5><br><ul>`
    let total = 0;
    let nbMatiere = 0;
    for (let matiere in etudiant.matieres) {
        affichage += `<li>${matiere} : <b>${etudiant.matieres[matiere]}</b></li>`;
        total += etudiant.matieres[matiere];
        nbMatiere ++;
    }
    affichage += `</ul><br>Moyenne générale : <b>${Math.round((total/nbMatiere)*100)/100}</b>/20<hr>`;
}

// dans un tableau 2D on retrouve un tableau numérique (il définit ses objets avec leur index)
// ce tableau numerique contient un tableau associatif (on ne peut pas retrouver les objets qui le composent avec son id)
// pour explorer le tableau numérique : for...of
// pour explorer le tableau associatif : for...in

affichage += `</p>`;

result.innerHTML = affichage;
