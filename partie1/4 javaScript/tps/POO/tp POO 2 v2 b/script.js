import vehicules from "./modules/vehicules.js";

let vehiculesTable = [
    new vehicules("test1", new Date()),
    new vehicules("test2", new Date() - 900000),
    new vehicules("test3", new Date() - 1800000),
    new vehicules("test4", new Date() - 2700000)],
    affichageAlert,
    inputValue,
    foundedVehicule,
    alert = document.querySelector("#alert");

function getValues() {
    inputValue = document.querySelector(`#inputPlaques`).value;
    foundedVehicule = vehiculesTable.find(x => x.immatriculation == inputValue);
}

function fctPrix(duree) { return duree <= 15 ? 0.8 : duree <= 30 ? 1.30 : duree <= 45 ? 1.70 : duree <= 60 ? 2.10 : duree <= 120 ? 4.10 : duree <= 240 ? 8 : duree <= 720 ? 20 : duree <= 1440 ? 35 : 60; }

function dureeAffichage() {
    alert.innerHTML = affichageAlert;
    alert.classList.remove(`d-none`);
    btnPayer.disabled = true;
    btnExit.disabled = true;
    btnGetTicket.disabled = true;
    setTimeout(() => {
        alert.classList.add(`d-none`);
        alert.classList.remove(`[class^=alert-]`);
        btnPayer.disabled = false;
        btnExit.disabled = false;
        btnGetTicket.disabled = false;
    }, 3000);
}

document.querySelector(`#btnGetTicket`).onclick = () => {
    getValues();
    inputValue == "" ? affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Erreur, entrez votre plaque.</div>` : !foundedVehicule ? (vehiculesTable.push(new vehicules(inputValue, new Date())), affichageAlert = `<div class="alert alert-warning border my-0 mx-2">Le vehicule ${inputValue} a ete ajouté</div>`) : affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Le vehicule existe deja</div>`;
    dureeAffichage();
}

document.querySelector(`#btnPayer`).onclick = () => {
    getValues();
    inputValue == "" ? affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Erreur, entrez votre plaque.</div>` : !foundedVehicule ? affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Le vehicule ${inputValue} n'existe pas.</div>` : !foundedVehicule.payed ? (foundedVehicule.changeEndDate(new Date()), affichageAlert = `<div class="alert alert-info border my-0 mx-2">Vous avez payé : ${fctPrix(foundedVehicule.getDuration())}€ pour le véhicule ${inputValue}.</div>`, foundedVehicule.PayTicket()) : affichageAlert = `<div class="alert alert-warning border my-0 mx-2">Vous avez déjà payé pour le véhicule ${inputValue}.</div>`;
    dureeAffichage();
}

document.querySelector(`#btnExit`).onclick = () => {
    getValues();
    inputValue == "" ? affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Erreur, entrez votre plaque.</div>` : !foundedVehicule ? affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Le vehicule ${inputValue} n'existe pas.</div>` : !foundedVehicule.payed ? affichageAlert = `<div class="alert alert-danger border my-0 mx-2">Le ticket du vehicule ${inputValue} n'a pas été payé.</div>` : (affichageAlert = `<div class="alert alert-success border my-0 mx-2">Vous pouvez sortir le véhicule ${inputValue}.</div>`, vehiculesTable.splice(vehiculesTable.indexOf(foundedVehicule), 1));
    dureeAffichage();
}

// ^[A-Z]{2}[-][0-9]{3}[-][A-Z]{2}$

// document.querySelector(`#inputPlaques`).addEventListener(`beforeinput`, updateValue);
// function updateValue(e) {
//     // log.textContent = e.target.value;
//     console.log(e.target.value);
// }

// document.querySelector(`#inputPlaques`).keydown = (e) => {
//     // console.log(document.querySelector(`#inputPlaques`).value);
//     console.log(document.querySelector(`#inputPlaques`).length);
//     console.log(e);
// }

document.querySelector('#inputPlaques').addEventListener('keyup', function (event) {
    // if (event.key === 'Enter') {
    //     fctValidationTentative()
    // }

    let taillePlaque = document.querySelector(`#inputPlaques`).value.length,
        chainePlaque = document.querySelector(`#inputPlaques`).value,
        caract = chainePlaque[taillePlaque - 1];

    switch (true) {
        case (taillePlaque <= 2): {
            if (caract >= "A" && caract <= "Z") console.log(`${caract} est valide`);
            else {
                console.log(`${caract} n'est pas valide`);
                chainePlaque.splice(taillePlaque - 1, 1)
            }
        };
            break;
        default: console.log("cas par defaut");
            break;
    }
});