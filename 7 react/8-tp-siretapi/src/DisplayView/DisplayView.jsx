import SearchComp from '../components/SearchComp/SearchComp';
import DisplayComp from '../components/DisplayComp/DisplayComp';
import './DisplayView.css'
import React, { Component } from 'react';
import axios from 'axios';

class DisplayView extends Component {
    constructor(props) {
        super(props);
        this.state = {
            siret: "",
            entreprise: "",
            siegeSocial: "",
            createDate: "",
            lastTraitement: "",
            address: "",
        }
    }

    Search = (siret) => {
        axios.get("https://api.insee.fr/entreprises/sirene/V3/siret/" + siret, { headers: { 'Authorization': 'Bearer ' } })
            .then(res => {
                if (res.data.header.statut === 200) {
                    this.setState({
                        siret: siret,
                        entreprise: res.data.etablissement.uniteLegale.denominationUniteLegale,
                        createDate: res.data.etablissement.dateCreationEtablissement,
                        siegeSocial: res.data.etablissement.etablissementSiege == false ? "non" : res.data.etablissement.etablissementSiege,
                        lastTraitement: res.data.etablissement.dateDernierTraitementEtablissement,
                        address: res.data.etablissement.adresseEtablissement.libelleVoieEtablissement + " " + res.data.etablissement.adresseEtablissement.complementAdresseEtablissement,
                        // address : res.data.etablissement.adresseEtablissement.libelleVoieEtablissement + " " + !res.data.etablissement.adresseEtablissement.complementAdresseEtablissement? "" : res.data.etablissement.adresseEtablissement.complementAdresseEtablissement,
                    })
                }
            }).catch(err => {
                console.log(err);
            })
    }


    render() {
        return (
            <div className='DisplayView'>
                <SearchComp Search={this.Search} />
                <DisplayComp siegeSocial={this.state.siegeSocial} address={this.state.address} lastTraitement={this.state.lastTraitement} createDate={this.state.createDate} siret={this.state.siret} entreprise={this.state.entreprise} />
            </div>
        );
    }
}

export default DisplayView;