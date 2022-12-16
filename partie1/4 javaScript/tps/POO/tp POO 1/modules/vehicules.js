export default class vehicules {

    constructor(marque, modele, kilometrage, annee) {
        this.marque = marque;
        this.modele = modele;
        this.kilometrage = kilometrage;
        this.annee = annee;
    }

    // millier(nbr) {
    //     let nombre = nbr.toString();
    //     let editNbr = "";
    //     for (let i = nombre.length ; i > 0; i-- ) {
    //         if (i % 3 == 0) editNbr = `${nombre[i]}.${editNbr}`;
    //     }
    //     return editNbr;
    // }

    // millier(nbr) {
    //     let nombre = '' + nbr;
    //     let retour = '';
    //     let count = 0;
    //     for (let i = nombre.length - 1; i >= 0; i--) {
    //         if (count != 0 && count % 3 == 0)
    //             retour = nombre[i] + '.' + retour;
    //         else
    //             retour = nombre[i] + retour;
    //         count++;
    //     }

    //     return retour;
    // }

    Display() {
        // console.log(`${this.marque} ${this.modele} ${this.kilometrage} ${this.annee}`);
        return `${this.marque} - ${this.modele} - ${this.millier(this.kilometrage)}km - ${this.annee}`;
    }

}