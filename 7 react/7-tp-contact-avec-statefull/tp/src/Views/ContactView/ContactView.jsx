import React, { Component } from 'react';
import './ContactView.css';
import DisplayContactList from '../../components/main/DisplayContactList/DisplayContactList';
import FormToUpdateContact from '../../components/main/FormToUpdateContact/FormToUpdateContact';


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

    updateContact = (tabIndex) => {
        console.log([...this.props.list]);
        [...this.props.list].map((x, index) => {
            if (index == tabIndex) console.log(x);
        })
    }

    render() {
        return (
            <div id="ContactView">
                <div className="my-2">
                    <FormToUpdateContact />
                </div>
                <DisplayContactList list={this.props.list} deleteContact={this.deleteContact} updateContact={this.updateContact} />
            </div>
        );
    }
}

export default ContactView;
