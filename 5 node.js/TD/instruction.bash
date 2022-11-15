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





# Création de notre "librairie de methodes":
helpers.js

# Methode pour la mise en forme des res en ES6
exports.success = (message, data) => { return { message, data } };

# import de helper.js
const { success } = require("./helpers");

#modification du endPoint et Affichage avec la fonction importée "success" depuis helpers.js
app.get(`/api`, (req, res) => {
    let message = `il y a ${coursList.length} cours dans ma liste de cours.`;
    res.json(success(message, coursList));
});

# création d'un service logger injectable dans le middleWare
const logger = (req, res, next) => {
    console.log(`URL: ${req.url}`);
    next();
};

# injection du service logger
app.use(logger);

# installation d'un middleWare déjà éxistant
$ npm install morgan --save-dev

# import de morgan (middleware)
const morgan = require(`morgan`);

# injection du service
app.use(morgan(`dev`))

# import de la librairie serve-favicon
$ npm install serve-favicon --save

# import de serve-favicon (librairie)
const favicon = require(`serve-favicon`);

# Création d'un fichier favicon.ico

# injection du service 
.use(favicon(__dirname+"/data/assets/favicon.ico"))

# Création d'un endpoint pour poster un new cours
## POST => http://localhost:7777/api
app.post(`/api/cours`, (req, res) => {
    const nextid = coursList.length + 1 ;
    const coursCreated = {...req.body, ...{id : nextid , created : new Date() }};
    coursList.push(coursCreated);
});

# import de la librairie body-parser
$ npm install body-parser --save

# import de body-parser dans index.js
const bodyParser = require(`body-parser`)

# methode qui permet de retourner le plus grand id d'un tableau
exports.getUniqueId = (list) => {
    # recuperation de l'ensemble des clé id de mes objets + stockage dans un tableau
    const coursIds = list.map(cours => cours.id)
    # reduce permet de comparer 2 a 2 les ids, et math.max en retourne le plus grand des 2
    const maxId = coursIds.reduce((a,b) => Math.max(a,b));
    return (maxId + 1);
};

# Exercice 4
# création d'un endpoint permettant de faire l'update d'un cours
# prendre l'id en params pour cibler le bon cours
# traitement de l'objet cours en récupérant les données de l'utilisateur
# return de l'objet modifié
app.put(`/api/cours/:id`, (req, res) => {
    const id = parseInt(req.params.id);
    const coursUpdated = {...req.body, updated: new Date()};
    coursList = coursList.map(cours => {
        return cours.id === id? coursUpdated : cours
    });
    let message = `Le cours n°: ${id} a été modifié`;
    res.json(success(message, coursUpdated));
});

# Exercice 5
# Création d'un ENDPOINT permettant de delete un cours
# id en params pour cibler le bon cours
# return de l'objet supprimé
# app.delete




# CROS (Cross Origin)

# Installation du package
$ npm i cors

# import de cors
const cors  = require("cors");

# injection dans le middleware 
.use(cors())

# récupération d'une focntion  pour configurer notre corsPolicy
const corsPolicy = (req, res, next) => {
    res.header('Access-Control-Allow-Origin', '*')
    // authorized headers for preflight requests
    // https://developer.mozilla.org/en-US/docs/Glossary/preflight_request
    res.header(
        'Access-Control-Allow-Headers',
        'Origin, X-Requested-With, Content-Type, Accept',
    )
    next()
    app.options('*', (req, res) => {
        // allowed XHR methods
        res.header(
            'Access-Control-Allow-Methods',
            'GET, PATCH, PUT, POST, DELETE, OPTIONS',
        )
        res.send()
    })
} 

# injection dans le middleware
.use(corsPolicy)


# installation du package IP
$ npm i ip --save

# ajout de m2ifonction pour l'affichage dans la console

# Exercice 6
# Ajout du fonction afin de rendre permanent les changements dans la base de données en json

