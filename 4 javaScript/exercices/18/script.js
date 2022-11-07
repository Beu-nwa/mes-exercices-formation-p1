var txt = `
Distributeur de boissons

            1/ Eau
            2/ Jus d'orange
            3/ Limonade
            4/ Café
            5/ Thé          
Faites votre choix:`,
    choix = Number(prompt(`${txt}`)),
    reponse;

switch (choix) {
    case 1 : reponse = `eau`;
        break;
    case 2 : reponse = `Jus d'orange`;
        break;
    case 3 : reponse = `Limonade`;
        break;
    case 4 : reponse = `Café`;
        break;
    case 5 : reponse = `Thé`;
        break;
    default : { alert("Veuillez entrer une saisie valide")
        choix = Number(prompt(`${txt}`))};
        break;
}

alert(`${txt} ${choix}
Voici votre boisson : ${reponse}`)
















