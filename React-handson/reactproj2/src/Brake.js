import React, { Component } from 'react';
class Brake extends React.Component {

    constructor(props){
        super(props);
        this.state = {brand : "Ford"};
        this.state = {carname : "Ford"};
        this.state = {carbrandname : "Ford"};
        this.state = {make : "Ford"};
        this.state = {model : "Ford"};
        this.state = {brand : "TATA"};
        
    }

     Brake_fn(){
        return <p>
            Calling function made in brake.js : yes
          </p>
      }

    render()
    {
        return(
            <div>
                <h1>Brake is applied to : My Car {this.state.brand}</h1>
            </div>
            
        )
    }
}
export default  Brake