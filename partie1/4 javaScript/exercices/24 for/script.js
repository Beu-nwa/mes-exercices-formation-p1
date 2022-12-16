result = document.querySelector(`#result`);

var affichage = `<h2>Population de Tourcoing : </h2><div><p><hr>`,
    p = 96809,
    t = 0.0089;

// version avec for... break

for (n = 1; n > 0; n++) {
    p = p * (1 + t);
    affichage += `En ${n + 2015}, la population sera de <b>${Math.round(p)}</b> habitants <br> `;
    if (p >= 120000) {
        affichage += `<hr>Avec un taux de <b>${t * 100}</b>%, la polulation dépassera 120K et atteindra <b>${Math.round(p)}</b> habitants en <b>${n}</b> années, soit en <b>${n + 2015}</b>. `
        break;
    }
}
affichage += `</p></div>`


// version plus simple jsute avec for...

// for (n = 1; p <= 120000; n++) {
//     p = p * (1 + t);
//     affichage += `En ${n + 2015}, la population sera de <b>${Math.round(p)}</b> habitants <br> `;
// }
// affichage += `<hr>Avec un taux de <b>${t * 100}</b>%, la polulation dépassera 120K et atteindra <b>${Math.round(p)}</b> habitants en <b>${--n}</b> années, soit en <b>${n + 2015}</b>. `

// affichage += `</p></div>`













result.innerHTML = affichage;
