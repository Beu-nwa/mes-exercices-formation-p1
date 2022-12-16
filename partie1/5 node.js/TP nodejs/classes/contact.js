import person from "./person.js";

export default class contact extends person {
    constructor(id, title = "" , firstname = "" , lastname = "" , dateOfBirth = "" , urlImg = "", Phone = "" , Email = ""){
        super(id, title, firstname, lastname, dateOfBirth, urlImg)
        this.Phone = Phone;
        this.Email = Email;
    }

    toString(){
        return `${super.toString()}, tel: ${this.Phone}, Email: ${this.Email}`;
    }
}