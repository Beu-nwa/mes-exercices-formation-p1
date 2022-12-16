import React, { Component } from 'react';
import './DisplayTable.css';
import DisplayContactList from '../DisplayContactList/DisplayContactList';

export default class DisplayTable extends Component {
    constructor(props) {
        super(props)
    }

    render() {
        return (
            <div id='DisplayTable'>
                <table className='table table-dark table-striped'>
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Nom</th>
                            <th>Prenom</th>
                            <th id='emailTableCol'>Email</th>
                            <th>N° de téléphone</th>
                            <th>Interactions</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.props.list.map((person, index) => {
                            return (
                                <DisplayContactList
                                    key={index}
                                    index={index}
                                    person={person}
                                    deleteContact={this.props.deleteContact}
                                    updateContact={this.props.updateContact}
                                />
                            )
                        }
                        )}
                    </tbody>
                </table>
            </div>
        )
    }
}
