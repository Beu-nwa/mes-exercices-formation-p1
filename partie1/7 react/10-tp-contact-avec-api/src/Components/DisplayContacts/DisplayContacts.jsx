import React, { Component } from 'react'
import FormContact from '../UpdateContact/UpdateContact'
import AddContact from '../AddContact/AddContact'
import './DisplayContacts.css'
import axios from 'axios'

export default class DisplayContacts extends Component {
    constructor(props) {
        super(props)
        this.state = {
            contactsList: [],
            // baseUrl: "http://localhost:7777",
        }
    }

    // appl
    GetContact = async () => {
        return await axios({
            method: "get",
            url: "http://localhost:7777/api/contacts",
            headers: {
                "Content-Type": "application/json"
            }
        })
    }
    PostContact = async (bodyFormData) => {
        return await axios({
            method: "post",
            url: "http://localhost:7777/api/contact",
            data: bodyFormData,
            headers: {
                "Content-Type": "application/json"
            }
        })
    }

    // traitement
    async componentDidMount() {
        const response = await this.GetContact()
        // console.log(response);
        if (response.status === 200) {
            this.setState({ contactsList: response.data.data })
            alert(response.data.message);
            console.log(response.data.data);
        }
    }

    // componentDidUpdate(prevState, prevProps) {
    //     if (prevState.contactsList !== this.state.contactsList) this.GetContact()
    // }

    addContact = async (contact) => {
        let bodyFormData = new FormData();
        bodyFormData.append('title', contact.title);
        bodyFormData.append('firstname', contact.firstname);
        bodyFormData.append('lastname', contact.lastname);
        bodyFormData.append('dateOfBirth', contact.dateOfBirth);
        bodyFormData.append('urlImg', ' ');
        bodyFormData.append('phone', contact.phone);
        bodyFormData.append('email', contact.email);
        let response = await this.PostContact(bodyFormData)
        alert(response.data.message)
        response = await this.GetContact()
        // console.log(response);
        if (response.status === 200 || response.status === 204) {
            this.setState({ contactsList: response.data.data })
            alert(response.data.message);
            console.log(response.data.data);
        }
    }

    updateContact = async (contact) => {
        let bodyFormData = new FormData();
        bodyFormData.append('id', contact.id);
        bodyFormData.append('title', contact.title);
        bodyFormData.append('firstname', contact.firstname);
        bodyFormData.append('lastname', contact.lastname);
        bodyFormData.append('dateOfBirth', contact.dateOfBirth);
        bodyFormData.append('urlImg', ' ');
        bodyFormData.append('phone', contact.phone);
        bodyFormData.append('email', contact.email);
        await axios({
            method: "put",
            url: "http://localhost:7777/api/contact/" + contact.id,
            data: bodyFormData,
            headers: {
                "Content-Type": "application/json"
            }
        }).then((res) => {
            if (res.status === 200) {
                alert(res.data.message)
            }
        }).catch(err => {
            alert(err);
            console.log(err)
        })
        this.GetContact()
    }

    deleteContact = async (id) => {
        await axios({
            method: "delete",
            url: "http://localhost:7777/api/contact/" + id,
            headers: {
                "Content-Type": "application/json"
            }
        }).then((res) => {
            if (res.status === 200) {
                alert(res.data.message)
            }
        }).catch(err => {
            alert(err);
            console.log(err)
        })
        this.GetContact()
    }

    render() {
        return (
            <div className='DisplayContacts'>
                <table id='contactTable' className='table table-dark table-striped'>
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Genre</th>
                            <th>Nom</th>
                            <th>Prénom</th>
                            <th>Date de Naissance</th>
                            <th>Mail</th>
                            <th>Numéro</th>
                            <th>Interactions</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.contactsList.map((person, index) => {
                            return (
                                <FormContact
                                    key={index}
                                    index={index}
                                    person={person}
                                    addContact={this.addContact}
                                    updateContact={this.updateContact}
                                    deleteContact={this.deleteContact}
                                />
                            )
                        }
                        )}
                        <AddContact />
                    </tbody>
                </table>
            </div>
        )
    }
}
