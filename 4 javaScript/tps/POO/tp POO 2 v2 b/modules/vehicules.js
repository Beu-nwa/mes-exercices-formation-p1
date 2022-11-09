export default class vehicules {

    constructor(immatriculation, date) {
        this.immatriculation = immatriculation;
        this.date = date;
        this.payed = false;
        this.endDate = "";
    }

    Display() {
        // console.log(`${this.marque} ${this.modele} ${this.kilometrage} ${this.annee}`);
        return `${this.immatriculation} , ${this.date}`;
    }

    getFirstDate(){
        return this.date;
    }

    changeEndDate(x){
        this.endDate = x;
    }

    getDuration(){
        return (this.endDate-this.date)/60000;
    }

    PayTicket(){
        this.payed = true;
    }

}