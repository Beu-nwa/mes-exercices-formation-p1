import React from 'react';
// import { ContactList } from '../../datas/ContactList';
import FormationContact from '../../components/main/FormationContact/FormationContact';
import './ContactListView.css';

// const ContactListView = () => {
const ContactListView = ({ contactList, setContactList }) => {

    // let contactArray = contact;

    // function setNewContact(nom, prenom, email, telephone) {
    //     contactArray.push(id,nom, prenom, email, telephone)
    // }
    // console.log(contact)

    function deletePerson(id){
        if(window.confirm(`etes vous sur de vouloir sup la personne à l'id: ${id}`)) alert('deleted')
    }

    return (
        <div className='contactList'>
            <h2>ContactListView Works...</h2>
            <div className="contactContainer">
                <FormationContact contactList={contactList} setContactList={setContactList} deletePerson={deletePerson} />
            </div>
        </div>
    );
}

export default ContactListView;
