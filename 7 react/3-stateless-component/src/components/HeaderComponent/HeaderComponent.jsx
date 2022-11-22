import React from "react";
import 'HeaderComponent.css';

const HeaderComponent = () => {
    return (
        <div className="banner">
            <img src="./img/" alt="" />
            <h2>M2iFormation</h2>
            <span className="description">Votre formation sur mesure</span>
        </div>
    )
}

export default HeaderComponent;