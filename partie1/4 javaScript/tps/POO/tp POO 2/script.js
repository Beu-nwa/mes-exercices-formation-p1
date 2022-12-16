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
    if (!foundedVehicule) {
        vehiculesTable.push(new vehicules(inputValue, new Date()));
        affichageAlert = `Le vehicule ${inputValue} a ete ajouté`;
        fctAlertColor("warning");
    }
    else {
        affichageAlert = `Le vehicule existe deja`;
        fctAlertColor("danger");
    }
    alert.innerHTML = affichageAlert;
    dureeAffichage();
}

btnPayer.onclick = () => {
    let inputValue = document.querySelector(`#inputPlaques`).value;
    let foundedVehicule = vehiculesTable.find(x => x.immatriculation == inputValue);

    if (!foundedVehicule) {
        affichageAlert = `Le vehicule ${inputValue} n'existe pas.`;
        fctAlertColor("danger");
    }
    else {
        let dateDeRetrait = new Date();
        let d = (dateDeRetrait - (foundedVehicule.getFirstDate())) / 60000;
        affichageAlert = `Vous avez payé : ${fctPrix(d)}€ pour le véhicule ${inputValue}.`;
        fctAlertColor("info");
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

function fctAlertColor(x) {
    alert.classList.remove(`d-none`);
    switch (x) {
        case "danger":
            alert.classList.add(`alert-danger`);
            break;
        case "warning": alert.classList.add(`alert-warning`);
            break;
        case "info": alert.classList.add(`alert-info`);
            break;
        case "success": alert.classList.add(`alert-success`);
            break;
    }
}

function dureeAffichage() {
    btnPayer.disabled = true;
    btnGetTicket.disabled = true;
    setTimeout(() => {
        alert.classList.add(`d-none`);
        // alert.classList.remove(`[class^=alert-]`); ---------> ne fonctionne pas
        alert.classList.remove(`alert-danger`);
        alert.classList.remove(`alert-info`);
        alert.classList.remove(`alert-warning`);
        btnPayer.disabled = false;
        btnGetTicket.disabled = false;
    }, 3000);
}