import React from "react";
import "./App.css";
import "../node_modules/bootstrap/dist/css/bootstrap.css";
import Home from "./components/pages/Home";
import About from "./components/pages/About";
import Navbar from "./components/layout/Navbar";
import {
  BrowserRouter as Router,
  Route,
  Switch,
  withRouter
} from "react-router-dom";
import AddEvent from "./components/users/AddEvent";
import EditEvent from "./components/users/EditEvent";
import ViewEvent from "./components/users/ViewEvent";
//switch matches url

function App(props) {
  return (
    <Router>
    <div className="App">

      <Navbar/>

      <Switch>
      <Route exact path="/" component={Home} />
      <Route exact path="/about" component={About} />
      <Route exact path="/users/add" component={AddEvent} />

        {/* pasing id for dynamic routing */}
        <Route exact path="/users/edit/:id" component={EditEvent} />
        <Route exact path="/users/:id" component={ViewEvent} />
 
      </Switch>
      

    </div>
    </Router>
  );
}

export default App;
