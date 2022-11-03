result = document.querySelector(`#result`);

let n = Number(prompt(`Combien de note devez vous entrer ?`)),
    i = 0,
    maxi = 0,
    mini = 20,
    total = 0,
    affichage = `<h2>Notes élèves avec while : </h2><hr>`,
    texte1 = "",
    texte2 = "<ul>";

while (isNaN(n) || n < 2) n = Number(prompt(`Vous n'avez pas saisi un nombre de note valide, réessayez !`));

alert(`Vous avez choisi d'entrer ${n} notes.`)

texte1 += `<div> <p> Vous avez choisi d'entrer <b>${n}</b> notes notées sur 20.`;

while (i < n) {
    i++;
    let x = prompt(`Veuillez entrer la note numéro ${i}`);
    if (x == 777) {
        texte1 = `<div> <p> Vous aviez choisi d'entrer <b>${n}</b> notes mais avez stoppé après la <b>${i-1}</b>eme note.`;
        n = i - 1;
    }
    while (isNaN(x) || x < 0 || (x > 20) && (x != 777) || x === ``) x = prompt(`Vous n'avez pas saisi une note valide. réessayez d'entrer la note numéro ${i} !`);
    x = Number(x);
    if (x <= mini) mini = x;
    if ((x >= maxi) && (x != 777)) maxi = x;
    if (x != 777) {
        total += x;
        texte2 += `<li>La note <b>${i}</b> est : <b>${x}</b>/20.</li>`;
    }
}

affichage += texte1;
affichage += texte2;
affichage += `</ul><hr>
Sur l'ensemble des ${n} notes : <br><br>
<ul>
<li class="text-success"> La plus grande note est : <b>${maxi}</b>/20 </li>
<li class="text-danger"> La plus petite note est : <b>${mini}</b>/20 </li>
<li> La moyenne des ${n} notes est : <b>${Math.round((total /= n) * 100) / 100}</b>/20 </li>
</ul></p></div> `;

result.innerHTML = affichage;
