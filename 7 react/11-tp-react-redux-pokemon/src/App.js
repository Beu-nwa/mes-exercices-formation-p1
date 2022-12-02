import Header from './globalComponents/Header/Header';
import Footer from './globalComponents/Footer/Footer';
import HomeView from './Views/HomeView/HomeView';
// import pokemonSky from './assets/img/pokemonSky.jpg';
// import background from './assets/img/background.jpg';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

function App() {
  return (
    // <div className="App" style={{ backgroundImage: `url(${background})`}}>
    <div className="App bg-info">
      <header className='bg-warning text-info'>
        <Header />
      </header>
      <main>
        <main>
          <div className='container'>
            <HomeView />
          </div>
        </main>
      </main>
      <footer className='bg-warning text-info'>
        <Footer />
      </footer>
    </div >
  );
}

export default App;
