import React from 'react';
import './Header.css';
import NavBar from '../NavBar/NavBar';

// const Header = ({contact, addContact}) => {
    const Header = () => {
    return (
        <div className='Header'>
            <h1>TP REACT contacts</h1>
            <NavBar />       
            {/* <NavBar contact={contact} addContact={addContact} />        */}
        </div>
    );
}

export default Header;
