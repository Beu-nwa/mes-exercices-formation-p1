// console.log("test");


// constante pour les lib express
const express = require(`express`);

const {readFileSync, writeFileSync} = require(`fs`);

// import list de cours format js
// let coursList = require(`./data/coursList`);
// console.table(coursList);

// import list de cours format json
let coursList = JSON.parse(readFileSync(`./data/savedCoursList.json`,`utf-8`));
console.table(coursList);

// instanciation d'express
const app = express();
const port = 7777;

// import de morgan (middleware)
const morgan = require(`morgan`);

// import de serve-favicon (librairie)
const favicon = require(`serve-favicon`);

// import des methodes "success" et "getUniqueId" dans helper.js
const { success, getUniqueId, M2iFunction } = require("./helpers");

// import de body-parser dans index.js
const bodyParser = require(`body-parser`)

// import des methodes "success" et "getUniqueId" dans helper.js
const cors = require("cors");

// création du service logger
const logger = (req, res, next) => {
    console.log(`URL: ${req.url}`);
    next();
};

// import de ip
// let get_ip = require(`ipware`)().get_ip;
let ip = require(`ip`);

// const corsPolicy = (req, res, next) => {
//     res.header('Access-Control-Allow-Origin', '*')
//     // authorized headers for preflight requests
//     // https://developer.mozilla.org/en-US/docs/Glossary/preflight_request
//     res.header(
//         'Access-Control-Allow-Headers',
//         'Origin, X-Requested-With, Content-Type, Accept',
//     )
//     next()
//     app.options('*', (req, res) => {
//         // allowed XHR methods
//         res.header(
//             'Access-Control-Allow-Methods',
//             'GET, PATCH, PUT, POST, DELETE, OPTIONS',
//         )
//         res.send()
//     })
// }

// const adressIp = (function (req, resn, next) {
//     var ip_info = get_ip(req);
//     console.log(ip_info);
//     // clientIp: `127.0.0.1`, clientIpRoutable: false
//     next();
// });

// injection des services, attention à l'ordre
app
    // .use(logger)
    .use(cors())
    // .use(corsPolicy)
    .use(favicon(__dirname + "/data/assets/favicon.ico"))
    .use(morgan(`dev`))
    .use(bodyParser.json())
    // .use(adressIp())


// END POINT
// get -> http://localhost:7777
app.get(`/`, (req, res) => res.send(`Hello from node js\n`));
// get -> http://localhost:7777/api/cours/1
// app.get(`/api/cours/1`, (req, res) => res.send(`Welcome to my cours number ${id}\n`));

// Ajout d'un new end point
app.get(`/api/cours/:id`, (req, res) => {
    const id = parseInt(req.params.id);
    let objetaAfficher = coursList.find(x => x.id == `${id}`);
    // let text;
    if (objetaAfficher != undefined) {
        //     text = `<br>
        // index: ${coursList.indexOf(objetaAfficher)}<br>
        // categorie: ${objetaAfficher.category}<br>
        // name: ${objetaAfficher.name}<br>
        // difficulte: ${objetaAfficher.difficulte}<br>
        // price: ${objetaAfficher.price}<br>
        // id: ${objetaAfficher.id}<br>
        // created: ${objetaAfficher.created}<br>`
        res.json(objetaAfficher);
    }
    else {
        // text = `<br> ce cours n'existe pas`;
        // res.send(`<br>${text}`)
        res.send("ce cours n'exxiste pas")
    }
});

// Exercice 2
// app.get(`/api/cours`, (req, res) => {
//     res.send(`il y a ${coursList.length} cours dans ma liste`);
// });

//  Exercice 3
app.get(`/api/cours`, (req, res) => {
    res.json({ message: `il y a ${coursList.length} cours dans ma liste :`, data: coursList, error: false });
});

// Affichage avec la fonction importée "success" depuis helpers.js
app.get(`/api`, (req, res) => {
    let message = `il y a ${coursList.length} cours dans ma liste de cours.`;
    res.json(success(message, coursList));
});

// Créer un new cours 
app.post(`/api/cours`, (req, res) => {
    // getUniqueId(coursList) envoi seulement la reference de chaque element et non les objets complets
    const nextId = getUniqueId(coursList);
    // const nextId = coursList.length + 1 ;
    const coursCreated = { ...req.body, ...{ id: nextId, created: new Date() } };
    coursList.push(coursCreated);
    saveList();
    let message = `Le cours n°: ${nextId} a été ajouté.`;
    res.json(success(message, coursCreated));
});

// Exercice 4
// Modification d'un new end point
app.put(`/api/cours/:id`, (req, res) => {
    const id = parseInt(req.params.id);
    const coursUpdated = { ...req.body, updated: new Date() };
    coursList = coursList.map(cours => {
        return cours.id === id ? coursUpdated : cours
    });
    saveList();
    let message = `Le cours n°: ${id} a été modifié`;
    res.json(success(message, coursUpdated));
});

// Exercice 5 Delete
app.delete(`/api/cours/:id`, (req, res) => {
    const id = parseInt(req.params.id);
    const coursDeleted = coursList.find(x => x.id === id);
    coursList = coursList.filter(cours => cours.id != id);
    let message = `Le cours n°: ${id} a été supprimé`;
    saveList();
    res.json(success(message, coursDeleted));
})

// Ecoute d'un port
// app.listen(port, () => console.log(`L'application node.js est démarée\n\thttp://localhost:${port}`));
app.listen(port, () => console.log(M2iFunction(port, ip.address())));


// Exercice 6 
function saveList(){
    const objectToJson = JSON.stringify(coursList);
    writeFileSync('./data/savedCoursList.json', objectToJson);
    console.log("Données sauvegardées");
}



