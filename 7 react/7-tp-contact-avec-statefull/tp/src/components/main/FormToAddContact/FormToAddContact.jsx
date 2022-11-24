import React, { Component } from 'react';
import './FormToAddContact.css';


class FormToAddContact extends Component {
    constructor(props) {
        super(props)
        this.state = {
            // state local
            nom: "",
            prenom: "",
            email: "",
            numero: ""
        }
    }


    submit = (e) => {
        e.preventDefault();
        if (this.state.nom !== "" && this.state.prenom !== "" && this.state.email !== "" && this.state.numero !== "") {

            let listTmp = [...this.props.list];
            listTmp.push({ nom: this.state.nom, prenom: this.state.prenom, mail: this.state.email, numero: this.state.numero })
            this.props.setContactList(listTmp);
            console.log("Ajout");
            this.setState({
                nom: "",
                prenom: "",
                email: "",
                numero: ""
            });
        } else {
            alert("Veuillez compléter entièrement le formulaire...");
        }
    }

    // change le state local
    ChangeNom = (e) => {
        e.preventDefault();
        this.setState({
            nom: e.target.value
        })
    }
    ChangePrenom = (e) => {
        e.preventDefault();
        this.setState({
            prenom: e.target.value
        })
    }
    ChangeEmail = (e) => {
        e.preventDefault();
        this.setState({
            email: e.target.value
        })
    }
    ChangeNumero = (e) => {
        e.preventDefault();
        this.setState({
            numero: e.target.value
        })
    }

    render() {
        return (
            <div id="FormToAddContact">
                <div className='container'>
                    <form onSubmit={this.submit}>
                        <div className="form-control">

                            <div className="mb-3 row">
                                <div className='col'>
                                    <label htmlFor="nom">Nom : </label>
                                </div>
                                <div className='col-10'>
                                    <input className='form-control' type="text" name="nom" id="nom" onChange={this.ChangeNom} placeholder="Nom..." value={this.state.nom} />
                                </div>
                            </div>
                            <div className="mb-3 row">
                                <div className='col'>
                                    <label htmlFor="prenom">prenom : </label>
                                </div>
                                <div className='col col-10'>
                                    <input className='form-control' type="text" name="prenom" id="prenom" onChange={this.ChangePrenom} placeholder="Prénom..." value={this.state.prenom} />
                                </div>
                            </div>
                            <div className="mb-3 row">
                                <div className='col'>
                                    <label htmlFor="email">Email : </label>
                                </div>
                                <div className='col col-10'>
                                    <input className='form-control' type="email" name="email" id="email" onChange={this.ChangeEmail} placeholder="Email@truc.fr..." value={this.state.email} />
                                </div>
                            </div>
                            <div className="mb-3 row">
                                <div className='col'>
                                    <label htmlFor="numero">Numéro : </label>
                                </div>
                                <div className='col col-10'>
                                    <input className='form-control' type="text" name="numero" id="numero" onChange={this.ChangeNumero} placeholder="Numéro..." value={this.state.numero} />
                                </div>
                            </div>
                            <hr />
                            <div className="btndiv">
                                <button type="submit" className='btn btn-dark form-control'>Valider</button>
                            </div>

                        </div>
                    </form>
                </div>
            </div>
        );
    }
}

export default FormToAddContact;
