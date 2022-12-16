
const result = document.querySelector(`#result`);

var affichage = "<h2>Impots.</h2><p>",
    revenus = Number(prompt("Renseigner le montant de vos revenus ?")),
    part = Number(prompt("Combien d'adulte compose votre foyer ?")),
    partEnfants = Number(prompt("Combien d'enfant compose votre foyer ?")),
    montantsImpots;

// part = partEnfants<3? part+= partEnfants/2 : part+= partEnfants-1;
part += partEnfants<3? partEnfants/2 : partEnfants-1;
console.log(part);
revenus /= part;

if (revenus<10225) montantsImpots=0;
else if (revenus<26070) montantsImpots = (revenus-10225)*0.11;
    else if (revenus<74545) montantsImpots = 10225*0 + 15845*0.11 + (revenus-26070)*0.3;
        else if (revenus<160336) montantsImpots = 15845*0.11 + 48475*0.3 + (revenus-74545)*0.41;
            else montantsImpots = 15845*0.11 + 48475*0.3 + 85791*0.41 + (revenus-160336)*0.45 ;


affichage += `Votre foyer composé de <b>${part}</b> parts, avec un revenu de <b>${Math.round(revenus)}</b>€ par part paieras <b>${Math.round(montantsImpots)*part}</b>€ d'impots.</p>`;

result.innerHTML = affichage;


















