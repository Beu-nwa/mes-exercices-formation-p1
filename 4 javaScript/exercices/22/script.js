result = document.querySelector(`#result`);

var affichage = `<h2>Menu et sous menu : </h2> <ul>`,
    chapitres = 3,
    parties = 3;

for(i = 1; i <= chapitres; i++) {
    affichage += `<li>chapitre : ${i}</li><ul>`;
    for (j = 1; j <= parties; j++) affichage += `<li>partie : ${i}.${j}</li>`
    affichage += `</ul> <br>`;
}








affichage += `</ul>`

result.innerHTML = affichage;