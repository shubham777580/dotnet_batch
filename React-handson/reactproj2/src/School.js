import React, { Component } from 'react';
import { ReactDOM } from 'react-dom';
import Welcome from './App';

class School extends React.Component {
    constructor(props){
        super(props);
        this.state = {Class_name : "Dot_net_batch", Batch_year : "2022"};
    }

    


render(){
    return(
        <div>
            <h1>The class name is {this.state.Class_name } and the batch year is {this.state.Batch_year}</h1>
            
        </div>


    );
}
    
}




export default  School
