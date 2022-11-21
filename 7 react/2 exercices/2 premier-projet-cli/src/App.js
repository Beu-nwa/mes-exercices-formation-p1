import {BrowserRouter, Routes, Route} from 'react-router-dom'
import Home from './Views/Home/Home';
import Contacts from './Views/Contacts/Contacts';
import Projets from './Views/Projets/Projets';
import './Components/communStyle/communStyle.css'
import './App.css';


function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Home />}/>
          <Route path="/Projets" element={<Projets />}/>
          <Route path="/Contacts" element={<Contacts />}/>
        </Routes>
      </BrowserRouter>
     
   
    </div>
  );
}

export default App;
