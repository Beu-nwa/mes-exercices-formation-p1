import vehicules from "./vehicules.js";

export default class voitures extends vehicules {
    constructor(marque, modele, kilometrage, annee){
        super(marque, modele, kilometrage, annee);
        this.clim = false;
    }

    Display(){
        // console.log(`${this.marque} ${this.modele} ${this.kilometrage} ${this.annee}`);
        // console.log(`Voiture : `);
        // super.Display();
        // console.log(`${this.clim}`);
        let text;
        if(this.clim) text = "climatisé.";
        return `<b>Voiture</b> ${super.Display()} ${text} : `;
    }

    Asclim(){
        this.clim = true;
    }
}