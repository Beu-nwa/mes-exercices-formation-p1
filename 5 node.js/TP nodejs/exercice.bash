# Sur le model de l'API CoursList créer une API Orienté Objet avec
# 1- Une Classe Person
    # - Attibuts : id, title, firstname, lastname, dateOfBirth, created , updated 
# 2- Une class Contact hérite de Person
    # - Attibuts : Phone, Email

# 3- Rendre l'upload d'une image possible ainsi que son accès static pour une utilisation futur par un projet Front React




$ npm init
dans cript : ajout du "start" : "node index.js",
$ npm start pour tester avec un console/log("test")
ajout de "type" : "module",
$ npm i express
$ npm i ip
$ npm i cors
$ npm i multer
$ npm i morgan
$ npm i body-parser --save
$ npm i nodemon --save-dev

import express from `express`;
import multer from `multer`;
import cors from `cors`;
import ip from `ip`;

const app = express;
const port = 667;
const ipAdress = ip.address();


## !!!!! ATTENTION
# il faut npm i lorsque on importe un dossier node