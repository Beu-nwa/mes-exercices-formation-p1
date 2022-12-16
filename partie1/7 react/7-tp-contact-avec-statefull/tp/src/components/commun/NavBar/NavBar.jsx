import React, { Component } from 'react';
import {Link} from 'react-router-dom';
import './NavBar.css';


class NavBar extends Component {

    render() {
        return (
            <div id="NavBar">
                <button className='btn btn-outline-dark'>
                    <Link to="/">Home</Link>
                </button>
                <button className='btn btn-outline-dark'>
                    <Link to="/list">Liste de contact</Link>
                </button>
                <button className='btn btn-outline-dark'>
                    <Link to="/add">Ajout contact</Link>
                </button>
            </div>
        );
    }
}

export default NavBar;
