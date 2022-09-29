import logo from './logo.svg';
import './App.css';
import React from 'react';
import ReactDOM from 'react-dom/client';

function App() {
  return <div>
    <AppChild name="Matt" />
    <AppChild1 name = "yes"/>
    </div>
}

function AppChild(props){
  return <span>
      My name is {props.name}
    </span>
}


function AppChild1(props){
  return <p>
      Returning function Component : {props.name}
    </p>
}



//ReactDOM.render(<App />, document.getElementById('app'));
export default App;
