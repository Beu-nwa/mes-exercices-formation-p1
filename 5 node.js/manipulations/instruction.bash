# initialidation du projet node.js
dans le terminal du dossier concerné !
$ npm init 

# Dans le package.json,  en dessous de : <"main": "index.js",> => ajouter 
"type": "module",

# ajouter dans les scripts le script start qui servira de raccouci pour le demarage de l'app
"start": "node index.js",
# pour lancer l'app index.js on peut donc faire :
# $ node index.js
# ou
# $ npm start

