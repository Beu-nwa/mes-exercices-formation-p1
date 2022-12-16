let nbrLife = 5;
let nbMax = 50;
let nbMin = 1;
let nbMystere = 0;

const nbrLifeOutput = document.querySelector('#nbr-life')
const mysteryStart = document.querySelector('#mystery-start')
const mysteryGame = document.querySelector('#mystery-game')
const difficultyChoice = document.querySelector('#game-difficulty')
const buttonStart = document.querySelector('#button-start')
const buttonPlayAgain = document.querySelector('#button-play-again')
const nbMinSpan = document.querySelector('#number-min')
const nbMaxSpan = document.querySelector('#number-max')
const btnTry = document.querySelector('#button-try')
const nbrInput = document.querySelector('#nbr-input')
const messageOutput = document.querySelector('#message')


buttonStart.addEventListener('click', () => {
    mysteryStart.classList.add('d-none');
    mysteryGame.classList.remove('d-none');
    
    messageOutput.innerHTML = `Veuilliez entrer un nombre entre <span id="number-min">${nbMin}</span> et <span
    id="number-max">${nbMax}</span>`;
    nbrInput.value = "";

    nbMystere = Math.floor(Math.random() * (nbMax - nbMin + 1)) + nbMin;

    nbrLife = 5;

    refreshLifes();

    btnTry.disabled = false;
    nbrInput.disabled = false;


})

btnTry.addEventListener('click', () => {
    const nbSend = +nbrInput.value;

    if (nbSend == nbMystere) {
        messageOutput.innerHTML = `Bravo, vous avez gagné !`;
    } else if (nbSend > nbMystere) {
        messageOutput.innerHTML = `Trop grand !`;
        nbrLife -= 0.5;
    } else {
        messageOutput.innerHTML = `Trop petit`;
        nbrLife -= 0.5;
    }

    refreshLifes();

    if (nbrLife <= 0) {
        messageOutput.innerHTML = `Vous avez perdu !`;
        btnTry.disabled = true;
        nbrInput.disabled = true;

    }
})

difficultyChoice.addEventListener('change', () => {
    if (difficultyChoice.value != 0) buttonStart.removeAttribute('disabled')
    else buttonStart.setAttribute('disabled', "true")

    switch (difficultyChoice.value) {
        case "1":
            nbMax = 20;
            break;
        case "3":
            nbMax = 100;
            break;
        default:
            nbMax = 50;
            break;
    }

    // let mySound = new Audio("./assets/applause-2.mp3")
    // mySound.play();
})

document.querySelector('#button-play-again').addEventListener('click', () => {
    mysteryStart.classList.remove('d-none');
    mysteryGame.classList.add('d-none');
})

const refreshLifes = () => {
    nbrLifeOutput.innerHTML = ""

    for (let i = 0; i < Math.floor(nbrLife); i++) {
        nbrLifeOutput.innerHTML += `<i class="bi bi-heart-fill me-2 text-danger"></i>`;
    }
    if (nbrLife != Math.floor(nbrLife)) nbrLifeOutput.innerHTML += `<i class="bi bi-heart-half me-2 text-danger"></i>`;
    for (let i = 0; i < 5 - Math.ceil(nbrLife); i++) {
        nbrLifeOutput.innerHTML += `<i class="bi bi-heart me-2"></i>`;
    }
}

refreshLifes();