import vehicules from "./vehicules.js";

export default class motos extends vehicules {
    constructor(marque, modele, kilometrage, annee){
        super(marque, modele, kilometrage, annee);
    }
    Display(){
        // console.log(`${this.marque} ${this.modele} ${this.kilometrage} ${this.annee}`);
        // console.log(`Moto : `);
        return `<b>Moto</b> : ${super.Display()}`;
    }
}