$ npm init
dans cript : ajout du "start" : "node index.js",
$ npm start pour tester avec un console/log("test")
ajout de "type" : "module",
$ npm i express
$ npm i ip
$ npm i cors
$ npm i multer

import express from `express`;
import multer from `multer`;
import cors from `cors`;
import ip from `ip`;

const app = express;
const port = 667;
const ipAdress = ip.address();

app
    .use()
    .use((req, res, next) => {
        res.header(`Access-Control-Allow-Origin`, `*`)
        res.header(`Access-Control-Allow-Headers`, `Origin, X-requested-with, Content-Type, Accept`)
        next()
        app.option(`*`, (req, res) => {
            res.header(`Access-Control-Allow-Methods`, `GET, POST, PUT, DELETE, PATCH, OPTIONS`)
            res.send()
        })
    })  


# config multer
let storage = multer.diskStorage({
    # La limite en taille du fichier
    limits: {
        fileSize: 500000, #500ko
        #fileSize: 1000000, #1Mo
    },
    # La destination, ici ce sera à la racine dans le dossier img
    destination: (req, file, cb) => {
        cb(null, './public/img')
    },
    # Gestion des erreurs
    fileFilter(req, file, cb) {
        if (!file.originalname.match(/\.(jpg|jpeg|png)$/)) {
            return cb(new Error('Le fichier doit etre un JPG ou PNG'))
        }
        cb(undefined, true)
    },
    # Fonction qui renomme l'image
    filename: function (req, file, cb) {
        # Genère un nom aléatoire et récupère l'ancienne extension
        cb(
            null,
            Math.random().toString(36).substring(7) +
            '.' +
            file.originalname.split('.')[1],
        )
    },
})
# Création de l'objet multer
const upload = multer({
    storage: storage,
})