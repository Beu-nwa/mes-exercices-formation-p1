export default class vehicules {

    constructor(immatriculation, date) {
        this.immatriculation = immatriculation;
        this.date = date;
    }

    Display() {
        // console.log(`${this.marque} ${this.modele} ${this.kilometrage} ${this.annee}`);
        return `${this.immatriculation} , ${this.date}`;
    }

    getFirstDate(){
        return this.date;
    }

}