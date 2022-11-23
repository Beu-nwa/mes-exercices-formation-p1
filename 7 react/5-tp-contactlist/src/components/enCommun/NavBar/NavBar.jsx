import React from 'react';
import {Link} from 'react-router-dom';
import './NavBar.css';

// import FormationListView from '../../views/FormationListView/FormationListView';
// import FormulaireView from '../../views/FormulaireView/FormulaireView';


const NavBar = () => {
    // const NavBar = ({contact, addContact}) => { 
    // on défini la const contactList qui a ContactList comme valeur par défaut et qui a la méthode setContactList qui permet de la modifier

    return (
                <div id="NavBar">
                    <button className='bouton'>
                        <Link to="/">Home</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/list">Liste de contact</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/add">Ajout contact</Link>
                    </button>
                </div>
    );
}

export default NavBar;
