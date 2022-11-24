import React, { Component } from 'react';
import {
  BrowserRouter,
  Routes,
  Route,
  Outlet
} from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import Header from './components/commun/Header/Header';
import Footer from './components/commun/Footer/Footer';
import HomeView from './Views/HomeView/HomeView';
import ContactView from './Views/ContactView/ContactView';
import AddContactView from './Views/AddContactView/AddContactView';
import { ContactList } from './datas/ContactList';


class App extends Component {
  constructor(props) {
    super(props)
    this.state = {
      list: ContactList
    }
  }

  setContactList = (liste) => {
    this.setState({
      list: liste
    })
  }
  render() {
    return (
      <div className="App">
        {/* <Header contact={contact} addContact={addContact}/> */}
        <BrowserRouter>
          <Header />
          <main>
            <Routes>
              <Route path="/" />
              <Route path="/list" element={<ContactView list={this.state.list} setContactList={this.setContactList} />} />
              <Route path="/add" element={<AddContactView list={this.state.list} setContactList={this.setContactList} />} />
            </Routes>
            <div className="container">
              <Outlet />
            </div>
          </main>
          {/* <NavBarComponent cart={cart} updateCart={updateCart} /> */}
        </BrowserRouter>
        <Footer />
      </div>
    );
  }
}

export default App;
