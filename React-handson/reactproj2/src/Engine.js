import React, { Component } from 'react';
class Engine extends React.Component {
    constructor(props){
        super(props);
        this.state = {brand : "TATA", model : "xyz"};
    }

render(){
    return(
        <div>
            <h1>My Car Engine is of {this.state.brand}</h1>
        </div>

    );
}
    
}

export default  Engine