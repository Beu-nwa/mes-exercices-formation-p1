import React from 'react';
import './CenterCol.css';

const CenterCol = () => {
    return (

        <div class="centerCol">
            <div class="aboutMe">
                <h2>About Me</h2>
                <hr />
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Illum ad sed cum nam libero, animi
                    distinctio aliquid omnis iure quo nihil, sint, recusandae aut fuga odit ullam aperiam. Unde,
                    omnis.
                    Lorem ipsum, dolor sit amet consectetur adipisicing elit. Vel ullam quos adipisci maxime
                    laboriosam repudiandae neque autem, quisquam tempore omnis pariatur molestiae dignissimos
                    nostrum ad eos, vero dolore itaque veniam?</p>
                <hr />
                <div id="myCvDiv">
                    <span>Télécharger mon CV</span>
                    <button>
                        <span class="buttonTop"> <i class="bi bi-download"></i>
                        </span>
                    </button>
                </div>
            </div>
            <div class="fastContact">
                <h2>Contacts</h2>
                <hr />
                <p><b>Age : </b>22 </p>
                <p><b>Adresse : </b>59400, Cambrai, France</p>
                <p><b>E-mail : </b>benoit.combe59400@gmail.com</p>
                <p><b>Tel : </b>06 05 45 30 06</p>
                <p><b>Dispos : </b>à partir du 06/03/23</p>
            </div>
        </div>

    );
}

export default CenterCol;
