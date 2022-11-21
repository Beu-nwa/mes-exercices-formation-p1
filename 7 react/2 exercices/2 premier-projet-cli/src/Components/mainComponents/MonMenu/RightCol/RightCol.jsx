import React from 'react';
import './RightCol.css';

const RightCol = () => {
    return (

        <div class="rightCol">
            <div class="topRow">
                <h2>Compétences Informatiques</h2>
            </div>
            <div class="midRow">
                <div class="midRowTitle">
                    <h3>Front</h3>
                </div>
                <div class="midRowFirstTitle">
                    <h4>framework</h4>
                </div>
                <div class="midRowSecondTitle">
                    <h4>Keywords</h4>
                </div>
                <div class="firstRow">
                    <div class="firstItem">
                        {/* <img src="./assets/img/logos/AngularLogo.jpg" alt="logo Angular" /> */}
                        <h5>Angular</h5>
                        <div id="masteries">
                            <span class="yellowStar">★</span>
                            <span class="yellowStar">★</span>
                            <span class="yellowStar">★</span>
                            <span class="whiteStar">★</span>
                            <span class="whiteStar">★</span>
                        </div>
                    </div>
                    <div class="secondItem">
                        {/* <img src="./assets/img/logos/ReactLogo.png" alt="logo React" /> */}
                        <h5>React</h5>
                        <div id="masteries">
                            <span class="whiteStar">★</span>
                            <span class="whiteStar">★</span>
                            <span class="whiteStar">★</span>
                            <span class="whiteStar">★</span>
                            <span class="whiteStar">★</span>
                        </div>
                    </div>
                </div>
                <div class="secondRow">à renseigner</div>
            </div>
            <div class="botRow">
                <div class="botRowTitle">
                    <h3>Back</h3>
                </div>
                <div class="midRowFirstTitle">
                    <h4>Unknows</h4>
                </div>
                <div class="midRowSecondTitle">
                    <h4>Unknows</h4>
                </div>
                <div class="firstRow">à renseigner</div>
                <div class="secondRow">à renseigner</div>
            </div>
        </div>

    );
}

export default RightCol;
