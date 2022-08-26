import React from 'react';
import ReactDOM from 'react-dom/client';
import {Provider} from 'react-redux';
import {createStore} from 'redux';
import './index.css';
import App from './App';
import Car from './Car';
import Brake from './Brake';
import Engine from './Engine';
import School from './School';
import Comp from './Comp';
import reportWebVitals from './reportWebVitals';




// const root = ReactDOM.createRoot(document.getElementById('root'));
// root.render(
//   <React.StrictMode>
//     <Engine />
//     <Car />
//     <App />
//     <Brake />
//     <School />
//     <Comp />
//   </React.StrictMode>
// );


const store = createStore()
const root = ReactDOM.createRoot(document.getElementById('root'))
root.render(
    <Provider store={store}>
        <App />

    </Provider>
)

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
