import React, { useState, useEffect } from "react";
import { Link, useParams } from "react-router-dom";
import axios from "axios";

const User = () => {
  const [user, setUser] = useState({
    name: "",
    location: "",
    email: "",
    description: "",
    webiste: ""
  });
  const { id } = useParams();
  useEffect(() => {
    loadUser();
  }, []);
  const loadUser = async () => {
    const res = await axios.get(`http://localhost:3003/users/${id}`);
    setUser(res.data);
  };
  return (
    <div className="container py-4">
      <Link className="btn btn-primary" to="/">
        back to Home
      </Link>
      <h1 className="display-4 mb-20">User Id: {id}</h1>
      <hr />
      

      <table class="table table-hover table-dark">
        <thead>
          <tr>
            <th scope="col" className="bg-primary">#</th>
            <th scope="col" className="bg-primary">Event field</th>
            <th scope="col" className="bg-primary">Event Data</th>

          </tr>
        </thead>
        <tbody>
          <tr>
            <th scope="row">1</th>
            <td>Event name: </td>
            <td>{user.name}</td>

          </tr>
          <tr>
            <th scope="row">2</th>
            <td>Location of Event : </td>
            <td> {user.location}</td>

          </tr>
          <tr>
            <th scope="row">3</th>
            <td>Contact  email : </td>
            <td>{user.email}</td>

          </tr>

          <tr>
            <th scope="row">4</th>
            <td>Event Description  : </td>
            <td>{user.description}</td>
          </tr>

          <tr>
            <th scope="row">5</th>
            <td>Event Image: </td>
            <td><img src={user.website}></img></td>
          </tr>

        </tbody>
      </table>

    </div>

  );
};

export default User;