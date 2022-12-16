// console.log("test");

import express from 'express';
import multer from 'multer';
import cors from 'cors';
import path from 'path';
import { M2iFunction, success } from './helpers.js';
import { fileURLToPath } from 'url';
import ip from 'ip';

const app = express();
const port = 667;
const ipAdress = ip.address();
// const { M2iFunction } = require("./helpers");
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);
console.log(`Directory-Name : ${__dirname}`);


// CONFIG EXPRESS
app
    .use(cors())
    .use((req, res, next) => {
        res.header(`Access-Control-Allow-Origin`, `*`)
        res.header(`Access-Control-Allow-Headers`, `Origin, X-requested-with, Content-Type, Accept`)
        next()
        app.options(`*`, (req, res) => {
            res.header(`Access-Control-Allow-Methods`, `GET, POST, PUT, DELETE, PATCH, OPTIONS`)
            res.send()
        })
    })
    .use(express.static(path.join(__dirname, 'public')))
    .use('/static', express.static(path.join(__dirname, 'public')));


// CONFIG MULTER
let storage = multer.diskStorage({
    // La limite en taille du fichier
    limits: {
        fileSize: 500000, //500ko
        //fileSize: 1000000, //1Mo
    },
    // La destination, ici ce sera à la racine dans le dossier img
    destination: (req, file, cb) => {
        cb(null, './public/img')
    },
    // Gestion des erreurs
    fileFilter(req, file, cb) {
        if (!file.originalname.match(/\.(jpg|jpeg|png)$/)) {
            return cb(new Error('Le fichier doit etre un JPG ou PNG'))
        }
        cb(undefined, true)
    },
    // Fonction qui renomme l'image
    filename: function (req, file, cb) {
        // Genère un nom aléatoire et récupère l'ancienne extension
        cb(
            null,
            Math.random().toString(36).substring(7) +
            '.' +
            file.originalname.split('.')[1],
        )
    },
})
// Création de l'objet multer
const upload = multer({
    storage: storage,
})


// END POINT
app.get(`/`, (req, res) => {
    console.log(`/ Api Fonctionnelle `);
    res.json({ message : `ça marche`})
})

app.post(`/upload`, upload.single(`img`), async(req, res) => {
    // console/log(req) => renvoi tout l'objet img 
    console.log(`UPLOAD ${req.originalname} => ${req.filename} - Folder : ${req.destination} - Size = ${req.file.size}ko`);
    try
    {
        let filename = req.file.filename;
        let message = `Upload ok`;
        res.json(success(message, filename))
    }
    catch(e)
    {
        res.send(400).send(e)
    }
});

app.listen(port, () => console.log(M2iFunction(port, ipAdress)));