import React from 'react';

const About = () => {
    return (
        <div className='container'>
            <div classname='py-4'>

                <h1 className="m-4 p-3 text-center" >About Page</h1>

                <p className='about_para_class'>
                    <h4 className="m-4 text-center text-primary">Author : Shubham Mukherjee</h4>
                    <h4 className="m-4 text-center text-primary">Project Name : Find My Events</h4>
                </p>

                <ul class="list-group list-group-light">
                    <li class="list-group-item px-3 border-0 rounded-3 mb-2">More About this project : </li>

                    <li class="list-group-item px-3 border-0 rounded-3 list-group-item-primary mb-2">This Demo Project is made for simplilearn training.</li>
                    <li class="list-group-item px-3 border-0 rounded-3 list-group-item-secondary mb-2">This project is made using Reactjs and Bootstrap.</li>
                    <li class="list-group-item px-3 border-0 rounded-3 list-group-item-success mb-2">This project is based on Event apps.</li>
                    <li class="list-group-item px-3 border-0 rounded-3 list-group-item-danger mb-2">The main aim of this project is to create, fetch, update, delete data from json file.</li>
                    <li class="list-group-item px-3 border-0 rounded-3 list-group-item-warning mb-2">A json file needs to be hosted for this project and to provided as input for this project.</li>
                    <li class="list-group-item px-3 border-0 rounded-3 list-group-item-info mb-2">Writeup : <a href="https://docs.google.com/document/d/1JrjL6FLmZyVaAa2WLw5t4dHch1Wv56sUFyPXs-tTjTg/edit?usp=sharing" target="_blank">https://docs.google.com/document/d/1JrjL6FLmZyVaAa2WLw5t4dHch1Wv56sUFyPXs-tTjTg/edit?usp=sharing</a> </li>
                    <li class="list-group-item px-3 border-0 rounded-3 list-group-item-dark mb-2">Github Link : <a href="https://github.com/shubham777580/dotnet_batch/tree/dev1/Assesments/assesment_2/FindMyEvents/findmyevents_reactproj" target="_blank">https://github.com/shubham777580/dotnet_batch/tree/dev1/Assesments/assesment_2/FindMyEvents/findmyevents_reactproj</a>   </li>
                    
                </ul>
            </div>

        </div>
    );
};

export default About;