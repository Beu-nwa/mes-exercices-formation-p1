const result = document.querySelector(`#result`);
var affichage = "";

console.log(`la valeur de pi est : ${Math.PI}`);
var d = Number(prompt("rentrer le diametre d de votre cercle (en cm)"));
console.log(`vous avez entré un diametre de ${d} cm`);
var perimetre = d*Math.PI;
var aire = Math.PI * Math.pow((d/2),2)
console.log(`le perimetre fait ${perimetre} cm`);
console.log(`l'aire fait ${aire} cm²`);

affichage += `<p>cercle de diametre <b>${d}</b>, de perimetre ${perimetre}, d'aire ${aire}`;
affichage += `</p>`;
// alert(affichage);
result.innerHTML = affichage;