import React, { Component } from 'react';
import './ContactView.css';
import DisplayTable from '../../components/main/DisplayTable/DisplayTable';
// import FormToUpdateContact from '../../components/main/FormToUpdateContact/FormToUpdateContact';


class ContactView extends Component {
    constructor(props) {
        super(props)
    }

    deleteContact = (tabIndex) => {
        if (window.confirm(`Etes-vous sur de vouloir supprimer la personne n°${tabIndex + 1}`)) {
            let newList = [...this.props.list.filter((person, index) => index !== tabIndex)];
            this.props.setContactList(newList);
        }
    }

    updateContact = (contact) => {
        [...this.props.list].map((x, index) => {
            if (index == contact[0]) {
                x.nom = contact[1];
                x.prenom = contact[2];
                x.mail = contact[3];
                x.numero = contact[4]
            }
        })
    }

    render() {
        return (
            <div id="ContactView">
                {/* <div className="my-2">
                    <FormToUpdateContact />
                </div> */}
                <DisplayTable list={this.props.list} deleteContact={this.deleteContact} updateContact={this.updateContact} />
            </div>
        );
    }
}

export default ContactView;
