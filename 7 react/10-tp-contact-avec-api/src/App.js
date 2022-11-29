import HomeView from './Views/HomeView/HomeView';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

function App() {
  return (
    <div className="App">
      <header>
        <h1>TP contacts avec API</h1>
      </header>
      <main>
        <HomeView />
      </main>
    </div>
  );
}

export default App;
