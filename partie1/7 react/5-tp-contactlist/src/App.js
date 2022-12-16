import React, { useState, useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
// import { TRASH3 } from 'react-bootstrap-icons';
import './App.css';
import {
  BrowserRouter,
  Routes,
  Route,
  Outlet
} from 'react-router-dom';
// import { useState} from 'react';
// import { useState , useEffect } from 'react';
import Header from './components/enCommun/Header/Header';
import Footer from './components/enCommun/Footer/Footer';
import HomeView from './Views/HomeView/HomeView';
import ContactListView from './Views/ContactListView/ContactListView';
import AddContactView from './Views/AddContactView/AddContactView';
import { ContactList } from './datas/ContactList';
// import { ContactList } from '../../datas/ContactList';

function App() {


  const savedList = localStorage.getItem('List');

  const [contactList, setContactList] = useState(savedList ? JSON.parse(savedList) : ContactList);

  useEffect(() => {
    localStorage.setItem('List', JSON.stringify(contactList))
  }, [contactList]);

  return (
    <div className="App">
      <BrowserRouter>
        {/* <Header contact={contact} addContact={addContact}/> */}
        <Header />
        <div>
          <Routes>
            <Route path="/" element={<HomeView />} />
            <Route path="/list" element={<ContactListView contactList={contactList} setContactList={setContactList} />} />
            <Route path="/add" element={<AddContactView contactList={contactList} setContactList={setContactList} />} />
          </Routes>
          <div className="container">
            <Outlet />
          </div>
        </div>
        {/* <NavBarComponent cart={cart} updateCart={updateCart} /> */}
      </BrowserRouter>
      <Footer />
    </div>
  );
}

export default App;