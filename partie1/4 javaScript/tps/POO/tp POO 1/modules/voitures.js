import vehicules from "./vehicules.js";

export default class voitures extends vehicules {
    constructor(marque, modele, kilometrage, annee, clim){
        super(marque, modele, kilometrage, annee);
        this.clim = clim;
    }

    Display(){
        // console.log(`${this.marque} ${this.modele} ${this.kilometrage} ${this.annee}`);
        // console.log(`Voiture : `);
        // super.Display();
        // console.log(`${this.clim}`);
        return `<b>Voiture</b> ${super.Display()} ${this.clim? ", climatisée." : ", non climatisée."} : `;
    }

    // Asclim(){
    //     this.clim = true;
    // }
}