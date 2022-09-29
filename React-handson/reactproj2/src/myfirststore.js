import React from "react";
import { ReactDOM } from "react-dom";
import { Provider } from "react-redux";
import App from "./App";
import { createStore } from 'reduxjs';

function counter (state = { value: 0 }, action) {
    switch (action.type) {
    case 'INCREMENT':
      return { value: state.value + 1 }
    case 'DECREMENT':
      return { value: state.value - 1 }
    default:
      return state
    }
  }

let store = createStore(counter, { value: 0 });

// Dispatches an action; this changes the state
store.dispatch({ type: 'INCREMENT' })
store.dispatch({ type: 'DECREMENT' })

// Gets the current state
store.getState()

// Listens for changes
store.subscribe(() => {})



// const root = ReactDOM.createRoot(document.getElementById('root'))
// root.render(
//     <Provider store={store}>
//         <App />

//     </Provider>
// )