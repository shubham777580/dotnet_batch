import React from 'react';

//using Navlink of react router to not reload whenever linked press and to display the page we are on in the header (single page application)
import { Link,NavLink } from 'react-router-dom';

// functional bootstrap component from bootstrap documentation
const Navbar = () => {
    return (

        <nav className="navbar navbar-expand-lg navbar-dark bg-info">
            <div className='container-fluid'>
                <NavLink className="navbar-brand" to="/">FindMyEvents - Shubham Mukherjee</NavLink>
                
                <div class>
                    <ul className="navbar-nav mr-auto">
                        <li className="nav-item active">
                            <NavLink className="nav-link" to="/">Home </NavLink>
                        </li>
                        <li className="nav-item">
                            <NavLink className="nav-link" to="/about">About</NavLink>
                        </li>


                    </ul>

                </div>

                <Link className="btn btn-primary" to='/users/add' >Add An Event</Link>


            </div>
        </nav>

    );

};

export default Navbar;