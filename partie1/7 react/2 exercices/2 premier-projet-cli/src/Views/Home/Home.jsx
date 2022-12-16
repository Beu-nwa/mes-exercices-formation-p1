import React from 'react';
import Header from '../../Components/communComponents/Header/header';
import Menu from '../../Components/mainComponents/MonMenu/Menu/Menu';
import Footer from '../../Components/communComponents/Footer/Footer';

const Home = () => {
    return (
        <div className="home">
            <Header />
            <Menu />
            <Footer />
        </div>
    );
}

export default Home;
