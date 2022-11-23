import React from 'react';
// import { ContactList } from '../../datas/ContactList';
import FormationContact from '../../components/main/FormationContact/FormationContact';
import './ContactListView.css';

// const ContactListView = () => {
const ContactListView = ({ contactList, setContactList }) => {



    function deletePerson(tabIndex){
        if(window.confirm(`Etes-vous sur de vouloir supprimer la personne n°${tabIndex+1}`)){
            let newList = contactList.filter((person,index)=> index !==tabIndex);
            console.log(newList)
            setContactList(newList);
            alert(`Le contact n0${tabIndex+1} a été supprimé!`);
        }
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
