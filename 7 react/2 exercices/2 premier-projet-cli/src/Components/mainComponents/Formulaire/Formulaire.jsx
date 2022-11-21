import React from 'react';
import './Formulaire.css';

const Formulaire = () => {
    return (
        <div class="monFormulaireContact">
            <form action="">
                <fieldset>
                    <legend>Formulaire de contact</legend>
                    <div class="ligne">
                        <legend class="colonneg">Genre : </legend>
                        <div class="colonned">

                            <label class="radioLabel">Mr</label><input required class="radioInput" type="radio"
                                name="gender" value="Mr" />
                            <label class="radioLabel">Ms</label><input required class="radioInput" type="radio"
                                name="gender" value="Ms" />
                            <label class="radioLabel">Autre</label><input required class="radioInput" type="radio"
                                name="gender" value="Other" />
                        </div>
                    </div>
                    <div class="ligne">
                        <legend class="colonneg" for="userName">Nom :</legend>
                        <input class="inputText" type="text" placeholder="Nom" name="userName" required />
                    </div>
                    <div class="ligne">
                        <label class="colonneg" for="userFirstName">Prénom :</label>
                        <input class="inputText" type="text" placeholder="Prénom" name="userFirstName" required />
                    </div>
                    <div class="ligne">
                        <label class="colonneg" for="userDateOfBirth">Date de naissance :</label>
                        <input class="inputText" type="date" placeholder="Date de naissance" name="userDateOfBirth" />
                    </div>
                    <div class="ligne">
                        <label class="colonneg" for="userMail">Adresse mail :</label>
                        <input class="inputText" type="email" placeholder="Adresse mail" name="userMail" required />
                    </div>
                    <div class="ligne">
                        <legend class="colonneg">Vous êtes ?</legend>
                        <div class="colonned">
                            <label class="radioLabel"></label>Recruteur<input required class="radioInput" type="radio"
                                name="userType" value="Recruteur" />
                            <label class="radioLabel"></label>Client<input required class="radioInput" type="radio"
                                name="userType" value="Client" />
                            <label class="radioLabel"></label>Autre<input required class="radioInput" type="radio"
                                name="userType" value="Autre" />
                        </div>
                    </div>
                    <div class="ligne">
                        <textarea name="description" rows="10" class="myTextArea" placeholder="Message contextuel"
                            required></textarea>
                    </div>
                    <hr />
                    <div class="btndiv">
                        <button class="btn" type="submit">valider</button>
                        <button class="btn" type="reset">annuler</button>
                    </div>
                </fieldset>
            </form>
        </div>
    );
}

export default Formulaire;
