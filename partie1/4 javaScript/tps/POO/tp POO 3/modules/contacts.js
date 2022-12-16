export default class contacts {

    constructor(genre, firstName, lastName, dateob, phone, email ) {
        this.genre = genre;
        this.firstName = firstName;
        this.lastName = lastName;
        this.dateob = dateob;
        this.phone = phone;
        this.email = email;
    }

    // Display() {
    //     // console.log(`${this.marque} ${this.modele} ${this.kilometrage} ${this.annee}`);
    //     return `${this.immatriculation} , ${this.date}`;
    // }

    // getFirstDate(){
    //     return this.date;
    // }

    // changeEndDate(x){
    //     this.endDate = x;
    // }

    // getDuration(){
    //     return (this.endDate-this.date)/60000;
    // }

    // PayTicket(){
    //     this.payed = true;
    // }

}