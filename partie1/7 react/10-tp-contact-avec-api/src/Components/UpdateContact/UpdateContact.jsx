import React, { Component } from 'react'
import './UpdateContact.css'
import { Trash3 } from 'react-bootstrap-icons';
import { PencilSquare } from 'react-bootstrap-icons';
import { CheckSquare } from 'react-bootstrap-icons';

export default class FormContact extends Component {
    constructor(props) {
        super(props)
        this.state = {
            isActive: false,
        }
    }

    changeIsActive = () => {
        this.setState({
            isActive: !this.state.isActive,
        })
    }

    // componentDidUpdate
    editPerson = (e) => {
        e.preventDefault();
        let genre = document.getElementById(`updategenre`).value;
        let prenom = document.getElementById(`updateprenom`).value;
        let nom = document.getElementById(`updatenom`).value;
        let dob = document.getElementById(`updatedob`).value;
        let numero = document.getElementById(`updatenumero`).value;
        let email = document.getElementById(`updateemail`).value;
        let tmpPerson = { id: this.props.person.id, title: genre, firstname: prenom, lastname: nom, dateOfBirth: dob, phone: numero, email: email }
        // ajouter tmpPerson à l'api
        this.props.updateContact(tmpPerson)
        this.changeIsActive();
    }

    render() {
        return !this.state.isActive ? (
            <React.Fragment>
                <tr id='FormContact'>
                    {/* <td>{this.props.index}</td> */}
                    <td>{this.props.person.id}</td>
                    <td>{this.props.person.title}</td>
                    <td>{this.props.person.firstname}</td>
                    <td>{this.props.person.lastname}</td>
                    <td>{this.props.person.dateOfBirth}</td>
                    <td>{this.props.person.phone}</td>
                    <td>{this.props.person.email}</td>
                    <td>
                        <div id='btnDiv'>
                            <button className='btn btn-outline-light' onClick={() => this.changeIsActive()}><PencilSquare /></button>
                            <button className='btn btn-outline-danger' onClick={() => this.props.deleteContact(this.props.person.id)}><Trash3 /></button>
                        </div>
                    </td>
                </tr>
            </React.Fragment>
        ) : (
            <React.Fragment>
                <tr id='FormContact' >
                    <td>{this.props.person.id}</td>
                    <td><input className='form-control' type="text" name="genre" id="updategenre" defaultValue={this.props.person.title} /></td>
                    <td><input className='form-control' type="text" name="prenom" id="updateprenom" defaultValue={this.props.person.firstname} /></td>
                    <td><input className='form-control' type="text" name="nom" id="updatenom" defaultValue={this.props.person.lastname} /></td>
                    <td><input className='form-control' type="text" name="dob" id="updatedob" defaultValue={this.props.person.dateOfBirth} /></td>
                    <td><input className='form-control' type="text" name="numero" id="updatenumero" defaultValue={this.props.person.phone} /></td>
                    <td><input className='form-control' type="email" name="email" id="updateemail" defaultValue={this.props.person.email} /></td>
                    <td>
                        <div id='btnDiv'>
                            <button className='btn btn-outline-light' onClick={(e) => this.editPerson(e)}><CheckSquare /></button>
                        </div>
                    </td>
                </tr>
            </React.Fragment>
        )
    }
}
