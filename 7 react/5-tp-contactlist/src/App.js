import 'bootstrap/dist/css/bootstrap.min.css';
// import { TRASH3 } from 'react-bootstrap-icons';
import './App.css';
// import { useState} from 'react';
// import { useState , useEffect } from 'react';
import Header from './components/enCommun/Header/Header';
import Footer from './components/enCommun/Footer/Footer';
// import { ContactList } from '../../datas/ContactList';

function App() {

  // const savedCart = localStorage.getItem('cart');
  // const [contact, addContact] = useState([]); 

  // const [contact, addContact] = useState(savedCart ? JSON.parse(savedCart) : []);

  // useEffect(()=>{
  //   localStorage.setItem('cart', JSON.stringify(cart))
  // },[cart])

  return (
    <div className="App">
      {/* <Header contact={contact} addContact={addContact}/> */}
      <Header />
      {/* <NavBarComponent cart={cart} updateCart={updateCart} /> */}
      <Footer />
    </div>
  );
}

export default App;