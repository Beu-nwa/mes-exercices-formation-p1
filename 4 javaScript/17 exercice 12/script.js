const result = document.querySelector(`#result`);

var affichage = "<h2>divisible par</h2><p>",
    a = Number(prompt("entrer un premier nombre")),
    b = Number(prompt("entrer un second nombre"));

if(a%b == 0) affichage += `<b>${a}</b> est divisible par <b>${b}</b>`
else affichage += `<b>${a}</b> n'est pas divisible par <b>${b}</b>`


affichage += `<br>`


// deuxieme façon

affichage += a%b==0? `<b>${a}</b> est divisible par <b>${b}</b>` : `<b>${a}</b> n'est pas divisible par <b>${b}</b>`;
//        conidtion if                                           else


affichage += `</p>`
result.innerHTML = affichage;






















