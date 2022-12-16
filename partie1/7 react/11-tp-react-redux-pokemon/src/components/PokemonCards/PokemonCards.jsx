import React, { Component } from 'react';
import './PokemonCards.css';

export default class PokemonCards extends Component {
    constructor(props) {
        super(props)
    }
    render() {
        return (
            // <div id='pokemonCards'>
                <div className='card col col-6'>
                    {this.props.pokemon.name}
                </div>
            // </div>
        )
    }
}
