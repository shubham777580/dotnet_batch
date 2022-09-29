import React, { useState, useEffect } from "react";
import axios from "axios";
import {  useHistory, useParams } from "react-router-dom";

const EditEvent = () => {
  let history =  useHistory();

  //using params for id and ploting the corresponding data in input field
  const { id } = useParams();
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

  useEffect(() => {
    loadUser();
  }, []);

  //for main changes
  const onSubmit = async e => {
    e.preventDefault();
    await axios.put(`http://localhost:3003/users/${id}`, user);
    history.push("/");
  };

  //to load all the data in the input field for editing
  const loadUser = async () => {
    const result = await axios.get(`http://localhost:3003/users/${id}`);
    setUser(result.data);
  };
  return (
    <div className="container">
      <div className="w-75 mx-auto shadow p-5">
        <h2 className="text-center mb-4">Edit An Event</h2>
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
          <button className="btn btn-warning btn-block">Update Event</button>
        </form>
      </div>
    </div>
  );
};

export default EditEvent;