result = document.querySelector(`#result`);

let n = Number(prompt(`Combien de note devez vous entrer ?`)),
    tableauDeNote = [],
    affichage = `<h2>Notes élèves : </h2><hr>`;

while (isNaN(n) || n < 2) n = Number(prompt(`Vous n'avez pas saisi un nombre de note valide, réessayez !`));

alert(`Vous avez choisi d'entrer ${n} notes.`)

affichage += `<div> <p> Vous avez choisi d'entrer <b>${n}</b> notes notées sur 20. <ul>`;

for (let i = 1; i <= n; i++) {
    let x = Number(prompt(`Veuillez entrer la note numéro ${i}`));
    while (isNaN(x) || x < 0 || x > 20) x = Number(prompt(`Vous n'avez pas saisi une note valide. réessayez d'entrer la note numéro ${i} !`));
    affichage += `<li>La note <b>${i}</b> est : <b>${x}</b>/20.</li>`
    tableauDeNote.push(x)
}
console.table(tableauDeNote);

affichage += `</ul><hr>
Sur l'ensemble des ${n} notes : <br><br><ul>
<li class="text-success"> La plus grande note est : <b>${tableauDeNote.reduce((a, b) => Math.max(a, b), -Infinity)}</b>/20 </li>
<li class="text-danger"> La plus petite note est : <b>${tableauDeNote.reduce((a, b) => Math.min(a, b), Infinity)}</b>/20 </li>
<li> La moyenne des ${n} notes est : <b>${tableauDeNote.reduce((a, b) => a + b, 0) / tableauDeNote.length}</b>/20 </li>
</ul></p></div> `;

result.innerHTML = affichage;
