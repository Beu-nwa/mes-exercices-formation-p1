result = document.querySelector(`#result`);

var n = Number(prompt("jusqu'à combien voulez vous compter ?")),
    affichage = `<h2>Compter jusqu'à ${n} : </h2> <ul>`;

for(i = 0; i <= n; i++) affichage += `<li>${i}</li>`;

affichage += `</ul> <p>Super je sais compter jusqu'à ${n}</p>`

result.innerHTML = affichage;