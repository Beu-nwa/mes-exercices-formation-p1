let firstInput = true;
let isDotted = false;


const calcScreenUp = document.querySelector('#screen-up')
const calcScreenDown = document.querySelector('#screen-down')
const calcNumbers = document.querySelectorAll(`button[id^="calc-number-"], button[id^="calc-bracket-"]`)
const calcOperations = document.querySelectorAll(`button[id^="calc-operation-"]`)
const calcReset = document.querySelector('#calc-reset')
const calcEqual = document.querySelector('#calc-equal')
const calcDot = document.querySelector('#calc-dot')


calcNumbers.forEach(x => x.addEventListener('click', (event) => {
    const textValue = event.path[0].firstChild.textContent
    if (firstInput) {
        calcScreenUp.textContent = ""
        calcScreenDown.textContent = textValue
        firstInput = false
    } else {
        calcScreenDown.textContent += textValue
    }
}))

calcOperations.forEach(x => x.addEventListener('click', (event) => {
    const textValue = event.path[0].firstChild.textContent
    if (firstInput) {
        calcScreenUp.textContent = calcScreenDown.textContent + textValue
        firstInput = false;
    } else {
        if (calcScreenUp.textContent) calcScreenUp.textContent += calcScreenDown.textContent + textValue
        else calcScreenUp.textContent = calcScreenDown.textContent + textValue
    }

    calcScreenDown.textContent = ""
}))

calcReset.addEventListener('click', () => {
    calcScreenDown.textContent = ""
    calcScreenUp.textContent = ""
    isDotted = false
    firstInput = true
})

calcEqual.addEventListener('click', () => {
    calcScreenUp.textContent += calcScreenDown.textContent
    calcScreenDown.textContent = eval(calcScreenUp.textContent)
    firstInput = true
})

calcDot.addEventListener('click', () => {
    if (!firstInput && !isDotted) {
        calcScreenDown.textContent += '.'
        isDotted = true
    } else if (calcScreenDown.textContent.substring(calcScreenDown.textContent.length - 1, calcScreenDown.textContent.length) === '.') {
        calcScreenDown.textContent = calcScreenDown.textContent.substring(0, calcScreenDown.textContent.length - 1)
        isDotted = false
    }
})