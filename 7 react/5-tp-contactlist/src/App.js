import React, { useState } from 'react';
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

  // const savedCart = localStorage.getItem('cart');
  // const [contact, addContact] = useState([]); 

  // const [contact, addContact] = useState(savedCart ? JSON.parse(savedCart) : []);

  // useEffect(()=>{
  //   localStorage.setItem('cart', JSON.stringify(cart))
  // },[cart])

  const [contactList, setContactList] = useState(ContactList);
  return (
    <div className="App">
      <BrowserRouter>
        {/* <Header contact={contact} addContact={addContact}/> */}
        <Header />
        <div>
          <Routes>
            <Route path="/" element={<HomeView />} />
            {/* <Route path="/list" element={<ContactListView />} /> */}
            <Route path="/list" element={<ContactListView contactList={contactList} setContactList={setContactList} />} />
            {/* <Route path="/add" element={<AddContactView />} /> */}
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