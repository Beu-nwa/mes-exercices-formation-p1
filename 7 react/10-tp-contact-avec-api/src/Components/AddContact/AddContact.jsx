import React, { Component } from 'react'
import { JournalPlus } from 'react-bootstrap-icons';
import { Plus } from 'react-bootstrap-icons';
import './AddContact.css'

export default class AddContact extends Component {
    constructor(props) {
        super(props)
        this.state = {
            askToAdd: false
        }
    }

    changeToAddBoolean() {
        this.setState({ askToAdd: !this.state.askToAdd })
    }

    AddNewContact() {
        // let lastId = trouver le dernier id de la liste
        let genre = document.getElementById(`addgenre`).value;
        let prenom = document.getElementById(`addprenom`).value;
        let nom = document.getElementById(`addnom`).value;
        let dob = document.getElementById(`adddob`).value;
        let numero = document.getElementById(`addnumero`).value;
        let email = document.getElementById(`addemail`).value;
        // let tmpPerson = { id: lastId+1, title: genre, firstname: prenom, lastname: nom, dateOfBirth: dob, phone: numero, email: email }
        // this.props.AddContact(tmpPerson)
        this.changeToAddBoolean()
    }

    render() {
        return !this.state.askToAdd ? (
            <tr>
                <td colSpan="7" id='AddcontactTitleLine'>Ajouter un contact</td>
                <td><button className='btn btn-outline-light' onClick={() => this.changeToAddBoolean()}>Ajouter <JournalPlus /></button></td>
            </tr>
        ) : (
            <tr>
                <td>id</td>
                <td><input className='form-control' type="text" name="genre" id="addgenre" placeholder='genre' /></td>
                <td><input className='form-control' type="text" name="prenom" id="addprenom" placeholder='prenom' /></td>
                <td><input className='form-control' type="text" name="nom" id="addnom" placeholder='nom' /></td>
                <td><input className='form-control' type="text" name="dob" id="adddob" placeholder='date de naissance' /></td>
                <td><input className='form-control' type="text" name="numero" id="addnumero" placeholder='numero' /></td>
                <td><input className='form-control' type="email" name="email" id="addemail" placeholder='email' /></td>
                <td><button className='btn btn-outline-light' onClick={() => this.AddNewContact()}>Ajouter <Plus /></button></td>
            </tr>
        )
    }
}
