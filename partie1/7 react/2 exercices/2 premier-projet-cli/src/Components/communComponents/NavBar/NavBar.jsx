import React from 'react';
import { NavLink } from 'react-router-dom';
import './NavBar.css';

const NavBar = () => {
    return (
        // <div className='navBar'>
        //     <ul>
        //         <NavLink to="/" className={(nav)=>nav.isActive?'lien Active' : 'lien'}>
        //             <li>Home</li>
        //         </NavLink>
        //         <NavLink to="/Projets" className={(nav)=>nav.isActive?'lien Active' : 'lien'}>
        //             <li>Projets</li>
        //         </NavLink>
        //         <NavLink to="/Contacts" className={(nav)=>nav.isActive?'lien Active' : 'lien'}>
        //             <li>Contacts</li>
        //         </NavLink>
        //     </ul>

        // </div>



        <header className="navBar">
            <div class="navTitleDiv">
                <h1 class="navTitle">Combe Benoît</h1>
            </div>
            <div class="navDiv">
                <nav>
                    <ul class="navUl">
                        <NavLink to="/" className={(nav) => nav.isActive ? 'lien Active' : 'lien'}>
                            <li class="navLi"><a class="navLink" href="index.html">Accueil</a></li>
                        </NavLink>
                        <NavLink to="/Projets" className={(nav) => nav.isActive ? 'lien Active' : 'lien'}>
                            <li class="navLi"><a class="navLink" id="activeLink" href="Projets.html">Projets</a></li>
                        </NavLink>
                        <NavLink to="/Contacts" className={(nav) => nav.isActive ? 'lien Active' : 'lien'}>
                            <li class="navLi"><a class="navLink" href="Contacts.html">Contact</a></li>
                        </NavLink>
                    </ul>
                </nav>
            </div>
            <div class="navBtnDiv">
                <label class="navSwitch">
                    <input type="checkbox" />
                    <span class="slider"></span>
                </label>
            </div>
        </header>
    );
}

export default NavBar;
