import express from 'express';
// import multer from 'multer';
import cors from 'cors';
// import path from 'path';
import { M2iFunction, success, getUniqueId } from './helper.js';
// import { fileURLToPath } from 'url';
import ip from 'ip';
import { readFileSync, writeFileSync } from 'fs';
import contact from "./classes/contact.js";

const app = express();
const port = 667;
const ipAdress = ip.address();
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = path.dirname(__filename);
// console.log(`Directory-Name : ${__dirname}`);

let contactList = JSON.parse(readFileSync(`./data/contactList.json`, `utf-8`));
console.table(contactList);


let listeDeContact = [];
fromJsonToJsClass()


function fromJsonToJsClass() {
    contactList.forEach(x => listeDeContact.push(new contact(x.id, x.title, x.firstname, x.lastname, x.dateOfBirth, x.Phone, x.Email)));
}

function save() {
    const objectToJson = JSON.stringify(listeDeContact);
    writeFileSync('./data/contactList.json', objectToJson);
    console.log("Données sauvegardées");
}




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
// .use(express.static(path.join(__dirname, 'public')))
// .use('/static', express.static(path.join(__dirname, 'public')));






// END POINT
app.get(`/`, (req, res) => {
    console.log(`/ Api Fonctionnelle `);
    res.json({ message: `Liste de contact :`, data: listeDeContact })
})

app.post(`/create`, (req, res) => {
    // ajouter le body à notre contactList.json en passant par la class contact
    const nextId = getUniqueId(listeDeContact);
    const tmpContact = { ...req.body, ...{ id: nextId} };
    console.log(tmpContact);
    // listeDeContact.push(tmpContact);
    // const tmpContact = new contact(nextId);

    // listeDeContact est en js
    // listeDeContact.push(new contact(JSON.parse(tmpContact)));
    // listeDeContact = JSON.parse(listeDeContact);
    // contactList est en JSON

    
    contactList.push(new contact(tmpContact));
    // saveList();
    let message = `Le contact n°: ${nextId} a été ajouté.`;
    res.json(success(message, contactList));
});

// app.post(`/upload`, upload.single(`img`), async(req, res) => {
//     // console/log(req) => renvoi tout l'objet img 
//     console.log(`UPLOAD ${req.originalname} => ${req.filename} - Folder : ${req.destination} - Size = ${req.file.size}ko`);
//     try
//     {
//         let filename = req.file.filename;
//         let message = `Upload ok`;
//         res.json(success(message, filename))
//     }
//     catch(e)
//     {
//         res.send(400).send(e)
//     }
// });

app.listen(port, () => console.log(M2iFunction(port, ipAdress)));








// // Créer un new cours
// app.post(`/api/cours`, (req, res) => {
//     // getUniqueId(coursList) envoi seulement la reference de chaque element et non les objets complets
//     const nextId = getUniqueId(coursList);
//     // const nextId = coursList.length + 1 ;
//     const coursCreated = { ...req.body, ...{ id: nextId, created: new Date() } };
//     coursList.push(coursCreated);
//     saveList();
//     let message = `Le cours n°: ${nextId} a été ajouté.`;
//     res.json(success(message, coursCreated));
// });

// // Exercice 4
// // Modification d'un new end point
// app.put(`/api/cours/:id`, (req, res) => {
//     const id = parseInt(req.params.id);
//     const coursUpdated = { ...req.body, updated: new Date() };
//     coursList = coursList.map(cours => {
//         return cours.id === id ? coursUpdated : cours
//     });
//     saveList();
//     let message = `Le cours n°: ${id} a été modifié`;
//     res.json(success(message, coursUpdated));
// });

// // Exercice 5 Delete
// app.delete(`/api/cours/:id`, (req, res) => {
//     const id = parseInt(req.params.id);
//     const coursDeleted = coursList.find(x => x.id === id);
//     coursList = coursList.filter(cours => cours.id != id);
//     let message = `Le cours n°: ${id} a été supprimé`;
//     saveList();
//     res.json(success(message, coursDeleted));
// })

// // Ecoute d'un port
// // app.listen(port, () => console.log(`L'application node.js est démarée\n\thttp://localhost:${port}`));
// app.listen(port, () => console.log(M2iFunction(port, ip.address())));


// // Exercice 6
// function saveList(){
//     const objectToJson = JSON.stringify(coursList);
//     writeFileSync('./data/savedCoursList.json', objectToJson);
//     console.log("Données sauvegardées");
// }

