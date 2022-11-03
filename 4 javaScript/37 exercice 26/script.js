function maximum(a) {
    if (a >= maxi) maxi = a;
}

function minimum(a) {
    if (a <= mini) mini = a;
}

function moyenne(a) {
    return Math.round((a /= n) * 100) / 100;
}

result = document.querySelector(`#result`);

let n = Number(prompt(`Combien de note devez vous entrer ?`)),
    maxi = 0,
    mini = 20,
    moy = 0,
    affichage = `<h2>Notes élèves : </h2><hr>`;

while (isNaN(n) || n < 2) n = Number(prompt(`Vous n'avez pas saisi un nombre de note valide, réessayez !`));


alert(`Vous avez choisi d'entrer ${n} notes.`)

affichage += `<div> <p> Vous avez choisi d'entrer <b>${n}</b> notes notées sur 20. <ul>`;

for (let i = 1; i <= n; i++) {
    let x = prompt(`Veuillez entrer la note numéro ${i}`);
    console.log(x);
    while (isNaN(x) || x < 0 || x > 20 || x === ``) x = prompt(`Vous n'avez pas saisi une note valide. réessayez d'entrer la note numéro ${i} !`);
    x = Number(x);
    affichage += `<li>La note <b>${i}</b> est : <b>${x}</b>/20.</li>`
    minimum(x);
    maximum(x);
    moy += x;
}
affichage += `</ul><hr>
Sur l'ensemble des ${n} notes : <br><br>
<ul>
<li class="text-success"> La plus grande note est : <b>${maxi}</b>/20 </li>
<li class="text-danger"> La plus petite note est : <b>${mini}</b>/20 </li>
<li> La moyenne des ${n} notes est : <b>${moyenne(moy)}</b>/20 </li>
</ul></p></div> `;

result.innerHTML = affichage;
