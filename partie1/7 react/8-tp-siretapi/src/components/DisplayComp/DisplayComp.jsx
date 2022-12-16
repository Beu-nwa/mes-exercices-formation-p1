import './DisplayComp.css'
import React, { Component } from 'react'

class DisplayComp extends Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <div className='DisplayComp'>

                <table>
                    <tbody>
                        <tr>
                            <td>SIRET : </td>
                            <td>{this.props.siret}</td>
                        </tr>
                        <tr>
                            <td>Nom entreprise : </td>
                            <td>{this.props.entreprise}</td>
                        </tr>
                        <tr>
                            <td>Siège social : </td>
                            <td>{this.props.siegeSocial}</td>
                        </tr>
                        <tr>
                            <td>Date de création : </td>
                            <td>{this.props.createDate}</td>
                        </tr>
                        <tr>
                            <td>Date de dernier traitement : </td>
                            <td>{this.props.lastTraitement}</td>
                        </tr>
                        <tr>
                            <td>Adresse : </td>
                            <td>{this.props.address}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}

export default DisplayComp;