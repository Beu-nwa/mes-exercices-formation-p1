const result = document.querySelector(`#result`);

var affichage = "<h2>Categorie de l'enfant</h2><p>",
    AB = Number(prompt("Quel est la longueur en cm du premier côté AB ?")),
    BC = Number(prompt("Quel est la longueur en cm du second côté BC ?")),
    CA = Number(prompt("Quel est la longueur en cm du troisieme côté CA ?"));

affichage += `Le triangle de cotés ${AB}cm ${BC}cm ${CA}cm`

if (AB != BC && BC != CA && AB != CA) affichage += ` est <b>quelconque</b> `;
else {
    if (AB == BC && BC == CA) affichage += ` est <b>équilatéral</b> `;
    else {
        affichage += ` est <b>isocèle</b>`;
        if (AB == BC) affichage += ` en <b>B</b> `;
        else {
            if (AB == CA) affichage += ` en <b>A</b> `;
            else affichage += ` en <b>C</b> `;
        }
    }
}







affichage += `</p>`;

result.innerHTML = affichage;






















