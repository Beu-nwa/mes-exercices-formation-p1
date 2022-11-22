import React, { useState } from 'react';
import './AddContactView.css';
// import { ContactList } from '../../datas/ContactList';

// const AddContactView = () => {
const AddContactView = ({ contactList, setContactList }) => {

    const [nom, setNom] = useState('');
    const [prenom, setPrenom] = useState('');
    const [email, setEmail] = useState('');
    const [telephone, setTelephone] = useState('');
    // const [ContactList, setNewContact] = useState(ContactList);

    function addNewContact(e) {
        e.preventDefault();
        // e.preventDefault() sert à ne pas refresh la page
        alert(`${nom} ${prenom} ${email} ${telephone} a été ajouté à la liste`)
        // <ContactList setNewContact={nom,prenom,email,text} />;
        // console.table(contactList);
        // console.log(nom,prenom,email,text);

        let contactTmp = {firstName: nom, lastName : prenom, mail : email, numero : telephone};
        const listTmp = [...contactList];
        listTmp.push(contactTmp);
        // contactList.push(contactTmp);

        // console.table(contactList);
        console.table(listTmp);

        setContactList(listTmp);

        // const contactTMP = [nom,prenom,email,text];
        // setNewContact(contactTMP)
        // ContactList.push(contactTMP);
        // console.log(ContactList);
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
                            <input type="text" name="email" id="email" className='form-control' onChange={(e) => setEmail(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="telephone">Telephone : </label>
                            <input type="text" name="telephone" id="telephone" className='form-control' onChange={(e) => setTelephone(e.target.value)} />
                        </div>
                        <div className="btndiv">
                            <button type="submit" className='btn btn-info form-control'>Valider</button>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    );
}

export default AddContactView;
