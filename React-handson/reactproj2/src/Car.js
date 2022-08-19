import React, { Component } from 'react';
class Car extends React.Component {

    constructor(props){
        super(props);
        this.state = {brand : "Ford"};
        this.state = {carname : "Ford"};
        this.state = {carbrandname : "Ford"};
        this.state = {make : "Ford"};
        this.state = {model : "Ford"};
        this.state = {brand : "TATA"};
    }

    render()
    {
        return(
            <div>
                <h1>My Car {this.state.brand}</h1>
            </div>
        )
    }
}
export default  Car