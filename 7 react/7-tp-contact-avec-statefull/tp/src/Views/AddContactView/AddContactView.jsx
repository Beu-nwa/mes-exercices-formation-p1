import React, { Component } from 'react';
import './AddContactView.css';
import FormToAddContact from '../../components/main/FormToAddContact/FormToAddContact';


class AddContactView extends Component {
    constructor(props) {
        super(props)
    }

    render() {
        return (
            <div id="AddContactView">
                <h2>Formulaire d'ajout de contact</h2>
                <FormToAddContact list={this.props.list} setContactList={this.props.setContactList}/>
            </div>
        );
    }
}

export default AddContactView;
