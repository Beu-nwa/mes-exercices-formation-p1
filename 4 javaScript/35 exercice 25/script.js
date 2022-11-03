result = document.querySelector(`#result`);

var x = Number(prompt(`Jusqu'à combien voulez vous voir la somme des entiers chainés ?`)),
    somme,
    ligne = "",
    boolean = false,
    affichage = `<h2>Entiers en chaîne : </h2><hr><div> <p> Voici la liste des entiers chaînés dont la somme est égale à ${x} <ul>`;


for (i = 1; i < (x / 2); i++) {
    somme = 0;
    ligne = `<li> ${x} = ${i} `;


    for (j = i; somme < x; j++) {

        if (j != i) ligne += ` + ${j} `;
        somme += j;
    }
    if (somme == x) {
        affichage += `${ligne}</li>`;
        boolean = true;
    }
}

if(boolean == false) affichage += `<li> La valeur entrée ${x} ne correspond à aucune somme de nombre en chaîne ! </li>`;
console.log(boolean);



affichage += `</ul></p></div> `

result.innerHTML = affichage;
