export default class vehicules {

    constructor(marque, modele, kilometrage, annee){
        this.marque = marque;
        this.modele = modele;
        this.kilometrage = kilometrage;
        this.annee = annee;
    }

    Display(){
        // console.log(`${this.marque} ${this.modele} ${this.kilometrage} ${this.annee}`);
        return `${this.marque} - ${this.modele} - ${this.kilometrage}km - ${this.annee}`;
    }

}