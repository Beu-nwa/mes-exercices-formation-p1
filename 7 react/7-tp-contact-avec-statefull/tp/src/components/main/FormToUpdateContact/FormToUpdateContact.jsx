import React, { Component } from 'react';
import './FormToUpdateContact.css'

export default class FormToUpdateContact extends Component {
    render() {
        return (
            <div className='FormToUpdateContact'>
                <div className="container">
                    <form className='row'>
                        <div className="col  ">
                            <input type="text" />
                        </div>
                        <div className="col ">
                            <input type="text" />
                        </div>
                        <div className="col col-4 ">
                            <input type="email" />
                        </div>
                        <div className="col ">
                            <input type="text" />
                        </div>
                        <div className='col btnDiv'>
                            <button className='btn btn-dark'>Confirmer</button>
                        </div>
                    </form>
                </div>
            </div>
        )
    }
}
