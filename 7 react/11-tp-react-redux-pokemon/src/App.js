import Header from './globalComponents/Header/Header';
import Footer from './globalComponents/Footer/Footer';
import HomeView from './Views/HomeView/HomeView';
import pokemonSky from './assets/img/pokemonSky.png'
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

function App() {
  return (
    <div className="App" style={{ backgroundImage: `url(${pokemonSky})` }}>
      <header>
        <Header />
      </header>
      <main>
        <main>
          <div className='container'>
            <HomeView />
          </div>
        </main>
      </main>
      <footer>
        <Footer />
      </footer>
    </div >
  );
}

export default App;
