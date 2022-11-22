import React, {useState} from 'react';
import {
    BrowserRouter,
    Routes,
    Route,
    Outlet,
    Link
} from 'react-router-dom';
import './NavBar.css';
import HomeView from '../../../Views/HomeView/HomeView';
import ContactListView from '../../../Views/ContactListView/ContactListView';
import AddContactView from '../../../Views/AddContactView/AddContactView';
import { ContactList } from '../../../datas/ContactList';

// import FormationListView from '../../views/FormationListView/FormationListView';
// import FormulaireView from '../../views/FormulaireView/FormulaireView';


const NavBar = () => {
    // const NavBar = ({contact, addContact}) => {
    const [contactList, setContactList] = useState(ContactList); 
    // on défini la const contactList qui a ContactList comme valeur par défaut et qui a la méthode setContactList qui permet de la modifier

    return (
        <div>
            <BrowserRouter>
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
                <Routes>
                    <Route path="/" element={<HomeView />} />
                    {/* <Route path="/list" element={<ContactListView />} /> */}
                    <Route path="/list" element={<ContactListView contactList={contactList} setContactList={setContactList}/>} />
                    {/* <Route path="/add" element={<AddContactView />} /> */}
                    <Route path="/add" element={<AddContactView contactList={contactList} setContactList={setContactList}/>} />
                </Routes>
            </BrowserRouter>
            <div className="container">
                <Outlet />
            </div>
        </div>
    );
}

export default NavBar;
