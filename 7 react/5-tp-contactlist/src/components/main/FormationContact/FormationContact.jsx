import React from 'react';
import './FormationContact.css';
import { Trash3 } from 'react-bootstrap-icons';

const FormationContact = ({ contactList, setContactList, deletePerson}) => {
    // console.log(contact);
    return (

        <table className='table table-dark table-striped'>
            <thead>
                <tr>
                    <th>id</th>
                    <th>nom</th>
                    <th>prenom</th>
                    <th>email</th>
                    <th>telephone</th>
                    <th>interaction</th>
                </tr>
            </thead>
            <tbody>
                
                {contactList.map((x, index) =>
                    <tr className='formationContact' key={index}>
                        <td>{index + 1}</td>
                        <td>{x.firstName}</td>
                        <td>{x.lastName}</td>
                        <td>{x.mail}</td>
                        <td>{x.numero}</td>
                        <td><button className='btn btn-outline-danger' onClick={deletePerson(index)}><Trash3/></button></td>
                    </tr>
                )}

            </tbody>
        </table>


    );
}

export default FormationContact;
