import Header from './globalComponents/Header/Header';
import Footer from './globalComponents/Footer/Footer';
import HomeView from './Views/HomeView/HomeView';
import {
  BrowserRouter,
  Routes,
  Route,
  Outlet
} from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <header>
          <Header />
        </header>
        <main>
          <main>
            <Routes>
              <Route path="/" element={<HomeView />} />
            </Routes>
            <div className="container">
              <Outlet />
            </div>
          </main>
        </main>
      </BrowserRouter>
      <footer>
        <Footer />
      </footer>
    </div >
  );
}

export default App;
