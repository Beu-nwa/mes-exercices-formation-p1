result = document.querySelector(`#result`);

var affichage = `<h2>Population de Tourcoing : </h2><div><p><hr>`,
    p = 96809,
    t = 0.0089,
    n = 0;

while(p<=120000){
    n++
    p = p * (1 + t);
    affichage += `En ${n + 2015}, la population sera de <b>${Math.round(p)}</b> habitants <br> `;
}

affichage += `<hr>Avec un taux de <b>${t * 100}</b>%, la polulation dépassera 120K et atteindra <b>${Math.round(p)}</b> habitants en <b>${n}</b> années, soit en <b>${n + 2015}</b>.</p></div> `

result.innerHTML = affichage;
