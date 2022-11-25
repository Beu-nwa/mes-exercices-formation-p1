import React, { Component } from 'react';
import './DisplayContactList.css';
import { Trash3 } from 'react-bootstrap-icons';
import { PencilSquare } from 'react-bootstrap-icons';
import { CheckSquare } from 'react-bootstrap-icons';

export default class DisplayContactList extends Component {
    constructor(props) {
        super(props)
        this.state = {
            isActive: false,
            nom: "",
            prenom: "",
            email: "",
            numero: "",
        }
    }

    changeIsActive = (nom, prenom, mail, number) => {
        this.setState({
            isActive: !this.state.isActive,
            nom: nom,
            prenom: prenom,
            email: mail,
            numero: number
        })
    }

    editPerson = (e, id) => {
        e.preventDefault();
        let editedPerson = [id , this.state.nom, this.state.prenom, this.state.email, this.state.numero]
        this.props.updateContact(editedPerson)
        this.changeIsActive();
    }

    // change le state local
    ChangeNom = (e) => {
        e.preventDefault();
        this.setState({
            nom: e.target.value
        })
    }
    ChangePrenom = (e) => {
        e.preventDefault();
        this.setState({
            prenom: e.target.value
        })
    }
    ChangeEmail = (e) => {
        e.preventDefault();
        this.setState({
            email: e.target.value
        })
    }
    ChangeNumero = (e) => {
        e.preventDefault();
        this.setState({
            numero: e.target.value
        })
    }

    render() {
        return !this.state.isActive ? (
            <React.Fragment>
                <tr id='DisplayContactList'>
                    <td>{this.props.index}</td>
                    <td>{this.props.person.nom}</td>
                    <td>{this.props.person.prenom}</td>
                    <td>{this.props.person.mail}</td>
                    <td>{this.props.person.numero}</td>
                    <td>
                        <div id='btnDiv'>
                            <button className='btn btn-outline-light' onClick={() => this.changeIsActive(this.props.person.nom, this.props.person.prenom, this.props.person.mail, this.props.person.numero)}><PencilSquare /></button>
                            <button className='btn btn-outline-danger' onClick={() => this.props.deleteContact(this.props.index)}><Trash3 /></button>
                        </div>
                    </td>
                </tr>
            </React.Fragment>
        ) : (
            <React.Fragment>
                <tr id='DisplayContactList' >
                    <td>{this.props.index + 1}</td>
                    <td><input className='form-control' onChange={this.ChangeNom} type="text" name="nom" id="nom" defaultValue={this.props.person.nom} /></td>
                    <td><input className='form-control' onChange={this.ChangePrenom} type="text" name="prenom" id="prenom" defaultValue={this.props.person.prenom} /></td>
                    <td><input className='form-control' onChange={this.ChangeEmail} type="email" name="mail" id="mail" defaultValue={this.props.person.mail} /></td>
                    <td><input className='form-control' onChange={this.ChangeNumero} type="text" name="numero" id="numero" defaultValue={this.props.person.numero} /></td>
                    <td>
                        <div id='btnDiv'>
                            <button className='btn btn-outline-light' onClick={(e) => this.editPerson(e, this.props.index)}><CheckSquare /></button>
                        </div>
                    </td>
                </tr>
            </React.Fragment>
        )
    }
}
