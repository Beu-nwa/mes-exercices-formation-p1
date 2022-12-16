
function fctAnciennete (x){
    if(x<1) return `Vous n'avez pas cumuler l'année d'ancienneté nécéssaire pour être éligible <b>(${Math.round(x*365)}</b> jours).`;
    else if (x<=10) {
        primeAncienneté = (salaire/2)*x;
        return ` Avec <b>${n}</b> année d'ancienneté, vous beneficierez de'une prime d'ancienneté de <b>${primeAncienneté}</b>. `;
    } else {
        primeAncienneté = (salaire/2)*10+salaire*(x-10);
        return ` Avec <b>${n}</b> année d'ancienneté, vous beneficierez de'une prime d'ancienneté de <b>${primeAncienneté}</b>. `};
}

function fctAge (x){
    if (x<46) return `Agé de <b>${x}</b> an, vous etes trop jeune pour beneficier de la prime liée aà l'âge.`;
    else if (x<50) {
        primeAge = salaire*2;
        return `Agé de <b>${x}</b> an, La prime dûe à l'age vous offre 2 mois de salaire, soit <b>${primeAge}</b> .`
    } else {
        primeAge = salaire*5;
        return `Agé de <b>${x}</b> an, La prime dûe à l'age vous offre 5 mois de salaire, soit <b>${primeAge}</b> .`
    }
}

const result = document.querySelector(`#result`);

var affichage = "<h2>Indémnité de licenciement.</h2><p>",
    age = Number(prompt("Quel est votre age ?")),
    n = Number(prompt("Depuis combien de temps en année travaillez vous chez nous ?")),
    salaire = Number(prompt("Quel est le montant de votre dernier salaire")),
    primeAge = 0,
    primeAncienneté = 0;

    affichage += `Avec <b>${age}</b> ans, <b>${n}</b> années d'ancienneté et un salaire de <b>${salaire}</b> euros, vos droits sont :`;
    affichage += `<hr>`;
    affichage += fctAnciennete(n);
    affichage += `<br>`;
    affichage += fctAge(age);
    affichage += `<br>`;
    affichage += `<br>`;
    affichage += `Au total vous toucherez <b>${primeAge+primeAncienneté}</b> euros de primes cumulées.`;









affichage += `</p>`;

result.innerHTML = affichage;






















