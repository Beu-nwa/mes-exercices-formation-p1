export default class person {
    constructor(id, title, firstname, lastname, dateOfBirth ){
        this.id = id;
        this.title = title;
        this.firstname = firstname;
        this.lastname = lastname;
        this.dateOfBirth = dateOfBirth;
        this.created = new Date();
        this.updated = "";
    }

    update(){
        this.updated = new Date()
    }
}