import React, { Component } from 'react';
import logoPokemon from '../../assets/img/logoPokemon.png'
import pokeball from '../../assets/img/pokeball.png'
import './Header.css';

export default class Header extends Component {
    render() {
        return (
            <div id="NavBar" className='row'>
                <div id='leftSide' className='col col-4'>
                    <img id='logo' src={logoPokemon} alt="logo international Pokemon" />
                    <a href="https://www.pokemon.com/fr/" rel="noreferrer" target="_blank">Home</a>
                </div>
                <div id='center' className='col col-4'>
                    <h1>Mon Pokedex</h1>
                </div>
                <div id='rightSide' className='col col-4'>
                    <div id='pokeballCounterContainer'>
                        <div id='box1'>
                            <img id='PokeballImg' src={pokeball} alt="Pokeball" />
                        </div>
                        <div id='box2'>0</div>
                        <div id='box3'>Pokeball</div>
                    </div>
                    <div id='btnDiv'>
                        <button className='btn btn-light border-info'>Clear</button>
                        <button className='btn btn-light border-info'>Show</button>
                    </div>
                </div>
            </div>
        )
    }
}