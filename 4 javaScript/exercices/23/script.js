result = document.querySelector(`#result`);

var affichage = `<h2>Tables de multiplications : </h2> <div style="display: flex;justify-content:center;flex-flow:row wrap; gap:10px;">`;

for(i = 1; i <= 10; i++) {
    affichage += `<div class="card" style="width: calc(20% - 8px);"><h3>Table de ${i} : </h3><ul>`;
    for (j = 1; j <= 10; j++) affichage += `<li>${i} x ${j} = ${i*j}</li>`
    affichage += `</ul> </div>`;
}



affichage += `</div>`

result.innerHTML = affichage;