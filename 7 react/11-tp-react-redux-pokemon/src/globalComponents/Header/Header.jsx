import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import './Header.css';

export default class Header extends Component {
    render() {
        return (
            <div id="NavBar">
                <div className='leftSide'>
                    <img src="" alt="" />
                    <Link to="/">Home</Link>
                </div>
                <div className='center'>
                    <h1>Mon Pokedex</h1>
                </div>
                <div className='rightSide'>
                    <div className='pokeballDiv'>

                    </div>
                    <div className='btnDiv'>
                        <button>Clear</button>
                        <button>Show</button>
                    </div>
                </div>
            </div>




            // <div id="NavBar">
            //     <button className='btn btn-outline-dark'>
            //         <Link to="/">Home</Link>
            //     </button>
            //     <button className='btn btn-outline-dark'>
            //         {/* <Link to="/list">Liste de contact</Link> */}
            //     </button>
            //     <button className='btn btn-outline-dark'>
            //         {/* <Link to="/add">Ajout contact</Link> */}
            //     </button>
            // </div>
        )
    }
}