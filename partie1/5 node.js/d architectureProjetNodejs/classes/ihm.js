// ihm = interface home machine

import { askQuestion } from "../helper.js";

export default class Ihm {
    constructor(){
        this.personnes = [];
    }

    async menu() {
        let choix;
        do{
            console.log("1: ajouter une personne");
            console.log("2: Afficher la liste de personne");
            console.log("0: Quitter");
            choix = await askQuestion("Veuillez faire votre choix : ")

            switch(choix){
                case "1" :
                    // recuperer le flux clavier pour creer un objet personne
                    const nom = await askQuestion("Veuillez saisir un nom");
                    const prenom = await askQuestion("Veuillez saisir un prenom");
                    this.personnes.push({nom:nom, prenom:prenom});
                    console.log("choix 1");
                break;
                case "2" : 
                // itérer notre collection personne et affcicher son contenu
                    this.personnes.forEach(person => {
                        console.log(`nom:${person.nom}, prenom:${person.prenom}`);
                    })
                    console.log("choix 2");
                break;
                default:
                    console.log("Veuillez faire le choix 0, 1 ou 2");
                break;
            }

        }while(choix != "0")
        console.log("A bientot");
    };
}