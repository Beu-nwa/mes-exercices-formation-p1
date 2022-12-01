import axios from 'axios';

const defaultUrl = "https://pokeapi.co/api/v2/pokemon?limit=300";

export const getPokemonApi = (async (url = defaultUrl) => {
    return await axios.get(url)
});