import React, { useState } from 'react';
import axios from 'axios';
import { useHistory } from "react-router-dom";

const AddEvent = () => {

    let history = useHistory();

    //decleraing in start for maintaining varaiable
    const [user, setUser] = useState({
        name: "",
        location: "",
        email: "",
        description: "",
        website: ""
    });

    //destructing the objects returning to user
    const { name, location, email, description, website } = user;

    //to save form data to local variables using oninputchange fn:
    //using spread operator ...user to preserve realtime past data
    const onInputChange = e => {
        setUser({ ...user, [e.target.name]: e.target.value });
    };

    //for pushing the local changes to json :

    const onSubmit = async e => {
        e.preventDefault();
        await axios.post("http://localhost:3003/users", user);
        history.push("/");
    };

    return (

        <div className="container">
            <div className="w-75 mx-auto shadow p-5">
                <h2 className="text-center mb-4">Add An Event</h2>
                <form onSubmit={e => onSubmit(e)}>
                    <div className="form-group">
                        <input
                            type="text"
                            className="form-control form-control-lg"
                            placeholder="Enter Event Name"
                            name="name"
                            value={name}
                            onChange={e => onInputChange(e)}
                        />
                    </div>
                    <div className="form-group">
                        <input
                            type="text"
                            className="form-control form-control-lg"
                            placeholder="Enter Event Location"
                            name="location"
                            value={location}
                            onChange={e => onInputChange(e)}
                        />
                    </div>
                    <div className="form-group">
                        <input
                            type="email"
                            className="form-control form-control-lg"
                            placeholder="Enter Contact E-mail Address"
                            name="email"
                            value={email}
                            onChange={e => onInputChange(e)}
                        />
                    </div>
                    <div className="form-group">
                        <input
                            type="text"
                            className="form-control form-control-lg"
                            placeholder="Enter Decription of event"
                            name="description"
                            value={description}
                            onChange={e => onInputChange(e)}
                        />
                    </div>
                    <div className="form-group">
                        <input
                            type="text"
                            className="form-control form-control-lg"
                            placeholder="Enter Event image url"
                            name="website"
                            value={website}
                            onChange={e => onInputChange(e)}
                        />
                    </div>
                    <button className="btn btn-primary btn-block">Add Event</button>
                </form>
            </div>
        </div>


    );
};

export default AddEvent