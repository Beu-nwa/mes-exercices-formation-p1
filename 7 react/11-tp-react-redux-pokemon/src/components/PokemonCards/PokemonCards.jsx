import React, { Component } from 'react';
import './PokemonCards.css';

export default class PokemonCards extends Component {
    constructor(props){
        super(props)
    }
    render() {
        return (
                <li>
                    {this.props.pokemon.name}
                </li>
        )
    }
}
