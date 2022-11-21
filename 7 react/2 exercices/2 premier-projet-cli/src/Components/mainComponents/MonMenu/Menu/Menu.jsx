import React from 'react';
import LeftCol from '../LeftCol/LeftCol';
import CenterCol from '../CenterCol/CenterCol';
import RightCol from '../RightCol/RightCol';
import './Menu.css'

const Menu = () => {
    return (
        <div class="container">
            <LeftCol />
            <CenterCol />
            <RightCol />
        </div>
    );
}

export default Menu;
