import HouseList from '../house/HouseList';
import './App.css';
import Header from './Header';

function App() {
  return (
   <div className="container">
    <Header subtitle="Provising houses all over the world"/>
    <HouseList></HouseList>
   </div>
  );
}

export default App;
