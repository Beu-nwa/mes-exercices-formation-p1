// console.log("test");

// constante pour les lib express
const express = require(`express`);

// import list de cours
const coursList = require(`./data/coursList`);
console.table(coursList);

// instanciation d'express
const app = express();
const port = 7777;


// END POINT
// get -> http://localhost:7777
app.get(`/`, (req, res) => res.send(`Hello from node js\n`));
// get -> http://localhost:7777/api/cours/1
// app.get(`/api/cours/1`, (req, res) => res.send(`Welcome to my cours number ${id}\n`));

// Modification d'un new end point
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
    res.json({message: `il y a ${coursList.length} cours dans ma liste :`, data: coursList, error: false});
});


// Ecoute d'un port
app.listen(port, () => console.log(`L'application node.js est démarée\n\thttp://localhost:${port}`));





