const result = document.querySelector('.result');
let monBooleen = false;
function maFonctionBtn() {
    console.log("ouais ouais ouais")

if(monBooleen == false){
    document.getElementById("demo").style.color = "red"
    document.getElementById("myHiddenText").style.removeProperty("display")
}else {
    document.getElementById("myHiddenText").style.display = "none"
}



}

// elevesList[nom, note fr, note maths ]

let elevesList = [
    {
        prenom: "Timothé",
        nom: "Lydiot",
        matieres: {
            francais: 4,
            anglais: 3,
            mathematiques: 0.5
        }
    },
    {
        prenom: "Simon",
        nom: "Lessairieux",
        matieres: {
            francais: 14,
            anglais: 16,
            mathematiques: 18
        }
    },
    {
        prenom: "Benoit",
        nom: "Cémoi",
        matieres: {
            francais: 18,
            anglais: 17.5,
            mathematiques: 19
        }
    },
    {
        prenom: "Maxime",
        nom: "Lefetarre",
        matieres: {
            francais: 12,
            anglais: 19,
            mathematiques: 4
        }
    },
    {
        prenom: "Manu",
        nom: "Aiconcentré",
        matieres: {
            francais: 20,
            anglais: 16,
            mathematiques: 8
        }
    },
]

let affichage = `<tr>
<th>Nom</th>
<th>francais</th>
<th>anglais</th>
<th>mathematiques</th>
</tr>`;

for (let item of elevesList) {
    affichage += `<tr>`
    affichage += `<td> ${item.prenom} ${item.nom}</td>`
    console.log(`${item.prenom} ${item.nom}`)
    for (let key in item.matieres) {
        affichage += `<td> ${item.matieres[key]}/20</td>`;
        console.log(`${item.matieres[key]}`)
    }
    affichage += `</tr>`
}

// result.innerHTML+=affichage;





// for (id = 0; id < elevesList.length; id++) {
//     for (col = 0; col < 4; col++) {
//         document.getElementById("myArray").innerHTML(elevesList[col]);
//     }
// }