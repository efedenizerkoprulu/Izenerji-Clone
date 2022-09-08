import  MainMenu from './Pages/MainMenu/MainMenu'
import  SliderDetail from './Pages/SliderDetail/SliderDetail'
import './App.css';
import {BrowserRouter as Router,Route,Routes  } from 'react-router-dom'


function App() {
  return (
    <Router>
    <div className="App">
   
    <Routes>
      <Route path="/SliderDetail/:id" element={<SliderDetail/>}></Route>
      <Route exect path= "/" element={<MainMenu/>}></Route>
   </Routes> 
   
      </div>
      </Router>
     
 
  );
}

export default App;
