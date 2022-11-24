import React, { Component } from 'react';
import './DisplayContactList.css';
import { Trash3 } from 'react-bootstrap-icons';
import { PencilSquare } from 'react-bootstrap-icons';

export default class DisplayContactList extends Component {
    constructor(props) {
        super(props)
    }

    render() {
        return (
            <div id='DisplayContactList'>
                <table className='table table-dark table-striped'>
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Nom</th>
                            <th>Prenom</th>
                            <th>Email</th>
                            <th>N° de téléphone</th>
                            <th>Interactions</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.props.list.map((x, index) =>
                            <React.Fragment key={index}>
                                <tr className='formationContact'>
                                    <td>{index + 1}</td>
                                    <td>{x.nom}</td>
                                    <td>{x.prenom}</td>
                                    <td>{x.mail}</td>
                                    <td>{x.numero}</td>
                                    <td>
                                        <div id='btnDiv'>
                                            <button className='btn btn-outline-light' onClick={() => this.props.updateContact(index)}><PencilSquare /></button>
                                            <button className='btn btn-outline-danger' onClick={() => this.props.deleteContact(index)}><Trash3 /></button>
                                        </div>
                                    </td>
                                </tr>
                            </React.Fragment>
                        )}
                    </tbody>
                </table>
            </div>
        )
    }
}
