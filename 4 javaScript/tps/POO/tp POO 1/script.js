import voitures from "./modules/voitures.js";
import motos from "./modules/motos.js";

let renault_Kangoo = new voitures("Renault", "Kangoo", 240000, 2003, true),
    bmw_R1150r = new motos("BMW", "R1150R ROCKSTER", 65000, 2005),
    vehicules = [renault_Kangoo, bmw_R1150r],
    affichage = "<ul>",
    result = document.querySelector("#result");

    // renault_Kangoo.Asclim();

// console.table(vehicules);

for (let item of vehicules){
    affichage += `<li>${item.Display()}</li>`;
    console.log(item);
}

affichage += `</ul>`;

result.innerHTML = affichage;