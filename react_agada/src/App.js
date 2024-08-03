import './App.css';
import 'bootstrap';
import { Link, Route, Routes } from 'react-router-dom';
import LoginComp from './components/loginComp';


function App() {
  return (
  <div className='App' style={{color:"red",backgroundColor: "lightblue"}}>
    <div className="container-fluid">
        <ul className="navbar navbar-expand-lg bg-body-tertiary">
        <li className="nav-item">
          <Link to="/" className="nav-link">Home</Link>
        </li>
        <li className="nav-item">
          <Link to="login" className="nav-link" href="login">Login</Link>
        </li>
      </ul>
      </div>
    <h1>Hello to react</h1>

    <Routes>
      <Route path='login' element={<LoginComp/>}  />
    </Routes>
  </div>
  
  );
}

export default App;
