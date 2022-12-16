import React, { useState } from 'react';
import './AddContactView.css';

const AddContactView = ({ contactList, setContactList }) => {

    const [nom, setNom] = useState('');
    const [prenom, setPrenom] = useState('');
    const [email, setEmail] = useState('');
    const [telephone, setTelephone] = useState('');

    function addNewContact(e) {
        // e.preventDefault();
        alert(`${nom} ${prenom} ${email} ${telephone} a été ajouté à la liste`)
        const listTmp = [...contactList];
        listTmp.push({firstName: nom, lastName : prenom, mail : email, numero : telephone});
        setContactList(listTmp);
    }


    return (
        <div>
            <h2>AddContactView Works...</h2>
            <div className="card">
                <form onSubmit={addNewContact}>
                    <div className="form-control">
                        <h3>SetStates</h3>
                        <div className="mb-3">
                            <label htmlFor="nom">Nom : </label>
                            <input type="text" name="nom" id="nom" className='form-control' onChange={(e) => setNom(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="prenom">Prénom : </label>
                            <input type="text" name="prenom" id="prenom" className='form-control' onChange={(e) => setPrenom(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="email">Email : </label>
                            <input type="email" name="email" id="email" className='form-control' onChange={(e) => setEmail(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="telephone">Telephone : </label>
                            <input type="text" name="telephone" id="telephone" className='form-control' onChange={(e) => setTelephone(e.target.value)} />
                        </div>
                        <div className="btndiv">
                            <button type="submit" className='btn btn-success form-control'>Valider</button>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    );
}

export default AddContactView;
