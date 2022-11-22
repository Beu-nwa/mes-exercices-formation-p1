import React from "react";
import { BrowserRouter, Routes, Route, Outlet, Link } from 'react-router-dom';
import HomeViews from "../../views/HomeViews/HomeViews";
import AboutViews from "../../views/HomeViews/HomeViews";

const NavBarComponent = () => {
    return (
        <div>
            <BrowserRouter>
            <div id="NavBar">
                <button className="bouton">
                    <Link to="/">Home</Link>
                </button>
                <button className="bouton">
                    <Link to="/about">About</Link>
                </button>
            </div>
                <Routes>
                    <Route path="/" element={<HomeViews />} />
                    <Route path="/about" element={<AboutViews />} />
                </Routes>
            </BrowserRouter>
            <div className="container">
                <Outlet />
            </div>
        </div>
    )
}

export default NavBarComponent;