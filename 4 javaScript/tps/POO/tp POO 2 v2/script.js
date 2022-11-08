import vehicules from "./modules/vehicules.js";

let vehiculesTable = [new vehicules("test1", new Date()), new vehicules("test2", new Date() - 900000), new vehicules("test3", new Date() - 1800000), new vehicules("test4", new Date() - 2700000)],
    affichageAlert,
    alert = document.querySelector("#alert");

const btnPayer = document.querySelector(`#btnPayer`);
const btnGetTicket = document.querySelector(`#btnGetTicket`);

console.table(vehiculesTable);

btnGetTicket.onclick = () => {
    let inputValue = document.querySelector(`#inputPlaques`).value;
    let foundedVehicule = vehiculesTable.find(x => x.immatriculation == inputValue);

    if(inputValue == "") affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Erreur, entrez votre plaque.</div>`;
    else if (!foundedVehicule) {
        vehiculesTable.push(new vehicules(inputValue, new Date()));
        affichageAlert = `<div class="alert alert-warning border my-0 mx-2">Le vehicule ${inputValue} a ete ajouté</div>`;
    }
    else affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Le vehicule existe deja</div>`;
    alert.innerHTML = affichageAlert;
    dureeAffichage();
}

btnPayer.onclick = () => {
    let inputValue = document.querySelector(`#inputPlaques`).value;
    let foundedVehicule = vehiculesTable.find(x => x.immatriculation == inputValue);

    if(inputValue == "") affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Erreur, entrez votre plaque.</div>`;
    else if (!foundedVehicule) affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Le vehicule ${inputValue} n'existe pas.</div>`;
    else {
        let dateDeRetrait = new Date();
        let d = (dateDeRetrait - (foundedVehicule.getFirstDate())) / 60000;
        affichageAlert = `<div class="alert alert-info border my-0 mx-2">Vous avez payé : ${fctPrix(d)}€ pour le véhicule ${inputValue}.</div>`;
    }

    vehiculesTable.splice(vehiculesTable.indexOf(foundedVehicule), 1);
    alert.innerHTML = affichageAlert;
    dureeAffichage();
}

function fctPrix(duree) {
    if (duree <= 15) return 0.8;
    else if (duree <= 30) return 1.30;
    else if (duree <= 45) return 1.70;
    else return 6;
}

function dureeAffichage() {
    alert.classList.remove(`d-none`);
    btnPayer.disabled = true;
    btnGetTicket.disabled = true;
    setTimeout(() => {
        alert.classList.add(`d-none`);
        alert.classList.remove(`[class^=alert-]`);
        btnPayer.disabled = false;
        btnGetTicket.disabled = false;
    }, 3000);
}