export default class person {
    constructor(id, title, firstname, lastname, dateOfBirth, urlImg ){
        this.id = id;
        this.title = title;
        this.firstname = firstname;
        this.lastname = lastname;
        this.dateOfBirth = dateOfBirth;
        this.urlImg = urlImg;
        this.created = new Date();
        this.updated = "";
    }

    update(){
        this.updated = new Date()
    }

    toString(){
        return `id: ${this.id}, genre: ${this.title}, firstname: ${this.firstname}, lastname: ${this.lastname}, dateOfBirth: ${this.dateOfBirth}`;
    }
}