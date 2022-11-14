# creation du point d'entrée de notre app
index.js

# initialisation du projet node.js (cré un package.json une fois les infos entrées)
$ npm init

# creation de :
instruction.bash
dossier api coursList

# ajout du scipt start
"start": "node index.js",

# commencer par tester le bon fonctionnement avec un console.log("test") par exemple, puis:
$ npm start

# NB: pour arréter : ctrl + C

#initialisation de express
$ npm install express

# creation des const express, app, port
const express = require(`express`);
const app = express();
const port = 7777;

#creation des end point get et listen
# app.get(`/`, (req, res) => res.send(`Hello from node js\n`));

# Ecoute d'un port
# app.listen(port, () => console.log(`L'application node.js est démarée\n\thttp://localhost:${port}`));

# test du serveur
$ npm start

# problème: à chaque modif, on doit fermer puis relancer le serv, solution en dessous:

# installation du package NODEMON
$ npm install nodemon --save-dev

# creation d'un script de démarrage en mode dev
"scripts": {
    "start": "node index.js",
    "dev": "nodemon index.js",
    "test": "echo \"Error: no test specified\" && exit 1" 
}

# Pour lancer en mode developement (remplace le npm start)
$ npm run dev

# import de la liste de cours
coursList.js

# création d'un new end point
app.get(`/api/cours/1`, (req, res) => res.send(`Welcome to my cours number ${id}\n`));
# pour visiter la toute depuis le navigateur
get -> http://localhost:7777/api/cours/1

# Modification d'un new end point
app.get(`/api/cours/:id`, (req, res) => {
    const id = parseInt(req.params.id);
    res.send(`Welcome to my cours number ${id}\n`)
});

# import de coursList.js
const coursList = require(`./data/coursList`);

# Exercice1: Afficher un objet de la coursList sur la page web
voir lignes 20 à 40

# intsaller l'extension gchrome json viewer
https://chrome.google.com/webstore/detail/json-viewer/gbmdgpbipfallnflgajpaliibnhdgobh

# Exercice 2: à l'adresse /api/cours retourner le nombre de cours
app.get(`/api/cours`, (req, res) => {
    res.send(`il y a ${coursList.length} cours dans ma liste`);
});

# Exercice 3: idem que le 2 mais avec en plus toutes les formations qui s'affichent
app.get(`/api/cours`, (req, res) => {
    res.json({message: `il y a ${coursList.length} cours dans ma liste :`, data: coursList, error: false});
});