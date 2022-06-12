import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Navbars from './components/Navbars'
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Anasayfa from './components/Anasayfa'
function App() {
  return (
    <div className="App">
      <Navbars/>
     <Anasayfa/>
    </div>
  );
}

export default App;
