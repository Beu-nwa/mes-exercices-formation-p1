const result = document.querySelector(`#result`);

var affichage = "<h2>Taille de vêtements</h2><p>",
    t = Number(prompt("Quel est votre taille en cm")),
    p = Number(prompt("Quel est votre poids en kg"));

switch (true) {
    case (
        t >= 145 && t < 172 && p >= 43 && p <= 47 ||
        t >= 145 && t < 169 && p >= 48 && p <= 53 ||
        t >= 145 && t < 166 && p >= 54 && p <= 59 ||
        t >= 145 && t < 163 && p >= 60 && p <= 65)
        : affichage = `Avec une taille de <b>${t}</b> cm et un poids de <b>${p}</b> kg La taille 1 vous correspond.`;
        break;
    case (
        t >= 169 && t < 183 && p >= 48 && p <= 53 ||
        t >= 166 && t < 178 && p >= 54 && p <= 59 ||
        t >= 163 && t < 175 && p >= 60 && p <= 65 ||
        t >= 160 && t < 172 && p >= 66 && p <= 71)
        : affichage += `Avec une taille de <b>${t}</b> cm et un poids de <b>${p}</b> kg La taille 2 vous correspond.`;
        break;
    case (
        t >= 178 && t <= 183 && p >= 54 && p <= 59 ||
        t >= 175 && t <= 183 && p >= 60 && p <= 65 ||
        t >= 172 && t <= 183 && p >= 66 && p <= 71 ||
        t >= 163 && t <= 183 && p >= 72 && p <= 77
    ): affichage += `Avec une taille de <b>${t}</b> cm et un poids de <b>${p}</b> kg La taille 3 vous correspond.`;
        break;
    default: affichage += "Aucune taille ne vous correspond.";
        break;
}



affichage += `</p>`;

result.innerHTML = affichage;















