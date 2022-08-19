import logo from './logo.svg';
import './App.css';
import React from 'react';
import ReactDOM from 'react-dom/client';

function App() {
  return <div>
    <AppChild name="Matt" />
    </div>
}

function AppChild(props){
  return <span>
      My name is {props.name}
    </span>
}

//ReactDOM.render(<App />, document.getElementById('app'));
export default App;
