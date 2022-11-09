import contacts from "./modules/contacts.js";

let contactsList = [
    new contacts("Mr", "Dupont", "Jean", "06/10/1973", "+(33)6 12 36 54 78", "jdupont@gmail.com"),
    new contacts("Mme", "Doe", "Jeanne", "24/02/1985", "+(33)6 45 23 87 14", "jdoe@yahooe.fr"),
    new contacts("Mr", "Martin", "Jacques", "22/06/1933", "+(33)6 78 45 24 95", "jmartin@petitrapporteur.fr")],
    affichage = "",
    inputGender,
    inputFirstName,
    inputLastName,
    inputDateOB,
    inputPhone,
    inputMail,
    tableBodyContent = document.querySelector("#tableBodyContent");

function tableGeneration() {
    affichage = "";
    for (const item of contactsList) {
        affichage += `<tr><td>${item.genre}</td><td>${item.firstName}</td><td>${item.lastName}</td><td>${item.dateob}</td><td>${item.phone}</td><td>${item.email}</td></tr>`;
    }
    tableBodyContent.innerHTML = affichage;
}

document.querySelector(`#addBtn`).onclick = () => {

    try {
        inputGender = document.querySelector(`input[name="gender"]:checked`).value
    } catch (error) {
        console.log(error.message);
        inputGender = "";
    }
    // finally {
    // permet d'executer du code quelque soit s'il y a une erreur ou non
    // }

    // inputGender = document.querySelector(`input[name="gender"]:checked`).value? document.querySelector(`input[name="gender"]:checked`).value : "" ;
    // inputGender = document.querySelector(`.radioInput`).value;
    inputFirstName = document.querySelector(`#inputFirstName`).value;
    inputLastName = document.querySelector(`#inputLastName`).value;
    inputDateOB = document.querySelector(`#inputDateOB`).value;
    inputPhone = document.querySelector(`#inputPhone`).value;
    inputMail = document.querySelector(`#inputMail`).value;

    if (isSelected()) {
        contactsList.push(
            new contacts(
                inputGender,
                inputFirstName,
                inputLastName,
                inputDateOB,
                inputPhone,
                inputMail));
    }
    else alert(`Il manque un parametre dans la saisie du nouveau contact`)

    tableGeneration();
}

function isSelected() {
    return inputGender && inputFirstName && inputLastName && inputDateOB && inputPhone && inputMail ? true : false;
}

window.onload = tableGeneration();
