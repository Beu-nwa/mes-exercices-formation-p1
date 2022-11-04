function isTentativeCorrecte (x){
    textNbCoups.innerHTML = `Nombre de coups ${++nbCoups}`;
    if((x < nbMyster) && (x >= minimum)) affichage = `Le nombre mystère est <b>plus grand</b> que <b>${x}</b>.`;
    else if((x > nbMyster) && (x <= maximum)) affichage = `Le nombre mystère est <b>plus petit</b> que <b>${x}</b>.`;
    else if(x == nbMyster) {
        affichage = `Vous avez trouvé le nombre mystère <b>${nbMyster}</b>.`;
        text.innerHTML = affichage;
        document.querySelector(`.divDuBas`).style.display = "none";
    }
    else affichage = `La valeur : <b>${x}</b> n'est pas correcte.`;

    text.innerHTML = affichage;
    document.querySelector(`#tentativeInput`).value = "";
}

text = document.querySelector(`#text`);
textNbCoups = document.querySelector(`#textNbCoups`);

let nbCoups = 0,
    maximum = 50,
    minimum = 0,
    success = false,
    affichage = `Trouvez le nombre mystère qui se situe entre ${minimum} et ${maximum}`,
    nbMyster = Math.round(Math.random() * 50),
    affichageNbDeCoups;

function fctValidationTentative(){
    isTentativeCorrecte (valueTentative = document.querySelector(`#tentativeInput`).value);
}

document.querySelector('#tentativeInput').addEventListener('keypress', function (event) {
    if (event.key === 'Enter') {
        fctValidationTentative()
    }
});

function fctRejouer(){
    window.location.reload();
}


affichageNbDeCoups = `Nombre de coups ${nbCoups}`;

text.innerHTML = affichage;
textNbCoups.innerHTML = affichageNbDeCoups;