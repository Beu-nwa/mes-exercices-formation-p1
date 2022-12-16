import './SearchComp.css'
import React, { Component } from 'react'

class SearchComp extends Component {
    constructor(props) {
        super(props);
        this.state = {
            valueInput: ""
        }
    }

    render() {
        return (
            <div className='SearchComp'>
                <input onChange={(e) => this.setState({ valueInput: e.target.value })} type="text" placeholder='Numéro de siret' />
                <button onClick={() => { this.props.Search(this.state.valueInput) }} >Rechercher</button>
            </div>
        );
    }
}

export default SearchComp;