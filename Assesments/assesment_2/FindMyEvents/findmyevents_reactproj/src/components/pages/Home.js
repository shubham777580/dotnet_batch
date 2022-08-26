import React, { useState, useEffect } from 'react';

//for pull requests, we are using axios
import axios from 'axios';

//for bootstrap jsx
import { Link,NavLink } from "react-router-dom";

const Home = () => {
    const [users, setUser] = useState([]);

    useEffect(
        () => {
            loadUsers();
        }, []);

    const loadUsers = async () => {
        const result = await axios.get("http://localhost:3003/users");
        //console.log(result);
        setUser(result.data);
    };

    const deleteUser = async id => {
        await axios.delete(`http://localhost:3003/users/${id}`);
        loadUsers();
      };


    return (
        <div className='container'>
            <div className='py-4'>
                <h1>Home Page</h1>

                {/* adding table for display in home page */}

                <table className="table table-info table-hover">
                    <thead>
                        <tr>
                            <th scope="col">#ID</th>
                            <th scope="col">Event Name</th>
                            <th scope="col">User Name</th>
                            <th scope="col">Email</th>
                            <th scope="col">Action</th>
                        </tr>
                    </thead>
                    <tbody className="table-group-divider">

                    {/* for dynamic data entry, using loop */}
                    {
                        users.map((user, index) => (
                            <tr>
                            <th scope="row">{index + 1}</th>
                            <td>{user.name}</td>
                            <td>{user.username}</td>
                            <td>{user.email}</td>
                            <td>
                            <Link className="btn btn-info m-2" to = {`/users/${user.id}`}>View Event</Link>
                            <Link className="btn btn-warning m-2" to = {`/users/edit/${user.id}`} > Edit Event </Link>
                            <button className="btn btn-outline-danger m-2" onClick={() => deleteUser(user.id)}>Delete Event</button>
                            </td>
                            </tr>
                        ))
                    }


                      
                    </tbody>
                </table>


            </div>
        </div>
    );
};

export default Home;