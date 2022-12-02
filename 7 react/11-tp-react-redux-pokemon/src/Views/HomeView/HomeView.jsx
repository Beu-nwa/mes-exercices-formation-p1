// remplacer par un composant redux rrc
import React, { Component } from 'react';
import { getPokemonApi } from '../../api/PokemonApiService';
import PokemonCards from '../../components/PokemonCards/PokemonCards';
import './HomeView.css';

export default class HomeView extends Component {
    constructor(props) {
        super(props);
        this.state = {
            name: "",
            pokemonList: [],
            detailsData: [],
            url: "",
        }
    }


    // Methode locale pour récuprer la reponse de l'api et set le state local contact
    FetchPokemonList = async () => {
        let response = await getPokemonApi();
        this.setState({
            pokemonList: [...response.data.results],
        })
    }
    FetchPokemonDetails = async () => {
        let response = await getPokemonApi(this.state.url);
        this.setState({
            detailsData: [...response],
        })
        console.log(this.state.detailsData)
    }

    async componentDidMount() {
        this.FetchPokemonList();
        this.FetchPokemonDetails();
    }

    render() {
        return (
            <div id='cardsContainer' className='row'>
                    {this.state.pokemonList.map((pokemon, index) => {
                        return (
                            <PokemonCards
                                key={index}
                                pokemon={pokemon}
                                url = {pokemon.url}
                                />
                        )
                    }
                    )}
            </div>
        )
    }
}
