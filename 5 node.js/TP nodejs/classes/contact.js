import person from "./person.js";

export default class contact extends person {
    constructor(id, title = "" , firstname = "" , lastname = "" , dateOfBirth = "" , Phone = "" , Email = ""){
        super(id, title, firstname, lastname, dateOfBirth)
        this.Phone = Phone;
        this.Email = Email;
    }
}